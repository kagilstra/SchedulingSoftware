namespace KyleGSchedulingSoftware
{
    partial class MainScreenForm
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
            this.appointmentCalendarDGV = new System.Windows.Forms.DataGridView();
            this.ScheduletLbl = new System.Windows.Forms.Label();
            this.cusRecordLbl = new System.Windows.Forms.Label();
            this.addCusRecordBtn = new System.Windows.Forms.Button();
            this.deleteCusRecordBtn = new System.Windows.Forms.Button();
            this.modifyCusRecordBtn = new System.Windows.Forms.Button();
            this.appointmentsLbl = new System.Windows.Forms.Label();
            this.addAppointmentBtn = new System.Windows.Forms.Button();
            this.modifyAppointmentBtn = new System.Windows.Forms.Button();
            this.deleteAppointmentBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.calendarViewLbl = new System.Windows.Forms.Label();
            this.genMonthsReportBtn = new System.Windows.Forms.Button();
            this.generateReportLbl = new System.Windows.Forms.Label();
            this.genCusReportBtn = new System.Windows.Forms.Button();
            this.genConsultantReportBtn = new System.Windows.Forms.Button();
            this.monthViewBtn = new System.Windows.Forms.Button();
            this.weekViewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCalendarDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentCalendarDGV
            // 
            this.appointmentCalendarDGV.AllowUserToAddRows = false;
            this.appointmentCalendarDGV.CausesValidation = false;
            this.appointmentCalendarDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.appointmentCalendarDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentCalendarDGV.Location = new System.Drawing.Point(297, 32);
            this.appointmentCalendarDGV.Name = "appointmentCalendarDGV";
            this.appointmentCalendarDGV.ReadOnly = true;
            this.appointmentCalendarDGV.RowHeadersVisible = false;
            this.appointmentCalendarDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentCalendarDGV.Size = new System.Drawing.Size(676, 365);
            this.appointmentCalendarDGV.TabIndex = 0;
            // 
            // ScheduletLbl
            // 
            this.ScheduletLbl.AutoSize = true;
            this.ScheduletLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduletLbl.Location = new System.Drawing.Point(529, 9);
            this.ScheduletLbl.Name = "ScheduletLbl";
            this.ScheduletLbl.Size = new System.Drawing.Size(197, 20);
            this.ScheduletLbl.TabIndex = 1;
            this.ScheduletLbl.Text = "Appointments Calendar";
            // 
            // cusRecordLbl
            // 
            this.cusRecordLbl.AutoSize = true;
            this.cusRecordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusRecordLbl.Location = new System.Drawing.Point(64, 9);
            this.cusRecordLbl.Name = "cusRecordLbl";
            this.cusRecordLbl.Size = new System.Drawing.Size(134, 20);
            this.cusRecordLbl.TabIndex = 2;
            this.cusRecordLbl.Text = "Cutomer Records";
            // 
            // addCusRecordBtn
            // 
            this.addCusRecordBtn.Location = new System.Drawing.Point(68, 32);
            this.addCusRecordBtn.Name = "addCusRecordBtn";
            this.addCusRecordBtn.Size = new System.Drawing.Size(130, 32);
            this.addCusRecordBtn.TabIndex = 4;
            this.addCusRecordBtn.Text = "Add";
            this.addCusRecordBtn.UseVisualStyleBackColor = true;
            this.addCusRecordBtn.Click += new System.EventHandler(this.addCusRecordBtn_Click);
            // 
            // deleteCusRecordBtn
            // 
            this.deleteCusRecordBtn.Location = new System.Drawing.Point(70, 108);
            this.deleteCusRecordBtn.Name = "deleteCusRecordBtn";
            this.deleteCusRecordBtn.Size = new System.Drawing.Size(130, 32);
            this.deleteCusRecordBtn.TabIndex = 5;
            this.deleteCusRecordBtn.Text = "Delete";
            this.deleteCusRecordBtn.UseVisualStyleBackColor = true;
            this.deleteCusRecordBtn.Click += new System.EventHandler(this.deleteCusRecordBtn_Click);
            // 
            // modifyCusRecordBtn
            // 
            this.modifyCusRecordBtn.Location = new System.Drawing.Point(68, 70);
            this.modifyCusRecordBtn.Name = "modifyCusRecordBtn";
            this.modifyCusRecordBtn.Size = new System.Drawing.Size(130, 32);
            this.modifyCusRecordBtn.TabIndex = 6;
            this.modifyCusRecordBtn.Text = "Modify";
            this.modifyCusRecordBtn.UseVisualStyleBackColor = true;
            this.modifyCusRecordBtn.Click += new System.EventHandler(this.modifyCusRecordBtn_Click);
            // 
            // appointmentsLbl
            // 
            this.appointmentsLbl.AutoSize = true;
            this.appointmentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsLbl.Location = new System.Drawing.Point(77, 143);
            this.appointmentsLbl.Name = "appointmentsLbl";
            this.appointmentsLbl.Size = new System.Drawing.Size(108, 20);
            this.appointmentsLbl.TabIndex = 7;
            this.appointmentsLbl.Text = "Appointments";
            // 
            // addAppointmentBtn
            // 
            this.addAppointmentBtn.Location = new System.Drawing.Point(68, 166);
            this.addAppointmentBtn.Name = "addAppointmentBtn";
            this.addAppointmentBtn.Size = new System.Drawing.Size(130, 32);
            this.addAppointmentBtn.TabIndex = 8;
            this.addAppointmentBtn.Text = "Add";
            this.addAppointmentBtn.UseVisualStyleBackColor = true;
            this.addAppointmentBtn.Click += new System.EventHandler(this.addAppointmentBtn_Click);
            // 
            // modifyAppointmentBtn
            // 
            this.modifyAppointmentBtn.Location = new System.Drawing.Point(68, 204);
            this.modifyAppointmentBtn.Name = "modifyAppointmentBtn";
            this.modifyAppointmentBtn.Size = new System.Drawing.Size(130, 32);
            this.modifyAppointmentBtn.TabIndex = 9;
            this.modifyAppointmentBtn.Text = "Modify";
            this.modifyAppointmentBtn.UseVisualStyleBackColor = true;
            this.modifyAppointmentBtn.Click += new System.EventHandler(this.modifyAppointmentBtn_Click);
            // 
            // deleteAppointmentBtn
            // 
            this.deleteAppointmentBtn.Location = new System.Drawing.Point(69, 242);
            this.deleteAppointmentBtn.Name = "deleteAppointmentBtn";
            this.deleteAppointmentBtn.Size = new System.Drawing.Size(130, 32);
            this.deleteAppointmentBtn.TabIndex = 10;
            this.deleteAppointmentBtn.Text = "Delete";
            this.deleteAppointmentBtn.UseVisualStyleBackColor = true;
            this.deleteAppointmentBtn.Click += new System.EventHandler(this.deleteAppointmentBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(812, 402);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(161, 35);
            this.LogoutBtn.TabIndex = 11;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // calendarViewLbl
            // 
            this.calendarViewLbl.AutoSize = true;
            this.calendarViewLbl.Location = new System.Drawing.Point(595, 400);
            this.calendarViewLbl.Name = "calendarViewLbl";
            this.calendarViewLbl.Size = new System.Drawing.Size(114, 13);
            this.calendarViewLbl.TabIndex = 12;
            this.calendarViewLbl.Text = "Choose Calendar View";
            // 
            // genMonthsReportBtn
            // 
            this.genMonthsReportBtn.Location = new System.Drawing.Point(68, 300);
            this.genMonthsReportBtn.Name = "genMonthsReportBtn";
            this.genMonthsReportBtn.Size = new System.Drawing.Size(130, 32);
            this.genMonthsReportBtn.TabIndex = 15;
            this.genMonthsReportBtn.Text = "Months Report";
            this.genMonthsReportBtn.UseVisualStyleBackColor = true;
            this.genMonthsReportBtn.Click += new System.EventHandler(this.genMonthsReportBtn_Click);
            // 
            // generateReportLbl
            // 
            this.generateReportLbl.AutoSize = true;
            this.generateReportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportLbl.Location = new System.Drawing.Point(66, 277);
            this.generateReportLbl.Name = "generateReportLbl";
            this.generateReportLbl.Size = new System.Drawing.Size(135, 20);
            this.generateReportLbl.TabIndex = 16;
            this.generateReportLbl.Text = "Report Generator";
            // 
            // genCusReportBtn
            // 
            this.genCusReportBtn.Location = new System.Drawing.Point(68, 338);
            this.genCusReportBtn.Name = "genCusReportBtn";
            this.genCusReportBtn.Size = new System.Drawing.Size(130, 32);
            this.genCusReportBtn.TabIndex = 17;
            this.genCusReportBtn.Text = "Customers Report";
            this.genCusReportBtn.UseVisualStyleBackColor = true;
            this.genCusReportBtn.Click += new System.EventHandler(this.genCusReportBtn_Click);
            // 
            // genConsultantReportBtn
            // 
            this.genConsultantReportBtn.Location = new System.Drawing.Point(68, 376);
            this.genConsultantReportBtn.Name = "genConsultantReportBtn";
            this.genConsultantReportBtn.Size = new System.Drawing.Size(130, 32);
            this.genConsultantReportBtn.TabIndex = 18;
            this.genConsultantReportBtn.Text = "Consultant Report";
            this.genConsultantReportBtn.UseVisualStyleBackColor = true;
            this.genConsultantReportBtn.Click += new System.EventHandler(this.genConsultantReportBtn_Click);
            // 
            // monthViewBtn
            // 
            this.monthViewBtn.Location = new System.Drawing.Point(570, 416);
            this.monthViewBtn.Name = "monthViewBtn";
            this.monthViewBtn.Size = new System.Drawing.Size(75, 23);
            this.monthViewBtn.TabIndex = 19;
            this.monthViewBtn.Text = "Month View";
            this.monthViewBtn.UseVisualStyleBackColor = true;
            this.monthViewBtn.Click += new System.EventHandler(this.monthViewBtn_Click);
            // 
            // weekViewBtn
            // 
            this.weekViewBtn.Location = new System.Drawing.Point(651, 416);
            this.weekViewBtn.Name = "weekViewBtn";
            this.weekViewBtn.Size = new System.Drawing.Size(75, 23);
            this.weekViewBtn.TabIndex = 20;
            this.weekViewBtn.Text = "Week View";
            this.weekViewBtn.UseVisualStyleBackColor = true;
            this.weekViewBtn.Click += new System.EventHandler(this.weekViewBtn_Click);
            // 
            // MainScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 450);
            this.Controls.Add(this.weekViewBtn);
            this.Controls.Add(this.monthViewBtn);
            this.Controls.Add(this.genConsultantReportBtn);
            this.Controls.Add(this.genCusReportBtn);
            this.Controls.Add(this.generateReportLbl);
            this.Controls.Add(this.genMonthsReportBtn);
            this.Controls.Add(this.calendarViewLbl);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.deleteAppointmentBtn);
            this.Controls.Add(this.modifyAppointmentBtn);
            this.Controls.Add(this.addAppointmentBtn);
            this.Controls.Add(this.appointmentsLbl);
            this.Controls.Add(this.modifyCusRecordBtn);
            this.Controls.Add(this.deleteCusRecordBtn);
            this.Controls.Add(this.addCusRecordBtn);
            this.Controls.Add(this.cusRecordLbl);
            this.Controls.Add(this.ScheduletLbl);
            this.Controls.Add(this.appointmentCalendarDGV);
            this.Name = "MainScreenForm";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.MainScreenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentCalendarDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView appointmentCalendarDGV;
        private System.Windows.Forms.Label ScheduletLbl;
        private System.Windows.Forms.Label cusRecordLbl;
        private System.Windows.Forms.Button addCusRecordBtn;
        private System.Windows.Forms.Button deleteCusRecordBtn;
        private System.Windows.Forms.Button modifyCusRecordBtn;
        private System.Windows.Forms.Label appointmentsLbl;
        private System.Windows.Forms.Button addAppointmentBtn;
        private System.Windows.Forms.Button modifyAppointmentBtn;
        private System.Windows.Forms.Button deleteAppointmentBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label calendarViewLbl;
        private System.Windows.Forms.Button genMonthsReportBtn;
        private System.Windows.Forms.Label generateReportLbl;
        private System.Windows.Forms.Button genCusReportBtn;
        private System.Windows.Forms.Button genConsultantReportBtn;
        private System.Windows.Forms.Button monthViewBtn;
        private System.Windows.Forms.Button weekViewBtn;
    }
}