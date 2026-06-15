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
        private Form1 parent;

        public Customer(string connString, Form1 login)
        {
            if (Main.mainPanel == null)
            {
                this.Close();
                throw new NullReferenceException(
                    "No panel to display");
            }
            InitializeComponent();
            this.parent = login;
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
                            portal.TopLevel = false;

                            Main.mainPanel.Controls.Clear();
                            Main.mainPanel.Controls.Add(portal);
                            portal.Show();
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

        private void airButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (parent == null)
            {
                parent = new Form1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            }
            Main.mainPanel.Controls.Clear();
            Main.mainPanel.Controls.Add(parent);
            this.Close();
        }
    }
}

