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
    public partial class MainScreenForm : Form
    {
        public MainScreenForm()
        {
            InitializeComponent();    
            var dt = DateTime.UtcNow;

            TimeZoneInfo tzi = TimeZoneInfo.Local;
            var utcOffset = new DateTimeOffset(dt, TimeSpan.Zero);
           
            DateTimeOffset offset = (utcOffset.ToOffset(tzi.GetUtcOffset(utcOffset)));
            timeholder = offset.ToString().Substring(offset.ToString().Length - 6 , 6);
        }
        public static string timeholder = "";
        Timer appointmentchecker = new Timer();

        private void addCusRecordBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AddCustomerRecordForm addCustomerRecordForm = new AddCustomerRecordForm();
            addCustomerRecordForm.ShowDialog();
            Show();
        }

        private void modifyCusRecordBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ModifyCustomerRecordForm modifyCustomerRecordForm = new ModifyCustomerRecordForm();
            modifyCustomerRecordForm.ShowDialog();
            Show();
        }

        private void deleteCusRecordBtn_Click(object sender, EventArgs e)
        {
            Hide();
            DeleteCustomerRecordForm deleteCustomerRecordForm = new DeleteCustomerRecordForm();
            deleteCustomerRecordForm.ShowDialog();
            Show();
        }

        private void addAppointmentBtn_Click(object sender, EventArgs e)
        {
            Hide();
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm();
            
            addAppointmentForm.Owner = this;
            addAppointmentForm.ShowDialog();
            Show();
        }

        private void modifyAppointmentBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ModifyAppointmentForm modifyAppointmentForm = new ModifyAppointmentForm();

            modifyAppointmentForm.Owner = this;
            modifyAppointmentForm.ShowDialog();
            Show();
        }

        private void deleteAppointmentBtn_Click(object sender, EventArgs e)
        {
            Hide();
            DeleteAppointmentForm deleteAppointmentForm = new DeleteAppointmentForm();
            deleteAppointmentForm.ShowDialog();
            Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void genMonthsReportBtn_Click(object sender, EventArgs e)
        {
            Hide();
            monthReportForm reportsForm = new monthReportForm();
            reportsForm.ShowDialog();
            Show();
        }

        private void genCusReportBtn_Click(object sender, EventArgs e)
        {
            Hide();
            CustomersReportsForm reportsForm = new CustomersReportsForm();
            reportsForm.ShowDialog();
            Show();
        }

        private void genConsultantReportBtn_Click(object sender, EventArgs e)
        {
            Hide();
            ConsultantReportForm reportsForm = new ConsultantReportForm();
            reportsForm.ShowDialog();
            Show();
        }

        private void MainScreenForm_Load(object sender, EventArgs e)
        {
            GetCalendarList();
            appointmentchecker.Interval = 1000;
            appointmentchecker.Enabled = true;
            appointmentchecker.Tick += myTimer_Tick;

        }
        private void myTimer_Tick(object sender, EventArgs e)
        {
            string checkForAppoinment = "SELECT * FROM appointment WHERE start BETWEEN utc_timestamp() AND date_add(utc_timestamp(), interval 16 minute) ";
            MySqlConnection conn = new MySqlConnection(Connect.connectionString);
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(checkForAppoinment, conn);
            object obj1 = mySqlCommand.ExecuteScalar();
            //If the country doesn't exists adds a new country to the database
            if (Convert.ToInt32(obj1) == 0)
            {
                return;
            }
            else 
            {
                appointmentchecker.Enabled = false;
                MessageBox.Show("You have an appointment within 15 minutes");
            }
            

        }
        
        
        
        public void GetCalendarList()
        {
            DataTable dtCalendar = new DataTable();
            


            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString))
            {
                
                
                using (MySqlCommand cmd = new MySqlCommand("SELECT appointmentId, customerId, type, date_format(convert_tz(start,'+00:00', '"+timeholder+"'), '%Y' '-' '%m' '-'  '%d' ' ' '%k' ':' '%i') AS start, date_format(convert_tz(end, '+00:00', '"+timeholder+"'), '%Y' '-' '%m' '-'  '%d' ' ' '%k' ':' '%i') AS end, date_format(start, '%M') AS Month FROM appointment ORDER BY date_format(start,'%M') DESC;", conn))
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtCalendar.Load(reader);
                }
            }
            appointmentCalendarDGV.DataSource = dtCalendar;
           

        }


        private void monthViewBtn_Click(object sender, EventArgs e)
        {
            DataTable dtCalendar = new DataTable();


            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT customerId, type, start, end, date_format(start, '%M') AS Month FROM appointment ORDER BY date_format(start, '%M') DESC; ", conn))
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtCalendar.Load(reader);
                }
            }

            appointmentCalendarDGV.DataSource = dtCalendar;
        }

        private void weekViewBtn_Click(object sender, EventArgs e)
        {
            DataTable dtCalendar = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT customerId, type, start, end, date_format(start, 'week ' '%v' ' of ' '%X') AS Week FROM appointment ORDER BY date_format(start,'%v' '%X') ASC;", conn))
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtCalendar.Load(reader);
                }
            }

            appointmentCalendarDGV.DataSource = dtCalendar;
        }

    }
}
