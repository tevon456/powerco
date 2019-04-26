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
        public bool security = true;
        public string directory = @"C:\Users\tevon\Desktop\PowerCo\PowerCo\powerco_db.mdf";
        public string workdirectory = @"C:\Users\JMDA\Desktop\powerco\PowerCo\powerco_db.mdf";
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JMDA\Desktop\powerco\PowerCo\powerco_db.mdf;Integrated Security=true;Connect Timeout=30");
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


            //Initialize Connection

            int lower = 1, upper = 15000;
            //Create meter readings for stored procedure
            Random rand = new Random();
            int current_reading = rand.Next(lower, upper);
            int previous_reading = rand.Next(lower, upper);
            int current_usage = rand.Next(lower, upper);
            int fa_rating = rand.Next(lower, upper);
            try
            {
                //check if connection to database is closed


                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlCommand command = new SqlCommand("CustomerAddOrEdit", connection);
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
                command.Parameters.AddWithValue("@payment_date", paymentsDateField.Value);
                command.Parameters.AddWithValue("@brought_forward", broughtForwardField.Text.Trim());
                command.ExecuteNonQuery();
                MessageBox.Show("Saved");

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        void FillDataGrid()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("CustomerViewOrSearch",connection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.AddWithValue("@Search_name",searchBox.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGrid.DataSource = dataTable;
            connection.Close();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                FillDataGrid();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message+"\n"+error.StackTrace,"Search Error");
                throw;
            }
        }
    }
}
