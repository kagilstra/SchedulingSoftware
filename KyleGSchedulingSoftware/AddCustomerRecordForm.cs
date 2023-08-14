using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KyleGSchedulingSoftware
{
    public partial class AddCustomerRecordForm : Form
    {
        public AddCustomerRecordForm()
        {
            InitializeComponent();
        }

        private void addCusRecordCancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static int addressId;
        public static int countryId;
        public static int cityId;

        private void addCusRecordCreateBtn_Click(object sender, EventArgs e)
        {
            MySqlTransaction trans;
            MySqlConnection conn = new MySqlConnection(Connect.connectionString);
            conn.Open();

            if (addCusNameBox.Text.Length > 0 && addCusPhoneBox.MaskFull && addCusAddressBox.Text.Length > 0 && addCusPostalBox.Text.Length > 0 && addCusCityBox.Text.Length > 0 && addCusCountryBox.Text.Length > 0)
            {
                try
                {
                    //Checks to see if country of new user already exists in database
                    MySqlCommand newCityCountry = new MySqlCommand("SELECT EXISTS(SELECT * FROM country WHERE country = '" + addCusCountryBox.Text + "') result", conn);
                    object obj1 = newCityCountry.ExecuteScalar();
                    //If the country doesn't exists adds a new country to the database
                    if (Convert.ToInt32(obj1) == 0)
                    {
                        MySqlCommand addCountry = new MySqlCommand("INSERT INTO country (country, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + addCusCountryBox.Text + "', " + loginForm.utcTimestamp + ", '" + loginForm.username + "', " + loginForm.utcTimestamp + ", '" + loginForm.username + "')", conn);
                        addCountry.ExecuteNonQuery();
                    }
                    //Collects and saves countryId to use for city table
                    MySqlCommand countryIDQuery = new MySqlCommand("Select countryId FROM country WHERE country = '" + addCusCountryBox.Text + "'", conn);
                    MySqlDataReader reader = countryIDQuery.ExecuteReader();
                    if (reader.Read())
                    {
                        countryId = reader.GetInt32("countryId");
                        reader.Close();
                    }
                    //Uses user inserted city name to check the city table for a row with the same countryId
                    MySqlCommand cityCountryComboCheck = new MySqlCommand("SELECT EXISTS(SELECT * FROM city WHERE city = '" + addCusCityBox.Text + "' AND countryId = " + countryId + ")", conn);
                    object obj2 = cityCountryComboCheck.ExecuteScalar();
                    //If the city doesn't exist or the city with the same name exists but is not in the same country adds new city country combination
                    if (Convert.ToInt32(obj2) == 0)
                    {
                        MySqlCommand addCityCountryCombo = new MySqlCommand("INSERT INTO city (city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + addCusCityBox.Text + "', '" + countryId + "', " + loginForm.utcTimestamp + ", '" + loginForm.username + "', " + loginForm.utcTimestamp + ", '" + loginForm.username + "')", conn);
                        addCityCountryCombo.ExecuteNonQuery();
                    }
                    //Collects the cityId to use in address table
                    MySqlCommand cityIdCollector = new MySqlCommand("Select cityId FROM city WHERE city = '" + addCusCityBox.Text + "' AND countryId = '" + countryId + "'", conn);
                    MySqlDataReader reader2 = cityIdCollector.ExecuteReader();
                    if (reader2.Read())
                    {
                        cityId = reader2.GetInt32("cityId");
                        reader2.Close();
                    }
                    //Create new address using user inserted data
                    MySqlCommand addAddressTable = new MySqlCommand("INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + addCusAddressBox.Text + "', '" + string.Empty + "', '" + cityId + "', '" + addCusPostalBox.Text + "', '" + addCusPhoneBox.Text + "', " + loginForm.utcTimestamp + ", '" + loginForm.username + "', " + loginForm.utcTimestamp + ", '" + loginForm.username + "')", conn);
                    addAddressTable.ExecuteNonQuery();
                    //Collect addressId to insert in customer table
                    MySqlCommand addressIdCollector = new MySqlCommand("Select addressId FROM address WHERE address = '" + addCusAddressBox.Text + "' AND postalCode = '" + addCusPostalBox.Text + "' AND phone = '"+addCusPhoneBox.Text+"'", conn);
                    MySqlDataReader reader3 = addressIdCollector.ExecuteReader();
                    if (reader3.Read())
                    {
                        addressId = reader3.GetInt32("addressId");
                        reader3.Close();
                    }
                    //adds a new customer to table
                    MySqlCommand addCusTable = new MySqlCommand("INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES ('" + addCusNameBox.Text + "', '" + addressId + "', '" + 1 + "', " + loginForm.utcTimestamp + ", '" + loginForm.username + "', " + loginForm.utcTimestamp + ", '" + loginForm.username + "')", conn);
                    addCusTable.ExecuteNonQuery();
                    MessageBox.Show("You have successfully created a new customer", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Something went wrong make sure all information is filled out correctly", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Make sure all data is filed out correctly. Phone Must include all 10 digits.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addCusNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
                    e.Handled = true;
        }

        private void addCusCityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                    e.Handled = true;
            
        }

        private void addCusCountryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void addCusPhoneBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            e.Handled = false;
            return;
        }

    }
}
    

