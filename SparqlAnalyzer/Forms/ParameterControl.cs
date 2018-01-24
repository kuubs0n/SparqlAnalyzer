using DevExpress.XtraEditors;

namespace SparqlAnalyzer.Forms
{
    public partial class ParameterControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ParameterControl(string caption)
        {
            InitializeComponent();

            _labelArgumentName.Text = caption;
        }

        public string Value => _textEditValue.Text;

        public bool IsVisible => _checkEditResultsVisibility.Checked;

        public string ParameterName => _labelArgumentName.Text;
    }
}
