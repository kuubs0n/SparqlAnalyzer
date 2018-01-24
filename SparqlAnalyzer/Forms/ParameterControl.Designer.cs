namespace SparqlAnalyzer.Forms
{
    partial class ParameterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._labelArgumentName = new System.Windows.Forms.Label();
            this._textEditValue = new DevExpress.XtraEditors.TextEdit();
            this._checkEditResultsVisibility = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this._textEditValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._checkEditResultsVisibility.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _labelArgumentName
            // 
            this._labelArgumentName.AutoSize = true;
            this._labelArgumentName.Location = new System.Drawing.Point(12, 11);
            this._labelArgumentName.Name = "_labelArgumentName";
            this._labelArgumentName.Size = new System.Drawing.Size(83, 13);
            this._labelArgumentName.TabIndex = 0;
            this._labelArgumentName.Text = "Argument name";
            // 
            // _textEditValue
            // 
            this._textEditValue.Cursor = System.Windows.Forms.Cursors.Hand;
            this._textEditValue.Location = new System.Drawing.Point(128, 8);
            this._textEditValue.Name = "_textEditValue";
            this._textEditValue.Size = new System.Drawing.Size(100, 20);
            this._textEditValue.TabIndex = 1;
            this._textEditValue.ToolTip = "Podaj wartość parametru szukanego";
            // 
            // _checkEditResultsVisibility
            // 
            this._checkEditResultsVisibility.Location = new System.Drawing.Point(250, 8);
            this._checkEditResultsVisibility.Name = "_checkEditResultsVisibility";
            this._checkEditResultsVisibility.Properties.Caption = "Widoczny w wyniku";
            this._checkEditResultsVisibility.Size = new System.Drawing.Size(117, 19);
            this._checkEditResultsVisibility.TabIndex = 2;
            // 
            // ParameterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this._checkEditResultsVisibility);
            this.Controls.Add(this._textEditValue);
            this.Controls.Add(this._labelArgumentName);
            this.Name = "ParameterControl";
            this.Size = new System.Drawing.Size(378, 41);
            ((System.ComponentModel.ISupportInitialize)(this._textEditValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._checkEditResultsVisibility.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelArgumentName;
        private DevExpress.XtraEditors.TextEdit _textEditValue;
        private DevExpress.XtraEditors.CheckEdit _checkEditResultsVisibility;
    }
}
