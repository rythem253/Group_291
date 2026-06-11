using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient; // Added to use SQL
using System.Windows.Forms;

namespace Project
{
    public partial class ManageRentals : Form
    {
        // Server Connection string
        private string connectionString =
            @"Server=localhost;Database=CMPT291_Team1_MovieRental;Trusted_Connection=True;TrustServerCertificate=True;";
        public ManageRentals()
        {
            InitializeComponent();
        }

        // This method runs a SELECT query and displays the result in a DataGridView.
        // Parameters:

        //   sql = the SQL query to run (e.g. "SELECT * FROM Rentals")
        //   grid = the DataGridView where the result should appear
        private void LoadData(string sql, DataGridView grid)
        {
            try
            {
                // using means the connection will be closed automatically when done.
                using SqlConnection conn = new SqlConnection(connectionString);

                // SqlDataAdapter is convenient for SELECT queries.
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                // DataTable stores the SQL result temporarily in C#.
                DataTable table = new DataTable();

                // Fill sends the query to SQL Server and loads the result into table.
                adapter.Fill(table);

                // DataSource tells the DataGridView what data to display.
                grid.DataSource = table;
            }
            catch (Exception ex)
            {
                // If something goes wrong, show the error message.
                // This is helpful during development and demo testing.
                MessageBox.Show("Database error: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            string sql = @"Select R.RentID, R.CID, C.FName + ' ' + C.LName AS CustomerName, R.MovieID, R.CheckoutDate, R.ReturnDate, R.[Status]
                           FROM Rental AS R JOIN Customer AS C ON R.CID = C.CID 
                           WHERE [Status] = @Status";
            try
            {
                // using means the connection will be closed automatically when done.
                using SqlConnection conn = new SqlConnection(connectionString);

                // SqlDataAdapter is convenient for SELECT queries.
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                adapter.SelectCommand.Parameters.AddWithValue("@Status", comboBox1.Text.ToString());

                // DataTable stores the SQL result temporarily in C#.
                DataTable table = new DataTable();

                // Fill sends the query to SQL Server and loads the result into table.
                adapter.Fill(table);

                // DataSource tells the DataGridView what data to display.
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                // If something goes wrong, show the error message.
                // This is helpful during development and demo testing.
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}