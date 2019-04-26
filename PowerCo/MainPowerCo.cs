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
    public partial class MainPowerCo : Form
    {
        public static void ReadOnlyAlert()
        {
            MessageBox.Show("This input box cannot be written to.", "Read Only");
        }
        public MainPowerCo()
        {
            InitializeComponent();
        }

        private void MainPowerCo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BillGeneration_Click(object sender, EventArgs e)
        {
    
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool security = true;
            int timeout = 30;
            //int isAdmin = 0;
            string filename = "powerco_db.mdf";
            string directory = @"C:\Users\tevon\Desktop\PowerCo\PowerCo\" + filename;
            //string workdirectory = @"C:\Users\JMDA\Desktop\powerco\PowerCo\" + filename;
            //string username = customerNameField.Text.Trim();
            //string password = customerPasswordField.Text.Trim();
            //string query_user = sqlSelectFromWhere("*", "users", "username = '" + username + "' and password = '" + password + "'" + " and is_admin = " + isAdmin + " ");

            //Initialize Connection
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + directory + ";Integrated Security=" + security + ";Connect Timeout=" + timeout);
            try
            {
                //check if connection to database is closed
                if (connection.State == ConnectionState.Closed)
                {
                    //upper and lower limits of random generated numbers
                    int lower = 1, upper = 15000;
                    //Create meter readings for stored procedure
                    Random rand = new Random();
                    int current_reading = rand.Next(lower, upper);
                    int previous_reading = rand.Next(lower, upper);
                    int current_usage = rand.Next(lower, upper);
                    int fa_rating = rand.Next(lower, upper);

                    //if database connection is closed open the connection
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mode", "Add");
                    command.Parameters.AddWithValue("@Id", 0);
                    //Personal Details
                    command.Parameters.AddWithValue("@premises_number", premisesNumberField.Text.Trim());
                    command.Parameters.AddWithValue("@account_number", accountNumberField.Text.Trim());
                    command.Parameters.AddWithValue("@account_name", accountHoldersNameField.Text.Trim());
                    command.Parameters.AddWithValue("@account_address", accountHoldersAddressField.Text.Trim());
                    //Rand
                    command.Parameters.AddWithValue("@current_reading", current_reading);
                    command.Parameters.AddWithValue("@previous_reading", previous_reading);
                    command.Parameters.AddWithValue("@current_usage", current_usage);
                    command.Parameters.AddWithValue("@fa_rate", fa_rating);
                    //Financials
                    command.Parameters.AddWithValue("@previous_balance", previousBalanceField.Text.Trim());
                    command.Parameters.AddWithValue("@payments", paymentsField.Text.Trim());
                    command.Parameters.AddWithValue("@payment_date", paymentsDateField.Text.Trim());
                    command.Parameters.AddWithValue("@brought_forward", broughtForwardField.Text.Trim());
                    //command.Parameters.AddWithValue("@fa_rate", "Add");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
                throw;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            ReadOnlyAlert();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            ReadOnlyAlert();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            ReadOnlyAlert();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
