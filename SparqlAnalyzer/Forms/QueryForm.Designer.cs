namespace SparqlAnalyzer.Forms
{
    partial class QueryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryForm));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControlCountString = new DevExpress.XtraEditors.LabelControl();
            this.labelControlResultCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControlQueryString = new DevExpress.XtraEditors.LabelControl();
            this.labelControlQuery = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 38);
            this.gridControl.MainView = this.gridView1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(830, 389);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.UseIndicatorForSelection = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "Value1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "Value2";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.FieldName = "Value3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // progressPanel
            // 
            this.progressPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel.Appearance.Options.UseBackColor = true;
            this.progressPanel.BarAnimationElementThickness = 2;
            this.progressPanel.Caption = "Proszę czekać";
            this.progressPanel.Description = "Ładowanie danych...";
            this.progressPanel.Location = new System.Drawing.Point(318, 178);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(246, 66);
            this.progressPanel.TabIndex = 1;
            this.progressPanel.Text = "Proszę czekać";
            this.progressPanel.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControlCountString);
            this.panelControl1.Controls.Add(this.labelControlResultCount);
            this.panelControl1.Controls.Add(this.labelControlQueryString);
            this.panelControl1.Controls.Add(this.labelControlQuery);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(830, 38);
            this.panelControl1.TabIndex = 2;
            // 
            // labelControlCountString
            // 
            this.labelControlCountString.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControlCountString.Location = new System.Drawing.Point(730, 12);
            this.labelControlCountString.Name = "labelControlCountString";
            this.labelControlCountString.Size = new System.Drawing.Size(70, 13);
            this.labelControlCountString.TabIndex = 3;
            this.labelControlCountString.Text = "Ilość wyników:";
            // 
            // labelControlResultCount
            // 
            this.labelControlResultCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControlResultCount.Location = new System.Drawing.Point(806, 12);
            this.labelControlResultCount.Name = "labelControlResultCount";
            this.labelControlResultCount.Size = new System.Drawing.Size(12, 13);
            this.labelControlResultCount.TabIndex = 2;
            this.labelControlResultCount.Text = "50";
            // 
            // labelControlQueryString
            // 
            this.labelControlQueryString.Location = new System.Drawing.Point(80, 12);
            this.labelControlQueryString.Name = "labelControlQueryString";
            this.labelControlQueryString.Size = new System.Drawing.Size(0, 13);
            this.labelControlQueryString.TabIndex = 1;
            // 
            // labelControlQuery
            // 
            this.labelControlQuery.Location = new System.Drawing.Point(12, 12);
            this.labelControlQuery.Name = "labelControlQuery";
            this.labelControlQuery.Size = new System.Drawing.Size(52, 13);
            this.labelControlQuery.TabIndex = 0;
            this.labelControlQuery.Text = "Zapytanie:";
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(830, 427);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QueryForm";
            this.Text = "Zapytanie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControlQueryString;
        private DevExpress.XtraEditors.LabelControl labelControlQuery;
        private DevExpress.XtraEditors.LabelControl labelControlCountString;
        private DevExpress.XtraEditors.LabelControl labelControlResultCount;
    }
}