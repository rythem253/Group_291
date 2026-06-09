using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
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
            string dummy = "r@mail.com";
            
            //SQL Query EG: SELECT FROM EMPLOYEE DATABASE, WHERE EMAIL CONTAINS THE TYPED EMAIL
            if (inputTxt.Text == dummy)
            {
               employeePortal employeePortal = new employeePortal();
               employeePortal.Show();
            } else {
                //ELSE IF
                //NOT CONTAIN, THEN ERROR DIALOG
                MessageBox.Show("Invalid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
