
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Project
{
    public partial class Form1 : Form
    {

        private string connectionString =
@"Server=RYTHEM;Database=LibraryLabDB;Trusted_Connection=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SelectionScreen_Click(object sender, EventArgs e)
        {

        }

        private void customerSelection_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Customer customerForm = new Customer(connectionString);
            customerForm.Show();
            this.Hide();
        }

        private void lblSelect_Click(object sender, EventArgs e)
        {

        }

        private void empSelection_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Employee employeeForm = new Employee(connectionString);
            employeeForm.Show();
            this.Hide();
        }
    }
}
