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
        int Id = 0;
        public MainPowerCo()
        {
            InitializeComponent();
        }

        private void MainPowerCo_Load(object sender, EventArgs e)
        {
            Reset();
            FillDataGrid();
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
                if(saveButton.Text == "Save")
                {
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
                else
                {
                    SqlCommand command = new SqlCommand("CustomerAddOrEdit", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mode", "Edit");
                    command.Parameters.AddWithValue("@Id", Id);
                    //Personal Details
                    command.Parameters.AddWithValue("@premises_number", premisesNumberField.Text.Trim());
                    command.Parameters.AddWithValue("@account_number", accountNumberField.Text.Trim());
                    command.Parameters.AddWithValue("@account_name", accountHoldersNameField.Text.Trim());
                    command.Parameters.AddWithValue("@account_address", accountHoldersAddressField.Text.Trim());
                    //Rand
                    command.Parameters.AddWithValue("@current_reading", currentReadingField.Text.Trim());
                    command.Parameters.AddWithValue("@previous_reading", previousReadingField.Text.Trim());
                    command.Parameters.AddWithValue("@current_usage", currentUsageField.Text.Trim());
                    command.Parameters.AddWithValue("@fa_rate", fuelAdjustmentRateField.Text.Trim());
                    //Financials
                    command.Parameters.AddWithValue("@previous_balance", previousBalanceField.Text.Trim());
                    command.Parameters.AddWithValue("@payments", paymentsField.Text.Trim());
                    command.Parameters.AddWithValue("@payment_date", paymentsDateField.Value);
                    command.Parameters.AddWithValue("@brought_forward", broughtForwardField.Text.Trim());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                }
                

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
            Reset();
            FillDataGrid();
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
            dataGrid.Columns[0].Visible = false;
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

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(dataGrid.CurrentRow.Cells[0].Value.ToString());
            premisesNumberField.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            accountNumberField.Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
            accountHoldersNameField.Text = dataGrid.CurrentRow.Cells[3].Value.ToString();
            accountHoldersAddressField.Text = dataGrid.CurrentRow.Cells[4].Value.ToString();

            previousBalanceField.Text = dataGrid.CurrentRow.Cells[9].Value.ToString();
            paymentsField.Text = dataGrid.CurrentRow.Cells[10].Value.ToString();
            broughtForwardField.Text = dataGrid.CurrentRow.Cells[12].Value.ToString();

            currentReadingField.Text = dataGrid.CurrentRow.Cells[5].Value.ToString();
            previousReadingField.Text = dataGrid.CurrentRow.Cells[6].Value.ToString();
            currentUsageField.Text = dataGrid.CurrentRow.Cells[7].Value.ToString();
            fuelAdjustmentRateField.Text = dataGrid.CurrentRow.Cells[8].Value.ToString();
            saveButton.Text = "Update";
            deleteButton.Enabled = true;
            deleteButton.Cursor = default;
            BillView();
        }
        void Reset()
        {
            premisesNumberField.Text = "";
            accountNumberField.Text = "";
            accountHoldersNameField.Text = "";
            accountHoldersAddressField.Text = "";

            previousBalanceField.Text = "";
            paymentsField.Text = "";
            broughtForwardField.Text = "";

            currentReadingField.Text = "";
            previousReadingField.Text = "";
            currentUsageField.Text = "";
            fuelAdjustmentRateField.Text = "";
            saveButton.Text = "Save";
            Id = 0;
            deleteButton.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                SqlCommand command = new SqlCommand("CustomerDelete", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Id", Id);
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                connection.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
                throw;
            }
            Reset();
            FillDataGrid();
            
        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label25_Click(object sender, EventArgs e)
        {

        }

        void BillView()
        {

            //Dates
            Random rand = new Random();
            int d = rand.Next(1, 31);
            int m = rand.Next(1, 12);
            int y = rand.Next(2000, 2019);

            int dd = rand.Next(1, 31);
            int mm = rand.Next(1, 12);
            int yy = rand.Next(2000, 2019);

            DateTime statement_Date = new DateTime(yy,mm,dd);
            DateTime due_Date = new DateTime(y, m, d);
            DateTime payment_Date = Convert.ToDateTime(dataGrid.CurrentRow.Cells[11].Value.ToString());

            double fa_rate = Convert.ToDouble(dataGrid.CurrentRow.Cells[8].Value.ToString());
            double rate = 9.660;
            double customer_charge = 455;
            double current_usage = Convert.ToDouble(dataGrid.CurrentRow.Cells[8].Value.ToString());
            double taxable = 0;
            double gct = 0.0165;


            //Calculated
            double current_charges = (current_usage * rate);
            double subtotal = (current_charges + customer_charge);
            double fe_adjustment = (subtotal * fa_rate); //fe adjustments
            double f_ipp_charges = (current_usage * 21.794);
            double tce_before_tax = (subtotal + fe_adjustment + f_ipp_charges);
            double nontaxable = tce_before_tax;
            double gct_charge;
            double ep_discount;
            if (current_usage < 150)
            {
                gct_charge = 0;
            }
            else
            {
                gct_charge = (gct * current_usage);
            }
            //Early payment Discount
            if (payment_Date < due_Date)
            {
                ep_discount = -250;
            }
            else {
                ep_discount = 0;
            }
            double taxes = gct_charge;
            double total_current_charges = (tce_before_tax + ep_discount + taxable + taxes);
            //final bill
            double total_amount_due = total_current_charges;

            //labels
            due_date_label.Text = due_Date.ToString();
            statement_date_label.Text = statement_Date.ToString();

            pnum.Text = dataGrid.CurrentRow.Cells[1].Value.ToString();
            acc_num.Text = dataGrid.CurrentRow.Cells[2].Value.ToString();
            acc_name.Text = dataGrid.CurrentRow.Cells[3].Value.ToString();
            address.Text = dataGrid.CurrentRow.Cells[4].Value.ToString();

            prev_bal.Text = dataGrid.CurrentRow.Cells[9].Value.ToString();
            payments_label.Text = dataGrid.CurrentRow.Cells[10].Value.ToString();
            payment_date_label.Text = payment_Date.ToString();
            b_forward.Text = dataGrid.CurrentRow.Cells[12].Value.ToString();
            current_charges_label.Text = current_charges.ToString();

            
            current_reading_label.Text = dataGrid.CurrentRow.Cells[5].Value.ToString();
            previous_reading_label.Text = dataGrid.CurrentRow.Cells[6].Value.ToString();
            current_usage_label.Text = dataGrid.CurrentRow.Cells[7].Value.ToString();
            fa_rate_label.Text = dataGrid.CurrentRow.Cells[8].Value.ToString();
            rate_label.Text = rate.ToString();
            customer_label.Text = current_charges.ToString();
            //fuelAdjustmentRateField.Text = dataGrid.CurrentRow.Cells[8].Value.ToString();

        }

        private void Label25_Click_1(object sender, EventArgs e)
        {

        }
    }
}
