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
    public partial class Employee : Form
    {

        private string connectionString;
        private Form1 parent;

        public Employee(string connString, Form1 login)
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

        private void formTheme1_Click(object sender, EventArgs e)
        {

        }

        private void authEmailEmp_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void crownTitle1_Click(object sender, EventArgs e)
        {

        }

        private void crownTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string employeeEmail = inputTxt.Text;
            Employee_Load(employeeEmail);
        }

        //Copy new tables with Employee Email, since this table does not have it.
        private void Employee_Load(string employeeEmail)
        {
            string query = "SELECT * FROM Employee WHERE Email = @Email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Email", employeeEmail);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    employeePortal EmployeePortal = new employeePortal(connectionString);
                    EmployeePortal.Show();
                }
                else
                {
                    MessageBox.Show("Employee not found");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main.mainPanel.Controls.Clear();
            Main.mainPanel.Controls.Add(parent);
            this.Close();
        }
    }
} 


