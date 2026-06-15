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

        private string connectionString;
        public employeePortal(string connString)
        {
            InitializeComponent();
            connectionString = connString;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void parrotSegment1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Main.load_login();
            this.Close();
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            ManageRentals ManageRentals = new ManageRentals(connectionString);
            ManageRentals.Show();
        }

        private void btnMovieCasting_Click(object sender, EventArgs e)
        {
            MovieCasting movieCasting = new MovieCasting(connectionString);
            movieCasting.Show();
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
