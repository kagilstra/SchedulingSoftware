
namespace KyleGSchedulingSoftware
{
    partial class CustomersReportsForm
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
            this.cusReportDataGridView = new System.Windows.Forms.DataGridView();
            this.reportCloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cusReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cusReportDataGridView
            // 
            this.cusReportDataGridView.AllowUserToAddRows = false;
            this.cusReportDataGridView.AllowUserToDeleteRows = false;
            this.cusReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cusReportDataGridView.Location = new System.Drawing.Point(12, 12);
            this.cusReportDataGridView.Name = "cusReportDataGridView";
            this.cusReportDataGridView.ReadOnly = true;
            this.cusReportDataGridView.RowHeadersVisible = false;
            this.cusReportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cusReportDataGridView.Size = new System.Drawing.Size(481, 358);
            this.cusReportDataGridView.TabIndex = 0;
            // 
            // reportCloseBtn
            // 
            this.reportCloseBtn.Location = new System.Drawing.Point(12, 378);
            this.reportCloseBtn.Name = "reportCloseBtn";
            this.reportCloseBtn.Size = new System.Drawing.Size(481, 43);
            this.reportCloseBtn.TabIndex = 1;
            this.reportCloseBtn.Text = "CLOSE REPORT";
            this.reportCloseBtn.UseVisualStyleBackColor = true;
            this.reportCloseBtn.Click += new System.EventHandler(this.reportCloseBtn_Click);
            // 
            // CustomersReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 429);
            this.Controls.Add(this.reportCloseBtn);
            this.Controls.Add(this.cusReportDataGridView);
            this.Name = "CustomersReportsForm";
            this.Text = "Customers Report Form";
            this.Load += new System.EventHandler(this.CustomersReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cusReportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView cusReportDataGridView;
        private System.Windows.Forms.Button reportCloseBtn;
    }
}