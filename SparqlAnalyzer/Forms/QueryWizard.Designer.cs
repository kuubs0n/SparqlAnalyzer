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
            this.wizardPageBasicQuery = new DevExpress.XtraWizard.WizardPage();
            this._panelControl = new DevExpress.XtraEditors.XtraScrollableControl();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.wizardPageQuery = new DevExpress.XtraWizard.WizardPage();
            this.memoEditQuery = new DevExpress.XtraEditors.MemoEdit();
            this._panelInfo = new DevExpress.XtraEditors.PanelControl();
            this._buttonAnalyze = new DevExpress.XtraEditors.SimpleButton();
            this._labelErrors = new DevExpress.XtraEditors.LabelControl();
            this._gridErrors = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl)).BeginInit();
            this.wizardControl.SuspendLayout();
            this.wizardPageWelcome.SuspendLayout();
            this.wizardPageRdfUrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUrl.Properties)).BeginInit();
            this.wizardPageRdfFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLocalPath.Properties)).BeginInit();
            this.wizardPageBasicQuery.SuspendLayout();
            this._panelControl.SuspendLayout();
            this.wizardPageQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditQuery.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._panelInfo)).BeginInit();
            this._panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridErrors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl
            // 
            this.wizardControl.Controls.Add(this.wizardPageWelcome);
            this.wizardControl.Controls.Add(this.wizardPageRdfUrl);
            this.wizardControl.Controls.Add(this.wizardPageRdfFile);
            this.wizardControl.Controls.Add(this.wizardPageBasicQuery);
            this.wizardControl.Controls.Add(this.wizardPageQuery);
            this.wizardControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl.Location = new System.Drawing.Point(0, 0);
            this.wizardControl.Name = "wizardControl";
            this.wizardControl.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.wizardPageWelcome,
            this.wizardPageRdfUrl,
            this.wizardPageRdfFile,
            this.wizardPageBasicQuery,
            this.wizardPageQuery});
            this.wizardControl.Size = new System.Drawing.Size(677, 432);
            this.wizardControl.Text = "Kreator SPARQL";
            this.wizardControl.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl_FinishClick);
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
            this.textEditLocalPath.EditValue = "C:\\Users\\Kuubs0n\\Desktop\\rdfexample.rdf";
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
            // wizardPageBasicQuery
            // 
            this.wizardPageBasicQuery.Controls.Add(this._panelControl);
            this.wizardPageBasicQuery.DescriptionText = "";
            this.wizardPageBasicQuery.Name = "wizardPageBasicQuery";
            this.wizardPageBasicQuery.Size = new System.Drawing.Size(617, 265);
            this.wizardPageBasicQuery.Text = "Podstawowe zapytanie SPARQL";
            // 
            // _panelControl
            // 
            this._panelControl.Controls.Add(this.hyperlinkLabelControl1);
            this._panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panelControl.Location = new System.Drawing.Point(0, 0);
            this._panelControl.Name = "_panelControl";
            this._panelControl.Size = new System.Drawing.Size(617, 265);
            this._panelControl.TabIndex = 0;
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(480, 0);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(106, 13);
            this.hyperlinkLabelControl1.TabIndex = 1;
            this.hyperlinkLabelControl1.Text = "Zaawansowane query";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // wizardPageQuery
            // 
            this.wizardPageQuery.AllowNext = false;
            this.wizardPageQuery.Controls.Add(this.memoEditQuery);
            this.wizardPageQuery.Controls.Add(this._panelInfo);
            this.wizardPageQuery.Controls.Add(this._gridErrors);
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
            this.memoEditQuery.Size = new System.Drawing.Size(617, 111);
            this.memoEditQuery.TabIndex = 0;
            this.memoEditQuery.EditValueChanged += new System.EventHandler(this.memoEditQuery_EditValueChanged);
            // 
            // _panelInfo
            // 
            this._panelInfo.Appearance.BackColor = System.Drawing.Color.White;
            this._panelInfo.Appearance.Options.UseBackColor = true;
            this._panelInfo.Controls.Add(this._buttonAnalyze);
            this._panelInfo.Controls.Add(this._labelErrors);
            this._panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._panelInfo.Location = new System.Drawing.Point(0, 111);
            this._panelInfo.Name = "_panelInfo";
            this._panelInfo.Size = new System.Drawing.Size(617, 39);
            this._panelInfo.TabIndex = 2;
            // 
            // _buttonAnalyze
            // 
            this._buttonAnalyze.Image = global::SparqlAnalyzer.Properties.Resources.spellcheckasyoutype_16x16;
            this._buttonAnalyze.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this._buttonAnalyze.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this._buttonAnalyze.Location = new System.Drawing.Point(541, 5);
            this._buttonAnalyze.Name = "_buttonAnalyze";
            this._buttonAnalyze.Size = new System.Drawing.Size(71, 29);
            this._buttonAnalyze.TabIndex = 11;
            this._buttonAnalyze.Text = "Analizuj";
            this._buttonAnalyze.Click += new System.EventHandler(this._buttonAnalyze_Click);
            // 
            // _labelErrors
            // 
            this._labelErrors.Location = new System.Drawing.Point(13, 12);
            this._labelErrors.Name = "_labelErrors";
            this._labelErrors.Size = new System.Drawing.Size(110, 13);
            this._labelErrors.TabIndex = 0;
            this._labelErrors.Text = "Lista błędów zapytania";
            // 
            // _gridErrors
            // 
            this._gridErrors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._gridErrors.Location = new System.Drawing.Point(0, 150);
            this._gridErrors.MainView = this.gridView1;
            this._gridErrors.Name = "_gridErrors";
            this._gridErrors.Size = new System.Drawing.Size(617, 115);
            this._gridErrors.TabIndex = 1;
            this._gridErrors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this._gridErrors;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
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
            this.wizardPageBasicQuery.ResumeLayout(false);
            this._panelControl.ResumeLayout(false);
            this._panelControl.PerformLayout();
            this.wizardPageQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEditQuery.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._panelInfo)).EndInit();
            this._panelInfo.ResumeLayout(false);
            this._panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._gridErrors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl _panelInfo;
        private DevExpress.XtraEditors.LabelControl _labelErrors;
        private DevExpress.XtraGrid.GridControl _gridErrors;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton _buttonAnalyze;
        private DevExpress.XtraWizard.WizardPage wizardPageBasicQuery;
        private DevExpress.XtraEditors.XtraScrollableControl _panelControl;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
    }
}