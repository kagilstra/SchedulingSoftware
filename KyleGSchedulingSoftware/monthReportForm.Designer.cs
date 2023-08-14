
namespace KyleGSchedulingSoftware
{
    partial class monthReportForm
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
            this.monthDataGridView = new System.Windows.Forms.DataGridView();
            this.reportCloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.monthDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // monthDataGridView
            // 
            this.monthDataGridView.AllowUserToAddRows = false;
            this.monthDataGridView.AllowUserToDeleteRows = false;
            this.monthDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monthDataGridView.Location = new System.Drawing.Point(12, 12);
            this.monthDataGridView.Name = "monthDataGridView";
            this.monthDataGridView.ReadOnly = true;
            this.monthDataGridView.RowHeadersVisible = false;
            this.monthDataGridView.Size = new System.Drawing.Size(481, 358);
            this.monthDataGridView.TabIndex = 1;
            // 
            // reportCloseBtn
            // 
            this.reportCloseBtn.Location = new System.Drawing.Point(12, 376);
            this.reportCloseBtn.Name = "reportCloseBtn";
            this.reportCloseBtn.Size = new System.Drawing.Size(481, 43);
            this.reportCloseBtn.TabIndex = 3;
            this.reportCloseBtn.Text = "CLOSE REPORT";
            this.reportCloseBtn.UseVisualStyleBackColor = true;
            this.reportCloseBtn.Click += new System.EventHandler(this.reportCloseBtn_Click);
            // 
            // monthReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 429);
            this.Controls.Add(this.reportCloseBtn);
            this.Controls.Add(this.monthDataGridView);
            this.Name = "monthReportForm";
            this.Text = "monthReportForm";
            this.Load += new System.EventHandler(this.monthReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monthDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView monthDataGridView;
        private System.Windows.Forms.Button reportCloseBtn;
    }
}