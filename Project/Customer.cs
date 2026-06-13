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
            string customerEmail = inputTxtCust.Text;
            Customer_Load(customerEmail);
        }

        private void Customer_Load(string customerEmail)
        {

            string query = "SELECT CID FROM Customer WHERE Email = @email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", customerEmail);

                    try
                    {
                        conn.Open();

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int customerId = Convert.ToInt32(result);

                            customerPortal portal = new customerPortal(connectionString,customerId);
                            portal.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Customer email not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void inputTxtCust_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

