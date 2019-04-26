using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace PowerCo
{

    public partial class PowerCo : Form
    {
      
        public PowerCo()
        {
            InitializeComponent();
        }

        //Query helper method
        private static string sqlSelectFromWhere(string select,string from, string where) {
            string query = "Select"+select+" from "+from+" Where "+where;
            return query;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PowerCo_Load(object sender, EventArgs e)
        {

        }

        private void PowerCo_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void customerNameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerLoginButton_Click(object sender, EventArgs e)
        {
            //LOGIN BUTTON 

            //Config values
            bool security = true;
            int timeout = 30;
            int isAdmin = 0;
            string filename = "powerco_db.mdf";
            string directory = @"C:\Users\tevon\Desktop\PowerCo\PowerCo\" + filename;
            string workdirectory = @"C:\Users\JMDA\Desktop\powerco\PowerCo\" + filename;
            string username = customerNameField.Text.Trim();
            string password = customerPasswordField.Text.Trim();
            string query_user = sqlSelectFromWhere("*", "users", "username = '" + username + "' and password = '" + password + "'"+" and is_admin = "+isAdmin+" ");

            //Initialize Connection
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + directory + ";Integrated Security=" + security + ";Connect Timeout=" + timeout);
            try
            {
                //Query user info for authentication
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query_user, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                //Load Dashboard / Mainview once authenticated from db
                if (dataTable.Rows.Count == 1)
                {
                    MainPowerCo dashboard = new MainPowerCo();
                    this.Hide(); // Refrence current login form and hide it 
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Username or Password Incorrect"+"\n"
                        + "or " + username + " is not a customer. \n"
                        , "Login Error"
                    );
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "Error thrown :" + error.Message + "\n"
                   + "username :" + username + "\n"
                   + "password :" + password + "\n"
                   + "query string :" + query_user + "\n"
                );
                throw;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //LOGIN BUTTON 

            //Config values
            bool security = true;
            int timeout = 30;
            int isAdmin = 1;
            string filename = "powerco_db.mdf";
            string directory = @"C:\Users\tevon\Desktop\PowerCo\PowerCo\" + filename;
            string workdirectory = @"C:\Users\JMDA\Desktop\powerco\PowerCo\" + filename;
            string username = NameField.Text.Trim();
            string password = PasswordField.Text.Trim();
            string query_user = sqlSelectFromWhere("*", "users", "username = '" + username + "' and password = '" + password + "'" + " and is_admin = " + isAdmin + " ");

            if (username == "" || password == "")
            {
                MessageBox.Show("You have an empty field");
            }

            //Initialize Connection
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + workdirectory + ";Integrated Security=" + security + ";Connect Timeout=" + timeout);
            try
            {
                //Query user info for authentication
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query_user, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                //Load Dashboard / Mainview once authenticated from db
                if (dataTable.Rows.Count == 1)
                {
                    MainPowerCo dashboard = new MainPowerCo();
                    this.Hide(); // Refrence current login form and hide it 
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Username or Password Incorrect" + "\n"
                        + "or " + username + " is not a admin. \n"
                        , "Login Error"
                    );
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(
                    "Error thrown :" + error.Message + "\n"
                   + "username :" + username + "\n"
                   + "password :" + password + "\n"
                   + "query string :" + query_user + "\n"
                );
                throw;
            }
        }
    }
}
