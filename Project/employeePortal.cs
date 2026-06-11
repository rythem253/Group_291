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
    public partial class employeePortal : Form
    {
        private int _employeeId;
        public employeePortal(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void parrotSegment1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            ManageRentals ManageRentals = new ManageRentals();
            ManageRentals.Show();
        }
    }
}
