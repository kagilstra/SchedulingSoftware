using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyleGSchedulingSoftware
{
    public partial class ModifyAppointmentForm : Form
    {
        public ModifyAppointmentForm()
        {
            InitializeComponent();
        }

        private void updateAppointmentCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateAppointmentBtn_Click(object sender, EventArgs e)
        {
            //Strings for mysql update
            string startTime = updateAppointmentStartDTP.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            string endTime = updateAppointmentEndDTP.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            string appointmentType = updateAppointmentTypeBox.Text;
            string customerID = updateAppointmentCusIDBox.Text;
            string notNeeded = "not needed";
            DateTime dtOpen = DateTime.Parse(updateAppointmentStartDTP.Value.ToShortDateString() + " " + AddAppointmentForm.bussinessOpen).ToLocalTime();
            DateTime dtClose = DateTime.Parse(updateAppointmentStartDTP.Value.ToShortDateString() + " " + AddAppointmentForm.bussinessClose).ToLocalTime();
            
            //mySqlQuery update string
            string appointmentUpdateQuery = "UPDATE client_schedule.appointment SET customerId = '"+updateAppointmentCusIDBox.Text+"', type = '"+appointmentType+"', start = '"+startTime+"',  end = '"+endTime+"', lastUpdate = "+ loginForm.utcTimestamp + " WHERE appointmentId = '"+updateAppointmentIDBox.Text+"'";
            //mysql connection and sql command
            MySqlConnection conn = new MySqlConnection(Connect.connectionString);
            MySqlCommand mySqlCommand = new MySqlCommand(appointmentUpdateQuery, conn);
            //Check to make sure all textbox have data 
            if (updateAppointmentCusIDBox.Text.Length > 0 &&updateAppointmentTypeBox.Text.Length > 0 && updateAppointmentStartDTP.Text.Length > 0 && updateAppointmentEndDTP.Text.Length > 0)
            {
                //Check if updated appointment is between office hours
                if ((updateAppointmentStartDTP.Value >= dtOpen && updateAppointmentStartDTP.Value < dtClose) && (updateAppointmentEndDTP.Value <= dtClose && updateAppointmentEndDTP.Value > dtOpen))
                {
                    //Lambda to check if updated appointment has conflict with already scheduled appointment
                    foreach (DataGridViewRow row in (this.Owner as MainScreenForm).appointmentCalendarDGV.Rows.Cast<DataGridViewRow>().Where(row => (Convert.ToDateTime(row.Cells["start"].Value.ToString()) < updateAppointmentEndDTP.Value && updateAppointmentStartDTP.Value < Convert.ToDateTime(row.Cells["end"].Value.ToString()) && row.Cells["appointmentId"].Value.ToString() != updateAppointmentIDBox.Text)))
                    {
                        MessageBox.Show("There is an appointment overlapping this time slot please choose another time");
                        return;
                    }
                    try
                    {
                        conn.Open();
                        mySqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Appointment updated", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void updateAppointmentSearchBtn_Click(object sender, EventArgs e)
        {
            string appointmentSearchQuery = "SELECT customerId, type, date_format(convert_tz(start,'+00:00', '"+MainScreenForm.timeholder+"'), '%Y' '-' '%m' '-'  '%d' ' ' '%k' ':' '%i') AS start, date_format(convert_tz(end, '+00:00', '"+MainScreenForm.timeholder+"'), '%Y' '-' '%m' '-'  '%d' ' ' '%k' ':' '%i') AS end  FROM appointment WHERE appointmentId= '" + updateAppointmentIDBox.Text + "'";
            MySqlConnection conn = new MySqlConnection(Connect.connectionString);
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(appointmentSearchQuery, conn);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (reader.Read())
            {
                updateAppointmentCusIDBox.Text = reader.GetString("customerId");
                updateAppointmentTypeBox.Text = reader.GetString("type");
                updateAppointmentStartDTP.Text = reader.GetString("start");
                updateAppointmentEndDTP.Text = reader.GetString("end");
                conn.Close();
            }
            else
            {
                MessageBox.Show("Appointment ID not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateAppointmentStartDTP_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            if (updateAppointmentStartDTP.Value < today)
            {
                MessageBox.Show("Date can not be in the past");
                updateAppointmentStartDTP.Value = DateTime.Now.Date;
            }
        }

        private void updateAppointmentEndDTP_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now.Date;
            if (updateAppointmentStartDTP.Value < today)
            {
                MessageBox.Show("Date can not be in the past");
                updateAppointmentStartDTP.Value = DateTime.Now.Date;
            }
        }
    }
}
