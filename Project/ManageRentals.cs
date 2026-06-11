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
    public partial class ManageRentals : Form
    {
        private string connectionString;
        public ManageRentals(string connString)
        {
            InitializeComponent();
            connectionString = connString;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageRentals_Load(object sender, EventArgs e)
        {

        }

        private void skyLabel1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SQL Query for each option.
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddNewRental addNew = new AddNewRental(connectionString);
            addNew.Show();
            this.Hide();
        }
    }
}
