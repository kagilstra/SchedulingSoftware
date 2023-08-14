using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace KyleGSchedulingSoftware
{
    public partial class loginForm : Form 
    {
        public static string username;
        public static int userID; 
        private MySqlConnection connection = new MySqlConnection();
        public static string utcTimestamp = "utc_timestamp";

        CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
        public loginForm()
        {
            InitializeComponent();
            
            if (CultureInfo.CurrentUICulture.LCID == 1041)
            {
                loginLbl.Text = "Roguin";
                pleaseEnterLbl.Text = "Yūzā-mei to pasuwādo o nyūryoku shite kudasai";
                usernameLbl.Text = "Yūzā-mei";
                passwordLbl.Text = "Pasuwādo";
                loginBtn.Text = "Roguin";
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(Connect.connectionString);
            conn.Open();

            try
            { 
                //mysql query to collect userId
                string collectUserIDQuery = "SELECT userId FROM user WHERE username = '"+usernameBox.Text+"' AND password = '"+passwordBox.Text+"'";
                //Collects userID
                MySqlCommand mySqlCommand = new MySqlCommand(collectUserIDQuery, conn);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    username = usernameBox.Text;
                    userID = reader.GetInt32("userID");
                    reader.Close();
                    string saveUserLoginTime = DateTime.Now.ToString();
                    string usersCurrentTimezone = TimeZoneInfo.Local.StandardName;
                    string filepath = "UserTimeStamp.txt";
                    File.AppendAllText(filepath, "User: " + username + " Logged in at: " + saveUserLoginTime + " " +usersCurrentTimezone + Environment.NewLine);
                }
                else
                {
                    reader.Close();
                }
                //Login in user
                String querry = "SELECT * FROM user WHERE username = '"+usernameBox.Text+"' AND password = '"+passwordBox.Text+"'";
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                //Checks if user exists
                if(dtable.Rows.Count > 0)
                { 
                    
                    Hide();
                    MainScreenForm MainScreen = new MainScreenForm();
                    MainScreen.ShowDialog();
                    Show();
                }
                else 
                { 
                    if (CultureInfo.CurrentUICulture.LCID == 1041)
                    {
                        MessageBox.Show("Fuseina roguin shikaku jōhō", "Erā", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect login credentials", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception exp)
            { 
                if (CultureInfo.CurrentUICulture.LCID == 1041)
                {
                    MessageBox.Show("Fuseina roguin shikaku jōhō", "Erā", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Incorrect login credentials", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            { 
                conn.Close();
            }
        }
    }
}
    

