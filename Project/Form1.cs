
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Project
{
    public partial class Form1 : Form
    {

        private string connectionString =
@"Server=localhost;Database=CMPT291_Team1_MovieRental;Trusted_Connection=True;TrustServerCertificate=True;";
        public Form1()
        {
            if (Main.mainPanel == null)
            {
                this.Close();
                throw new NullReferenceException(
                    "No panel to display");
            }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void customerSelection_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Customer customerForm = new Customer(connectionString, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Main.mainPanel.Controls.Clear();
            Main.mainPanel.Controls.Add(customerForm);
            customerForm.Show();
            //this.Hide();
        }

        private void empSelection_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Employee employeeForm = new Employee(connectionString, this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Main.mainPanel.Controls.Clear();
            Main.mainPanel.Controls.Add(employeeForm);
            employeeForm.Show();
        }
    }
}
