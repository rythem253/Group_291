using Microsoft.Data.SqlClient;
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
    public partial class ReturnRental : Form
    {
        private string connectionString;
        public ReturnRental(string connString)
        {
            InitializeComponent();
            connectionString = connString;

        }

        private void CanBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReturnRental_Load(object sender, EventArgs e)
        {

        }

        private void ConBut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RSearch.Text))
            {
                MessageBox.Show("Please enter a RentID to return.");
                return;
            }

            int RentID = Convert.ToInt32(RSearch.Text);

            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                SqlCommand cmd1 = new SqlCommand("UPDATE Rental SET [Status] = 'Returned' WHERE RentID = @RentID", conn);
                cmd1.Parameters.AddWithValue("@RentID", RentID);
                cmd1.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("UPDATE Movies SET Quantity = Quantity + 1 WHERE MovieID = (SELECT RT.MovieID FROM Rented as RT WHERE RT.RentID = @RentID)", conn);
                cmd2.Parameters.AddWithValue("@RentID", RentID);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Rental returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning rental: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}