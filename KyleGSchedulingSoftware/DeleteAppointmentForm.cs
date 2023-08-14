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
    public partial class DeleteAppointmentForm : Form
    {

        
        public DeleteAppointmentForm()
        {
            InitializeComponent();
        }

        private void deleteAppointmentCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteAppointmentSearchBtn_Click(object sender, EventArgs e)
        {
            string appointmentSearchQuery = "SELECT * FROM appointment WHERE appointmentId='" + deleteAppointmentIDBox.Text + "'";
            MySqlConnection conn = new MySqlConnection(Connect.connectionString);
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(appointmentSearchQuery, conn);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (deleteAppointmentIDBox.Text.Length > 0)
            {
                if (reader.Read())
                {
                    deleteAppointmentCusIDBox.Text = reader.GetString("customerId");
                    deleteAppointmentTypeBox.Text = reader.GetString("type");
                    deleteAppointmentStartDTP.Text = reader.GetString("start");
                    deleteAppointmentEndDTP.Text = reader.GetString("end");
                }
                else
                {
                    MessageBox.Show("Customer ID not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("ERROR. Please enter Customer ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteAppointmentBtn_Click(object sender, EventArgs e)
        {
            
            string deleteQuery = "DELETE FROM appointment WHERE appointmentId = " + deleteAppointmentIDBox.Text ;
            MySqlConnection conn = new MySqlConnection(Connect.connectionString);
            MySqlCommand mySqlCommand = new MySqlCommand(deleteQuery, conn);
            MySqlDataReader myReader;
            try
            {
                conn.Open();
                myReader = mySqlCommand.ExecuteReader();
                MessageBox.Show("Appointment DELETED", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an Error deleting this Appointment please check Appointment ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
