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

        public Employee(string connString)
        {
            InitializeComponent();
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

        private void Employee_Load(string employeeEmail)
        {
            string query = @"SELECT EmployeeEmail 
                             FROM Employees 
                             WHERE EmployeeEmail = @EmployeeEmail";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@EmployeeEmail", employeeEmail);

                }

            }
        }
    }
            


