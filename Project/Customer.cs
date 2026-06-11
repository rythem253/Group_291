using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Project
{
    public partial class Customer : Form
    {
        private string connectionString;

        public Customer(string connString)
        {
            InitializeComponent();
            connectionString = connString;
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void inputTxtCustomer(object sender, EventArgs e)
        {
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {  
            string customerName = inputTxtCust.Text;
            Customer_Load(customerName);
        }

        private void Customer_Load(string customerName)
        {

            string query = "SELECT * FROM Customer WHERE FName = @Name";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Name", customerName);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    customerPortal CustomerPortal = new customerPortal();
                    CustomerPortal.Show();
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }

            }
        }

        private void inputTxtCust_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

