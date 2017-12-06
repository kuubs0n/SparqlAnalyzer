namespace SparqlAnalyzer.Forms
{
    partial class QueryWizard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryWizard));
            this.wizardControl = new DevExpress.XtraWizard.WizardControl();
            this.wizardPageWelcome = new DevExpress.XtraWizard.WizardPage();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.wizardPageRdfUrl = new DevExpress.XtraWizard.WizardPage();
            this.hyperlinkLabelControlRdfLocal = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditUrl = new DevExpress.XtraEditors.TextEdit();
            this.wizardPageRdfFile = new DevExpress.XtraWizard.WizardPage();
            this.simpleButtonLocalization = new DevExpress.XtraEditors.SimpleButton();
            this.textEditLocalPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.wizardPageQuery = new DevExpress.XtraWizard.WizardPage();
            this.memoEditQuery = new DevExpress.XtraEditors.MemoEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
            this.wizardControl.SuspendLayout();
            this.wizardPageWelcome.SuspendLayout();
            this.wizardPageRdfUrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrl.Properties)).BeginInit();
            this.wizardPageRdfFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLocalPath.Properties)).BeginInit();
            this.wizardPageQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl
            // 
            this.wizardControl.Controls.Add(this.wizardPageWelcome);
            this.wizardControl.Controls.Add(this.wizardPageRdfUrl);
            this.wizardControl.Controls.Add(this.wizardPageRdfFile);
            this.wizardControl.Controls.Add(this.wizardPageQuery);
            this.wizardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl.Location = new System.Drawing.Point(0, 0);
            this.wizardControl.Name = "wizardControl";
            this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.wizardPageWelcome,
            this.wizardPageRdfUrl,
            this.wizardPageRdfFile,
            this.wizardPageQuery});
            this.wizardControl.Size = new System.Drawing.Size(677, 432);
            this.wizardControl.Text = "Kreator SPARQL";
            this.wizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl_NextClick);
            // 
            // wizardPageWelcome
            // 
            this.wizardPageWelcome.Controls.Add(this.labelControl1);
            this.wizardPageWelcome.Name = "wizardPageWelcome";
            this.wizardPageWelcome.Size = new System.Drawing.Size(617, 265);
            this.wizardPageWelcome.Text = "Witaj w kreatorze SPARQL";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(420, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Witaj w kreatorze zapytań SPARQL.\r\n\r\nW następnych krokach będziesz musiał podać ź" +
    "ródło bazy RDF oraz zapytanie SPARQL.";
            // 
            // wizardPageRdfUrl
            // 
            this.wizardPageRdfUrl.AllowFinish = false;
            this.wizardPageRdfUrl.Controls.Add(this.hyperlinkLabelControlRdfLocal);
            this.wizardPageRdfUrl.Controls.Add(this.labelControl2);
            this.wizardPageRdfUrl.Controls.Add(this.textEditUrl);
            this.wizardPageRdfUrl.Name = "wizardPageRdfUrl";
            this.wizardPageRdfUrl.Size = new System.Drawing.Size(617, 265);
            this.wizardPageRdfUrl.Text = "Wybierz źródło RDF";
            // 
            // hyperlinkLabelControlRdfLocal
            // 
            this.hyperlinkLabelControlRdfLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlinkLabelControlRdfLocal.Location = new System.Drawing.Point(208, 94);
            this.hyperlinkLabelControlRdfLocal.Name = "hyperlinkLabelControlRdfLocal";
            this.hyperlinkLabelControlRdfLocal.Size = new System.Drawing.Size(158, 13);
            this.hyperlinkLabelControlRdfLocal.TabIndex = 2;
            this.hyperlinkLabelControlRdfLocal.Text = "Skorzystam z lokalnego pliku RDF";
            this.hyperlinkLabelControlRdfLocal.Click += new System.EventHandler(this.hyperlinkLabelControlRdfLocal_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(23, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "URL:";
            // 
            // textEditUrl
            // 
            this.textEditUrl.EditValue = "http://bnb.data.bl.uk/sparql";
            this.textEditUrl.Location = new System.Drawing.Point(73, 57);
            this.textEditUrl.Name = "textEditUrl";
            this.textEditUrl.Size = new System.Drawing.Size(525, 20);
            this.textEditUrl.TabIndex = 0;
            this.textEditUrl.InvalidValue += new DevExpress.XtraEditors.Controls.InvalidValueExceptionEventHandler(this.textEditUrl_InvalidValue);
            this.textEditUrl.EditValueChanged += new System.EventHandler(this.textEditUrl_EditValueChanged);
            this.textEditUrl.Validating += new System.ComponentModel.CancelEventHandler(this.textEditUrl_Validating);
            // 
            // wizardPageRdfFile
            // 
            this.wizardPageRdfFile.AllowFinish = false;
            this.wizardPageRdfFile.Controls.Add(this.simpleButtonLocalization);
            this.wizardPageRdfFile.Controls.Add(this.textEditLocalPath);
            this.wizardPageRdfFile.Controls.Add(this.labelControl3);
            this.wizardPageRdfFile.Name = "wizardPageRdfFile";
            this.wizardPageRdfFile.Size = new System.Drawing.Size(617, 265);
            this.wizardPageRdfFile.Text = "Wybierz źródło RDF";
            // 
            // simpleButtonLocalization
            // 
            this.simpleButtonLocalization.Location = new System.Drawing.Point(581, 57);
            this.simpleButtonLocalization.Name = "simpleButtonLocalization";
            this.simpleButtonLocalization.Size = new System.Drawing.Size(20, 20);
            this.simpleButtonLocalization.TabIndex = 2;
            this.simpleButtonLocalization.Text = "...";
            this.simpleButtonLocalization.Click += new System.EventHandler(this.simpleButtonLocalization_Click);
            // 
            // textEditLocalPath
            // 
            this.textEditLocalPath.Location = new System.Drawing.Point(73, 57);
            this.textEditLocalPath.Name = "textEditLocalPath";
            this.textEditLocalPath.Size = new System.Drawing.Size(502, 20);
            this.textEditLocalPath.TabIndex = 1;
            this.textEditLocalPath.EditValueChanged += new System.EventHandler(this.textEditLocalPath_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Lokalizacja:";
            // 
            // wizardPageQuery
            // 
            this.wizardPageQuery.AllowNext = false;
            this.wizardPageQuery.Controls.Add(this.memoEditQuery);
            this.wizardPageQuery.Name = "wizardPageQuery";
            this.wizardPageQuery.Size = new System.Drawing.Size(617, 265);
            this.wizardPageQuery.Text = "Zapytanie SPARQL";
            // 
            // memoEditQuery
            // 
            this.memoEditQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEditQuery.EditValue = "SELECT * WHERE {  ?sub ?pre ?term. } LIMIT 10";
            this.memoEditQuery.Location = new System.Drawing.Point(0, 0);
            this.memoEditQuery.Name = "memoEditQuery";
            this.memoEditQuery.Size = new System.Drawing.Size(617, 265);
            this.memoEditQuery.TabIndex = 0;
            this.memoEditQuery.EditValueChanged += new System.EventHandler(this.memoEditQuery_EditValueChanged);
            // 
            // QueryWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 432);
            this.Controls.Add(this.wizardControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QueryWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreator zapytania";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).EndInit();
            this.wizardControl.ResumeLayout(false);
            this.wizardPageWelcome.ResumeLayout(false);
            this.wizardPageWelcome.PerformLayout();
            this.wizardPageRdfUrl.ResumeLayout(false);
            this.wizardPageRdfUrl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrl.Properties)).EndInit();
            this.wizardPageRdfFile.ResumeLayout(false);
            this.wizardPageRdfFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLocalPath.Properties)).EndInit();
            this.wizardPageQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl;
        private DevExpress.XtraWizard.WizardPage wizardPageWelcome;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraWizard.WizardPage wizardPageRdfUrl;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControlRdfLocal;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditUrl;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraWizard.WizardPage wizardPageRdfFile;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLocalization;
        private DevExpress.XtraEditors.TextEdit textEditLocalPath;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraWizard.WizardPage wizardPageQuery;
        private DevExpress.XtraEditors.MemoEdit memoEditQuery;
    }
}