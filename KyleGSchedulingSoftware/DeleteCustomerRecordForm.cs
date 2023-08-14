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
    public partial class DeleteCustomerRecordForm : Form
    {
        public DeleteCustomerRecordForm()
        {
            InitializeComponent();
        }

        public static int addressID;
        
        private void deleteCusRecordCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteCusRecordUpdateBtn_Click(object sender, EventArgs e)
        {
            string setKey = @"SET FOREIGN_KEY_CHECKS = 0;"; 
            string deleteCus = "DELETE FROM customer WHERE customerId = '" + deleteCusIDBox.Text+ "'";
            string deleteAddress = " DELETE FROM address WHERE addressId = '" + addressID + "';";
            string setKeyBack = "SET FOREIGN_KEY_CHECKS = 1; ";
            MySqlConnection conn = new MySqlConnection(Connect.connectionString);
            MySqlCommand mySqlCommand1 = new MySqlCommand(setKey, conn);
            MySqlCommand mySqlCommand2 = new MySqlCommand(deleteCus, conn);
            MySqlCommand mySqlCommand3 = new MySqlCommand(deleteAddress, conn);
            MySqlCommand mySqlCommand4 = new MySqlCommand(setKeyBack, conn);
            MySqlDataReader myReader;
            try
            {
                conn.Open();
                mySqlCommand1.ExecuteNonQuery();
                mySqlCommand3.ExecuteNonQuery();
                mySqlCommand2.ExecuteNonQuery();
                mySqlCommand4.ExecuteNonQuery();
                MessageBox.Show("Customer DELETED", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an Error deleting Customer please check customer ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteCusSearchID_Click(object sender, EventArgs e)
        {
            //Search Queries
            string customerSearchQuery = @"SELECT customer.customerName name, phone, address, postalCode, city, country
FROM customer INNER JOIN address ON customer.addressId = address.addressId INNER JOIN city ON city.cityId = address.cityId INNER JOIN country ON country.countryId = city.countryId WHERE customerId ='" + deleteCusIDBox.Text + "'";
            
            MySqlConnection conn = new MySqlConnection(Connect.connectionString);
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(customerSearchQuery, conn);
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (deleteCusIDBox.Text.Length > 0)
            {
                if (reader.Read())
                {
                    deleteCusNameBox.Text = reader.GetString("name");
                    deleteCusPhoneBox.Text = reader.GetString("phone");
                    deleteCusAddressBox.Text = reader.GetString("address");
                    deleteCusPostalBox.Text = reader.GetString("postalCode");
                    deleteCusCityBox.Text = reader.GetString("city");
                    deleteCusCountryBox.Text = reader.GetString("country");
                    reader.Close();
                    //Collect user addressID for delete
                    MySqlCommand addressIdCollector = new MySqlCommand("Select addressId FROM address WHERE address = '" + deleteCusAddressBox.Text + "' AND postalCode = '" + deleteCusPostalBox.Text + "' AND phone = '" + deleteCusPhoneBox.Text + "'", conn);
                    MySqlDataReader reader3 = addressIdCollector.ExecuteReader();
                    if (reader3.Read())
                    {
                        addressID = reader3.GetInt32("addressId");
                        reader3.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Custoemr ID not Found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERROR. Please enter Customer ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
