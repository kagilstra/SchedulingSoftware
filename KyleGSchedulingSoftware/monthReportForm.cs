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
    public partial class monthReportForm : Form
    {
        public monthReportForm()
        {
            InitializeComponent();
        }

        private void reportCloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void monthReportForm_Load(object sender, EventArgs e)
        {
            monthDataGridView.DataSource = GetMonthsList();
        }

        private DataTable GetMonthsList()
        {
            DataTable dtConsultants = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(Connect.connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) as Amount, type, date_format(start, '%M') AS Month FROM appointment GROUP BY date_format(start, '%M'), type ORDER BY date_format(start, '%M') DESC;", conn))
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
