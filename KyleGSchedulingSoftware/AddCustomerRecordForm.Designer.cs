
namespace KyleGSchedulingSoftware
{
    partial class AddCustomerRecordForm
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
            this.addCusNameBox = new System.Windows.Forms.TextBox();
            this.addCusAddressBox = new System.Windows.Forms.TextBox();
            this.addCusPostalBox = new System.Windows.Forms.TextBox();
            this.addCusCityBox = new System.Windows.Forms.TextBox();
            this.addCusCountryBox = new System.Windows.Forms.TextBox();
            this.addCusNameLbl = new System.Windows.Forms.Label();
            this.addCusPhoneLbl = new System.Windows.Forms.Label();
            this.addCusAddressLbl = new System.Windows.Forms.Label();
            this.addCusPostalLbl = new System.Windows.Forms.Label();
            this.addCusCityLbl = new System.Windows.Forms.Label();
            this.addCusCountryLbl = new System.Windows.Forms.Label();
            this.addCusRecordCreateBtn = new System.Windows.Forms.Button();
            this.addCusRecordCancelBtn = new System.Windows.Forms.Button();
            this.addCusWarningLbl = new System.Windows.Forms.Label();
            this.addCusPhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // addCusNameBox
            // 
            this.addCusNameBox.Location = new System.Drawing.Point(155, 65);
            this.addCusNameBox.Name = "addCusNameBox";
            this.addCusNameBox.Size = new System.Drawing.Size(120, 20);
            this.addCusNameBox.TabIndex = 0;
            this.addCusNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCusNameBox_KeyPress);
            // 
            // addCusAddressBox
            // 
            this.addCusAddressBox.Location = new System.Drawing.Point(155, 135);
            this.addCusAddressBox.Name = "addCusAddressBox";
            this.addCusAddressBox.Size = new System.Drawing.Size(120, 20);
            this.addCusAddressBox.TabIndex = 2;
            // 
            // addCusPostalBox
            // 
            this.addCusPostalBox.Location = new System.Drawing.Point(155, 170);
            this.addCusPostalBox.Name = "addCusPostalBox";
            this.addCusPostalBox.Size = new System.Drawing.Size(120, 20);
            this.addCusPostalBox.TabIndex = 3;
            // 
            // addCusCityBox
            // 
            this.addCusCityBox.Location = new System.Drawing.Point(155, 205);
            this.addCusCityBox.Name = "addCusCityBox";
            this.addCusCityBox.Size = new System.Drawing.Size(120, 20);
            this.addCusCityBox.TabIndex = 4;
            this.addCusCityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCusCityBox_KeyPress);
            // 
            // addCusCountryBox
            // 
            this.addCusCountryBox.Location = new System.Drawing.Point(155, 240);
            this.addCusCountryBox.Name = "addCusCountryBox";
            this.addCusCountryBox.Size = new System.Drawing.Size(120, 20);
            this.addCusCountryBox.TabIndex = 5;
            this.addCusCountryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCusCountryBox_KeyPress);
            // 
            // addCusNameLbl
            // 
            this.addCusNameLbl.AutoSize = true;
            this.addCusNameLbl.Location = new System.Drawing.Point(82, 68);
            this.addCusNameLbl.Name = "addCusNameLbl";
            this.addCusNameLbl.Size = new System.Drawing.Size(38, 13);
            this.addCusNameLbl.TabIndex = 6;
            this.addCusNameLbl.Text = "Name:";
            // 
            // addCusPhoneLbl
            // 
            this.addCusPhoneLbl.AutoSize = true;
            this.addCusPhoneLbl.Location = new System.Drawing.Point(82, 103);
            this.addCusPhoneLbl.Name = "addCusPhoneLbl";
            this.addCusPhoneLbl.Size = new System.Drawing.Size(41, 13);
            this.addCusPhoneLbl.TabIndex = 7;
            this.addCusPhoneLbl.Text = "Phone:";
            // 
            // addCusAddressLbl
            // 
            this.addCusAddressLbl.AutoSize = true;
            this.addCusAddressLbl.Location = new System.Drawing.Point(82, 138);
            this.addCusAddressLbl.Name = "addCusAddressLbl";
            this.addCusAddressLbl.Size = new System.Drawing.Size(48, 13);
            this.addCusAddressLbl.TabIndex = 8;
            this.addCusAddressLbl.Text = "Address:";
            // 
            // addCusPostalLbl
            // 
            this.addCusPostalLbl.AutoSize = true;
            this.addCusPostalLbl.Location = new System.Drawing.Point(82, 173);
            this.addCusPostalLbl.Name = "addCusPostalLbl";
            this.addCusPostalLbl.Size = new System.Drawing.Size(67, 13);
            this.addCusPostalLbl.TabIndex = 9;
            this.addCusPostalLbl.Text = "Postal Code:";
            // 
            // addCusCityLbl
            // 
            this.addCusCityLbl.AutoSize = true;
            this.addCusCityLbl.Location = new System.Drawing.Point(82, 208);
            this.addCusCityLbl.Name = "addCusCityLbl";
            this.addCusCityLbl.Size = new System.Drawing.Size(27, 13);
            this.addCusCityLbl.TabIndex = 10;
            this.addCusCityLbl.Text = "City:";
            // 
            // addCusCountryLbl
            // 
            this.addCusCountryLbl.AutoSize = true;
            this.addCusCountryLbl.Location = new System.Drawing.Point(82, 243);
            this.addCusCountryLbl.Name = "addCusCountryLbl";
            this.addCusCountryLbl.Size = new System.Drawing.Size(46, 13);
            this.addCusCountryLbl.TabIndex = 11;
            this.addCusCountryLbl.Text = "Country:";
            // 
            // addCusRecordCreateBtn
            // 
            this.addCusRecordCreateBtn.Location = new System.Drawing.Point(85, 275);
            this.addCusRecordCreateBtn.Name = "addCusRecordCreateBtn";
            this.addCusRecordCreateBtn.Size = new System.Drawing.Size(75, 23);
            this.addCusRecordCreateBtn.TabIndex = 12;
            this.addCusRecordCreateBtn.Text = "Create";
            this.addCusRecordCreateBtn.UseVisualStyleBackColor = true;
            this.addCusRecordCreateBtn.Click += new System.EventHandler(this.addCusRecordCreateBtn_Click);
            // 
            // addCusRecordCancelBtn
            // 
            this.addCusRecordCancelBtn.Location = new System.Drawing.Point(200, 275);
            this.addCusRecordCancelBtn.Name = "addCusRecordCancelBtn";
            this.addCusRecordCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.addCusRecordCancelBtn.TabIndex = 13;
            this.addCusRecordCancelBtn.Text = "Cancel";
            this.addCusRecordCancelBtn.UseVisualStyleBackColor = true;
            this.addCusRecordCancelBtn.Click += new System.EventHandler(this.addCusRecordCancelBtn_Click);
            // 
            // addCusWarningLbl
            // 
            this.addCusWarningLbl.AutoSize = true;
            this.addCusWarningLbl.Location = new System.Drawing.Point(106, 29);
            this.addCusWarningLbl.Name = "addCusWarningLbl";
            this.addCusWarningLbl.Size = new System.Drawing.Size(134, 13);
            this.addCusWarningLbl.TabIndex = 14;
            this.addCusWarningLbl.Text = "Please fill out all Infomation";
            // 
            // addCusPhoneBox
            // 
            this.addCusPhoneBox.Location = new System.Drawing.Point(155, 100);
            this.addCusPhoneBox.Mask = "(999) 000-0000";
            this.addCusPhoneBox.Name = "addCusPhoneBox";
            this.addCusPhoneBox.Size = new System.Drawing.Size(120, 20);
            this.addCusPhoneBox.TabIndex = 15;
            this.addCusPhoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addCusPhoneBox_KeyPress_1);
            // 
            // AddCustomerRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 331);
            this.Controls.Add(this.addCusPhoneBox);
            this.Controls.Add(this.addCusWarningLbl);
            this.Controls.Add(this.addCusRecordCancelBtn);
            this.Controls.Add(this.addCusRecordCreateBtn);
            this.Controls.Add(this.addCusCountryLbl);
            this.Controls.Add(this.addCusCityLbl);
            this.Controls.Add(this.addCusPostalLbl);
            this.Controls.Add(this.addCusAddressLbl);
            this.Controls.Add(this.addCusPhoneLbl);
            this.Controls.Add(this.addCusNameLbl);
            this.Controls.Add(this.addCusCountryBox);
            this.Controls.Add(this.addCusCityBox);
            this.Controls.Add(this.addCusPostalBox);
            this.Controls.Add(this.addCusAddressBox);
            this.Controls.Add(this.addCusNameBox);
            this.Name = "AddCustomerRecordForm";
            this.Text = "Create Customer Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addCusNameBox;
        private System.Windows.Forms.TextBox addCusAddressBox;
        private System.Windows.Forms.TextBox addCusPostalBox;
        private System.Windows.Forms.TextBox addCusCityBox;
        private System.Windows.Forms.TextBox addCusCountryBox;
        private System.Windows.Forms.Label addCusNameLbl;
        private System.Windows.Forms.Label addCusPhoneLbl;
        private System.Windows.Forms.Label addCusAddressLbl;
        private System.Windows.Forms.Label addCusPostalLbl;
        private System.Windows.Forms.Label addCusCityLbl;
        private System.Windows.Forms.Label addCusCountryLbl;
        private System.Windows.Forms.Button addCusRecordCreateBtn;
        private System.Windows.Forms.Button addCusRecordCancelBtn;
        private System.Windows.Forms.Label addCusWarningLbl;
        private System.Windows.Forms.MaskedTextBox addCusPhoneBox;
    }
}