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
    public partial class ConsultantReportForm : Form
    {
        public ConsultantReportForm()
        {
            InitializeComponent();
        }

        private void reportCloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConsultantReportForm_Load(object sender, EventArgs e)
        {
            consultantDataGridView.DataSource = GetConsultantsList();
        }
        private DataTable GetConsultantsList()
        {
            DataTable dtConsultants = new DataTable();


            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT appointment.appointmentId, customer.customerName, appointment.createdBy AS consultantName, type, date_format(convert_tz(start,'+00:00', '"+MainScreenForm.timeholder+"'), '%Y' '-' '%m' '-'  '%d' ' ' '%k' ':' '%i') AS start,  date_format(convert_tz(end, '+00:00', '"+MainScreenForm.timeholder+"'), '%Y' '-' '%m' '-'  '%d' ' ' '%k' ':' '%i') AS end FROM customer INNER JOIN appointment ON customer.customerId = appointment.customerId WHERE userId = '"+loginForm.userID+"'", conn))
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtConsultants.Load(reader);
                }
            }

            return dtConsultants;
        }
    }
}
