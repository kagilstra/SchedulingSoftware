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
    public partial class ModifyCustomerRecordForm : Form
    {
        public ModifyCustomerRecordForm()
        {
            InitializeComponent();



        }
        public static int addressId;
        public static int countryId;
        public static int cityId;

        private void modifyCusRecordCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifyCusRecordUpdateBtn_Click(object sender, EventArgs e)
        {
            MySqlTransaction trans;
            //Connect statement
            MySqlConnection conn = new MySqlConnection(Connect.connectionString);
            //Check if Country Exists
            conn.Open();
            trans = conn.BeginTransaction();
            if (modifyCusIDBox.Text.Length > 0 && modifyCusNameBox.Text.Length > 0 && modifyCusPhoneBox.MaskFull && modifyCusAddressBox.Text.Length > 0 && modifyCusPostalBox.Text.Length > 0 && modifyCusCityBox.Text.Length > 0 && modifyCusCountryBox.Text.Length > 0)
            {
                try
                {
                    MySqlCommand newCityCountry = new MySqlCommand("SELECT EXISTS(SELECT * FROM country WHERE country = '" + modifyCusCountryBox.Text + "') result", conn);
                    object obj1 = newCityCountry.ExecuteScalar();
                    //If country doesn't exists add it
                    if (Convert.ToInt32(obj1) == 0)
                    {
                        MySqlCommand addCountry = new MySqlCommand("INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + modifyCusCountryBox.Text + "', " + loginForm.utcTimestamp + ", '" + loginForm.username + "', " + loginForm.utcTimestamp + ", '" + loginForm.username + "')", conn);
                        addCountry.ExecuteNonQuery();

                    }
                    //Run query to get country ID
                    MySqlCommand countryIDQuery = new MySqlCommand("Select countryId FROM country WHERE country = '" + modifyCusCountryBox.Text + "'", conn);
                    MySqlDataReader reader = countryIDQuery.ExecuteReader();
                    if (reader.Read())
                    {
                        countryId = reader.GetInt32("countryId");
                        reader.Close();
                    }

                    //Run command to see if city country combo exists
                    MySqlCommand cityCountryComboCheck = new MySqlCommand("SELECT EXISTS(SELECT * FROM city WHERE city = '" + modifyCusCityBox.Text + "' AND countryId = " + countryId + ")", conn);
                    object obj2 = cityCountryComboCheck.ExecuteScalar();
                    //If city countryId combo doesnt exist add it
                    if (Convert.ToInt32(obj2) == 0)
                    {
                        MySqlCommand addCityCountryCombo = new MySqlCommand("INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + modifyCusCityBox.Text + "', '" + countryId + "', " + loginForm.utcTimestamp + ", '" + loginForm.username + "', " + loginForm.utcTimestamp + ", '" + loginForm.username + "')", conn);
                        addCityCountryCombo.ExecuteNonQuery();
                    }

                    //get cityId that was added/updated
                    MySqlCommand cityIdCollector = new MySqlCommand("Select cityId FROM city WHERE city = '" + modifyCusCityBox.Text + "' AND countryId = '" + countryId + "'", conn);
                    MySqlDataReader reader2 = cityIdCollector.ExecuteReader();
                    if (reader2.Read())
                    {
                        cityId = reader2.GetInt32("cityId");
                        reader2.Close();
                    }
                    //update address table
                    MySqlCommand updateAddressTable = new MySqlCommand("UPDATE address SET address = '" + modifyCusAddressBox.Text + "', address2 = '" + string.Empty + "', cityId = '" + cityId + "', postalCode = '" + modifyCusPostalBox.Text + "', phone = '" + modifyCusPhoneBox.Text + "', createDate = " + loginForm.utcTimestamp + ", createdBy = '" + loginForm.username + "', lastUpdate = " + loginForm.utcTimestamp + ", lastUpdateBy = '" + loginForm.username + "' WHERE addressId = '" + addressId + "'", conn);
                    MySqlDataReader updateAddressReader;
                    updateAddressReader = updateAddressTable.ExecuteReader();
                    updateAddressReader.Close();

                    //update customer table
                    MySqlCommand updateCusTable = new MySqlCommand("UPDATE customer SET customerName = '" + modifyCusNameBox.Text + "', addressId = '" + addressId + "', active = '" + 1 + "', createDate = " + loginForm.utcTimestamp + ", createdBy = '" + loginForm.username + "', lastUpdate = " + loginForm.utcTimestamp + ", lastUpdateBy = '" + loginForm.username + "' WHERE customerId = '" + modifyCusIDBox.Text + "'", conn);
                    MySqlDataReader updateCustomer;
                    updateCustomer = updateCusTable.ExecuteReader();
                    MessageBox.Show("Update Succesful", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateCustomer.Close();
                }
                catch (Exception)
                {
                    trans.Rollback();
                    MessageBox.Show("ERROR MAKE SURE ALL INFORMATION IS FILLED OUT CORRECTLY", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                trans.Commit();
                conn.Close();
                Close();
            }
            else
            {
                MessageBox.Show("Make sure all data is filed out correctly. Phone Must include all 10 digits.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void modifyCusSearchID_Click(object sender, EventArgs e)
        {
            string customerSearchQuery = @"SELECT customer.customerName name, phone, address, postalCode, city, country
FROM customer INNER JOIN address ON customer.addressId = address.addressId INNER JOIN city ON city.cityId = address.cityId INNER JOIN country ON country.countryId = city.countryId WHERE customerId ='" + modifyCusIDBox.Text + "'";

            MySqlConnection conn = new MySqlConnection(Connect.connectionString);
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(customerSearchQuery, conn);
            MySqlCommand getaddressId = new MySqlCommand("SELECT addressId FROM customer WHERE customerId = '" + modifyCusIDBox.Text + "'", conn);

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            if (modifyCusIDBox.Text.Length > 0)
            {
                if (reader.Read())
                {
                    modifyCusNameBox.Text = reader.GetString("name");
                    modifyCusPhoneBox.Text = reader.GetString("phone");
                    modifyCusAddressBox.Text = reader.GetString("address");
                    modifyCusPostalBox.Text = reader.GetString("postalCode");
                    modifyCusCityBox.Text = reader.GetString("city");
                    modifyCusCountryBox.Text = reader.GetString("country");
                    reader.Close();
                    MySqlDataReader reader3 = getaddressId.ExecuteReader();
                    if (reader3.Read())
                    {
                        addressId = reader3.GetInt32("addressId");
                        reader3.Close();
                    }
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

        private void modifyCusNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void modifyCusCityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void modifyCusCountryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void modifyCusPhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsLetter(e.KeyChar) && e.KeyChar != '-' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
            return;
        }
    }
}

