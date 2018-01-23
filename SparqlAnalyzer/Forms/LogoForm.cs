using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SparqlAnalyzer.Forms
{
    public partial class LogoForm : DevExpress.XtraEditors.XtraForm
    {
        public LogoForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InvokeLostFocus(pictureEdit1, EventArgs.Empty);
        }
    }
}