using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace SparqlAnalyzer.Forms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private LogoForm _logoForm;
        public MainForm()
        {
            InitializeComponent();
            UserLookAndFeel defaultLookAndFeel = UserLookAndFeel.Default;
            defaultLookAndFeel.SkinName = "Office 2016 Colorful";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _logoForm = new LogoForm();
            _logoForm.MdiParent = this;
            _logoForm.Show();
        }

        private void _barButtonNewQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QueryWizard queryWizard = new QueryWizard();
            DialogResult dialogResult = queryWizard.ShowDialog(this);

            if (dialogResult == DialogResult.OK)
            {
                if (queryWizard.LocalRdf)
                {
                    SparqlQueryData queryData = new SparqlQueryData(queryWizard.LocalRdfPath, queryWizard.SparqlQuery,
                        queryWizard.LocalRdf);
                    QueryForm queryForm = new QueryForm(queryData);
                    queryForm.MdiParent = this;
                    queryForm.Show();
                    _logoForm.Close();
                }
                else
                {
                    SparqlQueryData queryData = new SparqlQueryData(queryWizard.RdfUrl, queryWizard.SparqlQuery,
                        queryWizard.LocalRdf);
                    QueryForm queryForm = new QueryForm(queryData);
                    queryForm.MdiParent = this;
                    queryForm.Show();
                    _logoForm.Close();
                }
            }
        }
    }
}