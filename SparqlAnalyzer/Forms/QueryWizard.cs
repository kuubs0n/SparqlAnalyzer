using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SparqlAnalyzer.General;

namespace SparqlAnalyzer.Forms
{
    public partial class QueryWizard : XtraForm
    {
        public QueryWizard()
        {
            InitializeComponent();
        }

        public bool LocalRdf { get; private set; } 

        public string RdfUrl => textEditUrl.Text;

        public string LocalRdfPath => textEditLocalPath.Text;

        public string SparqlQuery => memoEditQuery.Text;

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
                    wizardControl.SelectedPage = wizardPageQuery;
                }
            }
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
                wizardControl.SelectedPage.AllowFinish = true;
            else
                wizardControl.SelectedPage.AllowFinish = false;
        }

        private void AnalyzeQuery()
        {
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
    }
}