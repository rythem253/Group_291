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
            string query = @"SELECT EID 
                             FROM Employee 
                             WHERE Email = @EmployeeEmail";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeEmail", employeeEmail);
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            int employeeId = Convert.ToInt32(result);
                            employeePortal employeePortal = new employeePortal(employeeId);
                            employeePortal.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email. Please try again.");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                }

            }
        }
    }
            


