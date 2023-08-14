
namespace KyleGSchedulingSoftware
{
    partial class ConsultantReportForm
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
            this.consultantDataGridView = new System.Windows.Forms.DataGridView();
            this.reportCloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.consultantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // consultantDataGridView
            // 
            this.consultantDataGridView.AllowUserToAddRows = false;
            this.consultantDataGridView.AllowUserToDeleteRows = false;
            this.consultantDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultantDataGridView.Location = new System.Drawing.Point(12, 12);
            this.consultantDataGridView.Name = "consultantDataGridView";
            this.consultantDataGridView.ReadOnly = true;
            this.consultantDataGridView.RowHeadersVisible = false;
            this.consultantDataGridView.Size = new System.Drawing.Size(481, 358);
            this.consultantDataGridView.TabIndex = 0;
            // 
            // reportCloseBtn
            // 
            this.reportCloseBtn.Location = new System.Drawing.Point(12, 376);
            this.reportCloseBtn.Name = "reportCloseBtn";
            this.reportCloseBtn.Size = new System.Drawing.Size(481, 43);
            this.reportCloseBtn.TabIndex = 2;
            this.reportCloseBtn.Text = "CLOSE REPORT";
            this.reportCloseBtn.UseVisualStyleBackColor = true;
            this.reportCloseBtn.Click += new System.EventHandler(this.reportCloseBtn_Click);
            // 
            // ConsultantReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 429);
            this.Controls.Add(this.reportCloseBtn);
            this.Controls.Add(this.consultantDataGridView);
            this.Name = "ConsultantReportForm";
            this.Text = "ConsultantReportForm";
            this.Load += new System.EventHandler(this.ConsultantReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultantDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView consultantDataGridView;
        private System.Windows.Forms.Button reportCloseBtn;
    }
}