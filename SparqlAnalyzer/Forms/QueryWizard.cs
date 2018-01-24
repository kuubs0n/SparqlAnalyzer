using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.WizardFramework;
using DevExpress.XtraEditors;
using SparqlAnalyzer.General;

namespace SparqlAnalyzer.Forms
{
    public partial class QueryWizard : XtraForm
    {
        private RdfService _rdfService;

        public QueryWizard()
        {
            InitializeComponent();
        }

        public bool LocalRdf { get; private set; } 

        public string RdfUrl => textEditUrl.Text;

        public string LocalRdfPath => textEditLocalPath.Text;

        public string RdfPath => LocalRdf ? LocalRdfPath : RdfUrl;

        public string SparqlQuery { get; set; }

        public IEnumerable<ParameterControl> ParameterControls => _panelControl.Controls.OfType<ParameterControl>();

        private string GetRdfFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LocalRdf = true;
                    return openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

            return string.Empty;
        }

        private void textEditUrl_Validating(object sender, CancelEventArgs e)
        {
            string textEditValue = textEditUrl.Text;
            Uri uriResult;
            bool result = Uri.TryCreate(textEditValue, UriKind.Absolute, out uriResult)
                          && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            if (!result)
                e.Cancel = true;
        }

        private void textEditUrl_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ErrorText = "To nie jest adres URL";
        }

        private void wizardControl_NextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
        {
            if (e.Page == wizardPageRdfUrl)
            {
                if (textEditUrl.DoValidate())
                {
                    LocalRdf = false;
                    wizardControl.SelectedPage = wizardPageBasicQuery;
                    PrepareRdfQueryParameters();
                }
            }
            if (e.Page == wizardPageRdfFile)
            {
                PrepareRdfQueryParameters();
            }
            if (e.Page == wizardPageBasicQuery)
            {
                if (IsParametersCorrect())
                {
                    PrepareRdfQuery();
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    XtraMessageBox.Show("Podałes za dużo widocznych elementów", "Błąd", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    e.Handled = true;
                }
            }
        }

        private bool IsParametersCorrect()
        {
            int count = 0;

            foreach (var control in ParameterControls)
            {
                if (control.IsVisible)
                    count++;
            }

            if (count > 2)
                return false;
            return true;
        }

        private void PrepareRdfQuery()
        {
            string query = $"PREFIX foaf:<{_rdfService.GetCdPrefix()}> ";

            query = query + "SELECT ?craft";

            foreach (ParameterControl control in ParameterControls)
            {
                if (control.IsVisible)
                {
                    query = query + " ?" + control.ParameterName;
                }
            }

            query = query + " { ?craft ";

            foreach (ParameterControl control in ParameterControls)
            {
                if (!string.IsNullOrEmpty(control.Value))
                {
                    query = query + $"foaf:{control.ParameterName} \"{control.Value}\";";
                }
            }

            foreach (ParameterControl control in ParameterControls)
            {
                if (control.IsVisible && !string.IsNullOrEmpty(control.ParameterName))
                {
                    query = query + $"foaf:{control.ParameterName} ?{control.ParameterName};";
                }
            }

            query = query + " }";

            SparqlQuery = query;
        }

        private void PrepareRdfQueryParameters()
        {
            try
            {
                _rdfService = new RdfService(RdfPath, LocalRdf);
                IEnumerable<string> stringParameters = _rdfService.GetPossibleRdfArguments();

                IEnumerable<ParameterControl> controls = CreateParametersControl(stringParameters);

                if (controls != null) _panelControl.Controls.AddRange(controls.ToArray());
            }
            catch (Exception ex)
            {
                wizardControl.SelectedPage = wizardPageQuery;
            }
        }

        private IEnumerable<ParameterControl> CreateParametersControl(IEnumerable<string> stringParameters)
        {
            ICollection<ParameterControl> controls = new List<ParameterControl>();

            foreach (var item in stringParameters)
            {
                ParameterControl control = new ParameterControl(item);
                var lastControl = controls.LastOrDefault();
                if(lastControl == null)
                    control.Location = new Point(3, 3);
                else
                    control.Location = new Point(lastControl.Location.X, lastControl.Location.Y + control.Height);

                controls.Add(control);
            }

            return controls;
        }

        private void simpleButtonLocalization_Click(object sender, EventArgs e)
        {
            string rdfPath = GetRdfFilePath();
            textEditLocalPath.Text = rdfPath;
        }

        private void hyperlinkLabelControlRdfLocal_Click(object sender, EventArgs e)
        {
            wizardControl.SelectedPage = wizardPageRdfFile;
        }

        private void textEditLocalPath_EditValueChanged(object sender, EventArgs e)
        {
            string rdfPath = textEditLocalPath.Text;
            if (rdfPath.EndsWith(".rdf") && File.Exists(rdfPath))
                wizardControl.SelectedPage.AllowNext = true;
            else
                wizardControl.SelectedPage.AllowNext = false;
        }

        private void textEditUrl_EditValueChanged(object sender, EventArgs e)
        {
            wizardControl.SelectedPage.AllowNext = !String.IsNullOrEmpty(textEditUrl.Text);
        }

        private void memoEditQuery_EditValueChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(memoEditQuery.Text))
            {
                SparqlQuery = memoEditQuery.Text;
                wizardControl.SelectedPage.AllowFinish = true;
            }
            else
            {
                SparqlQuery = memoEditQuery.Text;
                wizardControl.SelectedPage.AllowFinish = false;
            }
        }

        private void AnalyzeQuery()
        {
            SparqlQuery = memoEditQuery.Text;
            QueryAnalizer queryAnalizer = new QueryAnalizer(SparqlQuery);
            AnalyzeResult analyzeResults = queryAnalizer.AnalyzeQuery();

            if (!analyzeResults.IsCorrectQuery)
            {
                _buttonAnalyze.Image = SparqlAnalyzer.Properties.Resources.cancel_16x16;
                _gridErrors.DataSource = analyzeResults.ErrorMessages;
            }
            else
            {
                _buttonAnalyze.Image = SparqlAnalyzer.Properties.Resources.apply_16x16;
                _gridErrors.DataSource = new object[] { };
            }
        }

        private void _buttonAnalyze_Click(object sender, EventArgs e)
        {
            AnalyzeQuery();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            wizardControl.SelectedPage = wizardPageQuery;
        }

        private void wizardControl_FinishClick(object sender, CancelEventArgs e)
        {
            SparqlQuery = memoEditQuery.Text;
        }
    }
}