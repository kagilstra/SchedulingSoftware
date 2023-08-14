
namespace KyleGSchedulingSoftware
{
    partial class AddAppointmentForm
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
            this.addAppointmentCusIDLbl = new System.Windows.Forms.Label();
            this.addAppointmentTypeLbl = new System.Windows.Forms.Label();
            this.addAppointmentEndLbl = new System.Windows.Forms.Label();
            this.addAppointmentEndDTP = new System.Windows.Forms.DateTimePicker();
            this.addAppointmentStartDTP = new System.Windows.Forms.DateTimePicker();
            this.addAppointmentTypeBox = new System.Windows.Forms.TextBox();
            this.addAppointmentCusIDBox = new System.Windows.Forms.TextBox();
            this.addAppointmentInfoLbl = new System.Windows.Forms.Label();
            this.addAppointmentStartLbl = new System.Windows.Forms.Label();
            this.addAppointmentBtn = new System.Windows.Forms.Button();
            this.addAppointmentCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addAppointmentCusIDLbl
            // 
            this.addAppointmentCusIDLbl.AutoSize = true;
            this.addAppointmentCusIDLbl.Location = new System.Drawing.Point(43, 63);
            this.addAppointmentCusIDLbl.Name = "addAppointmentCusIDLbl";
            this.addAppointmentCusIDLbl.Size = new System.Drawing.Size(68, 13);
            this.addAppointmentCusIDLbl.TabIndex = 0;
            this.addAppointmentCusIDLbl.Text = "Customer ID:";
            // 
            // addAppointmentTypeLbl
            // 
            this.addAppointmentTypeLbl.AutoSize = true;
            this.addAppointmentTypeLbl.Location = new System.Drawing.Point(15, 103);
            this.addAppointmentTypeLbl.Name = "addAppointmentTypeLbl";
            this.addAppointmentTypeLbl.Size = new System.Drawing.Size(96, 13);
            this.addAppointmentTypeLbl.TabIndex = 2;
            this.addAppointmentTypeLbl.Text = "Appointment Type:";
            // 
            // addAppointmentEndLbl
            // 
            this.addAppointmentEndLbl.AutoSize = true;
            this.addAppointmentEndLbl.Location = new System.Drawing.Point(20, 187);
            this.addAppointmentEndLbl.Name = "addAppointmentEndLbl";
            this.addAppointmentEndLbl.Size = new System.Drawing.Size(91, 13);
            this.addAppointmentEndLbl.TabIndex = 4;
            this.addAppointmentEndLbl.Text = "Appointment End:";
            // 
            // addAppointmentEndDTP
            // 
            this.addAppointmentEndDTP.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.addAppointmentEndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.addAppointmentEndDTP.Location = new System.Drawing.Point(120, 180);
            this.addAppointmentEndDTP.Name = "addAppointmentEndDTP";
            this.addAppointmentEndDTP.Size = new System.Drawing.Size(138, 20);
            this.addAppointmentEndDTP.TabIndex = 5;
            this.addAppointmentEndDTP.ValueChanged += new System.EventHandler(this.addAppointmentEndDTP_ValueChanged);
            // 
            // addAppointmentStartDTP
            // 
            this.addAppointmentStartDTP.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.addAppointmentStartDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.addAppointmentStartDTP.Location = new System.Drawing.Point(120, 140);
            this.addAppointmentStartDTP.Name = "addAppointmentStartDTP";
            this.addAppointmentStartDTP.Size = new System.Drawing.Size(138, 20);
            this.addAppointmentStartDTP.TabIndex = 6;
            this.addAppointmentStartDTP.ValueChanged += new System.EventHandler(this.addAppointmentStartDTP_ValueChanged);
            // 
            // addAppointmentTypeBox
            // 
            this.addAppointmentTypeBox.Location = new System.Drawing.Point(120, 100);
            this.addAppointmentTypeBox.Name = "addAppointmentTypeBox";
            this.addAppointmentTypeBox.Size = new System.Drawing.Size(138, 20);
            this.addAppointmentTypeBox.TabIndex = 7;
            // 
            // addAppointmentCusIDBox
            // 
            this.addAppointmentCusIDBox.Location = new System.Drawing.Point(120, 60);
            this.addAppointmentCusIDBox.Name = "addAppointmentCusIDBox";
            this.addAppointmentCusIDBox.Size = new System.Drawing.Size(138, 20);
            this.addAppointmentCusIDBox.TabIndex = 8;
            // 
            // addAppointmentInfoLbl
            // 
            this.addAppointmentInfoLbl.AutoSize = true;
            this.addAppointmentInfoLbl.Location = new System.Drawing.Point(74, 22);
            this.addAppointmentInfoLbl.Name = "addAppointmentInfoLbl";
            this.addAppointmentInfoLbl.Size = new System.Drawing.Size(181, 13);
            this.addAppointmentInfoLbl.TabIndex = 9;
            this.addAppointmentInfoLbl.Text = "Please enter appointment information";
            // 
            // addAppointmentStartLbl
            // 
            this.addAppointmentStartLbl.AutoSize = true;
            this.addAppointmentStartLbl.Location = new System.Drawing.Point(17, 146);
            this.addAppointmentStartLbl.Name = "addAppointmentStartLbl";
            this.addAppointmentStartLbl.Size = new System.Drawing.Size(94, 13);
            this.addAppointmentStartLbl.TabIndex = 10;
            this.addAppointmentStartLbl.Text = "Appointment Start:";
            // 
            // addAppointmentBtn
            // 
            this.addAppointmentBtn.Location = new System.Drawing.Point(77, 223);
            this.addAppointmentBtn.Name = "addAppointmentBtn";
            this.addAppointmentBtn.Size = new System.Drawing.Size(75, 23);
            this.addAppointmentBtn.TabIndex = 11;
            this.addAppointmentBtn.Text = "Add";
            this.addAppointmentBtn.UseVisualStyleBackColor = true;
            this.addAppointmentBtn.Click += new System.EventHandler(this.addAppointmentBtn_Click);
            // 
            // addAppointmentCancelBtn
            // 
            this.addAppointmentCancelBtn.Location = new System.Drawing.Point(183, 223);
            this.addAppointmentCancelBtn.Name = "addAppointmentCancelBtn";
            this.addAppointmentCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.addAppointmentCancelBtn.TabIndex = 12;
            this.addAppointmentCancelBtn.Text = "Cancel";
            this.addAppointmentCancelBtn.UseVisualStyleBackColor = true;
            this.addAppointmentCancelBtn.Click += new System.EventHandler(this.addAppointmentCancelBtn_Click);
            // 
            // AddAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 272);
            this.Controls.Add(this.addAppointmentCancelBtn);
            this.Controls.Add(this.addAppointmentBtn);
            this.Controls.Add(this.addAppointmentStartLbl);
            this.Controls.Add(this.addAppointmentInfoLbl);
            this.Controls.Add(this.addAppointmentCusIDBox);
            this.Controls.Add(this.addAppointmentTypeBox);
            this.Controls.Add(this.addAppointmentStartDTP);
            this.Controls.Add(this.addAppointmentEndDTP);
            this.Controls.Add(this.addAppointmentEndLbl);
            this.Controls.Add(this.addAppointmentTypeLbl);
            this.Controls.Add(this.addAppointmentCusIDLbl);
            this.Name = "AddAppointmentForm";
            this.Text = "Add  Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addAppointmentCusIDLbl;
        private System.Windows.Forms.Label addAppointmentTypeLbl;
        private System.Windows.Forms.Label addAppointmentEndLbl;
        private System.Windows.Forms.DateTimePicker addAppointmentEndDTP;
        private System.Windows.Forms.DateTimePicker addAppointmentStartDTP;
        private System.Windows.Forms.TextBox addAppointmentTypeBox;
        private System.Windows.Forms.TextBox addAppointmentCusIDBox;
        private System.Windows.Forms.Label addAppointmentInfoLbl;
        private System.Windows.Forms.Label addAppointmentStartLbl;
        private System.Windows.Forms.Button addAppointmentBtn;
        private System.Windows.Forms.Button addAppointmentCancelBtn;
    }
}