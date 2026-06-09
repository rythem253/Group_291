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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void inputTxtCustomer(object sender, EventArgs e)
        {
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string dummy = "r@mail.com";

            //SQL Query EG: SELECT FROM EMPLOYEE DATABASE, WHERE EMAIL CONTAINS THE TYPED EMAIL
            if (inputTxtCust.Text == dummy)
            {
                customerPortal customerPortal = new customerPortal();
                customerPortal.Show();
            }
            else
            {
                //ELSE IF
                //NOT CONTAIN, THEN ERROR DIALOG
                MessageBox.Show("Invalid email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    }

