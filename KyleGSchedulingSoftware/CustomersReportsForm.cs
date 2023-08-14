using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyleGSchedulingSoftware
{
    public partial class CustomersReportsForm : Form
    {
        public CustomersReportsForm()
        {
            InitializeComponent();
        }

        
        private void reportCloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CustomersReportsForm_Load(object sender, EventArgs e)
        {
            cusReportDataGridView.DataSource = GetCustomersList();
        }

        private DataTable GetCustomersList()
        {
            DataTable dtCustomers = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT customerId, customerName FROM customer", conn)) 
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtCustomers.Load(reader);
                }
            }

                return dtCustomers;
        }
    }
}
