namespace KyleGSchedulingSoftware
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.pleaseEnterLbl = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            resources.ApplyResources(this.loginBtn, "loginBtn");
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameBox
            // 
            resources.ApplyResources(this.usernameBox, "usernameBox");
            this.usernameBox.Name = "usernameBox";
            // 
            // passwordBox
            // 
            resources.ApplyResources(this.passwordBox, "passwordBox");
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameLbl
            // 
            resources.ApplyResources(this.usernameLbl, "usernameLbl");
            this.usernameLbl.Name = "usernameLbl";
            // 
            // passwordLbl
            // 
            resources.ApplyResources(this.passwordLbl, "passwordLbl");
            this.passwordLbl.Name = "passwordLbl";
            // 
            // pleaseEnterLbl
            // 
            resources.ApplyResources(this.pleaseEnterLbl, "pleaseEnterLbl");
            this.pleaseEnterLbl.Name = "pleaseEnterLbl";
            // 
            // loginLbl
            // 
            resources.ApplyResources(this.loginLbl, "loginLbl");
            this.loginLbl.Name = "loginLbl";
            // 
            // loginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.pleaseEnterLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.loginBtn);
            this.Name = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label pleaseEnterLbl;
        private System.Windows.Forms.Label loginLbl;
    }
}

