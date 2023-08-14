using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KyleGSchedulingSoftware
{
    public partial class AddAppointmentForm : Form
    {
        private MySqlConnection connection = new MySqlConnection();
        public static string bussinessOpen = "08:00:00";
        public static string bussinessClose = "17:00:00";
        public static DateTime bOpen = DateTime.Parse(bussinessOpen);
        public static DateTime bClose = DateTime.Parse(bussinessClose);

        public AddAppointmentForm()
        {
            InitializeComponent();
        }

        private void addAppointmentCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void addAppointmentBtn_Click(object sender, EventArgs e)
        {
            //Strings for sql insert TimeZoneInfo.ConvertTimeToUtc(addAppointmentStartDTP.Value)
            string startTime = TimeZoneInfo.ConvertTimeToUtc(addAppointmentStartDTP.Value).ToString("yyyy-MM-dd HH:mm:ss");
            string endTime = TimeZoneInfo.ConvertTimeToUtc(addAppointmentEndDTP.Value).ToString("yyyy-MM-dd HH:mm:ss");
            string appointmentType = addAppointmentTypeBox.Text;
            string customerID = addAppointmentCusIDBox.Text;
            string notNeeded = "not needed";
            DateTime dtOpen = DateTime.Parse(addAppointmentStartDTP.Value.ToShortDateString() + " " + bussinessOpen).ToLocalTime();
            DateTime dtClose = DateTime.Parse(addAppointmentStartDTP.Value.ToShortDateString() + " " + bussinessClose).ToLocalTime();
            
            //SqlQuery string
            string appointmentAddQuery = "INSERT INTO appointment (customerId, userId, title, description, location, contact, type, url, start, end , createDate, createdBy, lastUpdate, lastUpdateBy ) VALUES ('" + customerID + "', '" + loginForm.userID + "', '"+notNeeded+ "', '" + notNeeded + "', '" + notNeeded + "', '" + notNeeded + "' ,'" + appointmentType + "', '" + notNeeded + "', '" + startTime + "', '" + endTime + "', "+ loginForm.utcTimestamp + ", '" + loginForm.username + "', " + loginForm.utcTimestamp + ", '" + loginForm.username + "')";
            //sql connection and sql command
            MySqlConnection conn = new MySqlConnection(Connect.connectionString);
            MySqlCommand mySqlCommand = new MySqlCommand(appointmentAddQuery, conn);
            //Check to make sure all textbox have data 
            if (addAppointmentCusIDBox.Text.Length > 0 && addAppointmentTypeBox.Text.Length > 0 && addAppointmentStartDTP.Text.Length > 0 && addAppointmentEndDTP.Text.Length > 0)
            {
                DateTime databaseUtcTime = new DateTime();
                //Check if appointment is between office hours
                if ((addAppointmentStartDTP.Value >= dtOpen && addAppointmentStartDTP.Value < dtClose) && (addAppointmentEndDTP.Value <= dtClose && addAppointmentEndDTP.Value > dtOpen))
                {
                    //Lambda to quickly check if there is already a appointment schedules between the choosen time blocks
                    foreach (DataGridViewRow row in (this.Owner as MainScreenForm).appointmentCalendarDGV.Rows.Cast<DataGridViewRow>().Where(row => (Convert.ToDateTime(row.Cells["start"].Value.ToString()) < addAppointmentEndDTP.Value && addAppointmentStartDTP.Value < Convert.ToDateTime(row.Cells["end"].Value.ToString()))))
                    {
                        MessageBox.Show("There is an appointment overlapping this time slot please choose another time");
                        return;
                    }
                    try
                    {
                        conn.Open();
                        mySqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Appointment Added", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        MainScreenForm mrn = this.Owner as MainScreenForm;
                        
                        mrn.GetCalendarList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong make sure all information is filled out correctly", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else 
                {
                    MessageBox.Show("Must schedule between (" + dtOpen.ToString("HH:mm") + " - " + dtClose.ToString("HH:mm") +") \nIf your appointment is between the timeslot make sure your dates are correct. \nAppointments can not span multiple days.");
                }
            }
            else
            {
                MessageBox.Show("Something went wrong make sure all information is filled out correctly", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addAppointmentStartDTP_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            if (addAppointmentStartDTP.Value < today)
            {
                MessageBox.Show("Date can not be in the past");
                addAppointmentStartDTP.Value = DateTime.Now.Date;
            }
        }

        private void addAppointmentEndDTP_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            if (addAppointmentStartDTP.Value < today)
            {
                MessageBox.Show("Date can not be in the past");
                addAppointmentStartDTP.Value = DateTime.Now.Date;
            }
        }
    }
}
