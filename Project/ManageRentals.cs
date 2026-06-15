using Microsoft.Data.SqlClient; // Added to use SQL
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class ManageRentals : Form
    {
        // Server Connection string
        private string connectionString;

        // Sorting order for the rentals
        private string sortOrder = "ASC";
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
            comboBox1.SelectedIndex = 0; // Set default filter to "All"
        }

        private void skyLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            string sql;

            if (comboBox1.Text == "All")
            {
                sql = @"Select R.RentID, R.CID AS CustomerID, C.FName + ' ' + C.LName AS CustomerName, M.Title, R.CheckoutDate, R.ReturnDate, R.[Status]
                FROM Rental AS R JOIN Customer AS C ON R.CID = C.CID JOIN Rented AS RT ON R.RentID = RT.RentID JOIN Movies AS M ON RT.MovieID = M.MovieID
                WHERE C.Email LIKE @Search OR C.PhoneNum LIKE @Search 
                OR C.FName + ' ' + C.LName LIKE @Search 
                OR C.LName + ' ' + C.FName LIKE @Search";
            }
            else
            {
                sql = @"Select R.RentID, R.CID AS CustomerID, C.FName + ' ' + C.LName AS CustomerName, M.Title, R.CheckoutDate, R.ReturnDate, R.[Status]
                FROM Rental AS R JOIN Customer AS C ON R.CID = C.CID JOIN Rented AS RT ON R.RentID = RT.RentID JOIN Movies AS M ON RT.MovieID = M.MovieID
                WHERE (C.Email LIKE @Search OR C.PhoneNum LIKE @Search 
                OR C.FName + ' ' + C.LName LIKE @Search 
                OR C.LName + ' ' + C.FName LIKE @Search)
                AND R.[Status] = @Status";
            }

            sql += $" ORDER BY R.ReturnDate {sortOrder}";

            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + Searchbar.Text + "%");
                if (comboBox1.Text != "All")
                    adapter.SelectCommand.Parameters.AddWithValue("@Status", comboBox1.Text);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Filter Dropdown
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddNewRental addNew = new AddNewRental(connectionString);
            addNew.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Searchbar_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AscBut_Click(object sender, EventArgs e)
        {
            sortOrder = "ASC";
            LoadData();
            AscBut.BackColor = Color.Black;
            AscBut.ForeColor = Color.White;
            DescBut.BackColor = Color.FromArgb(240, 240, 240); // reset desc to default
            DescBut.ForeColor = Color.Black;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void DescBut_Click(object sender, EventArgs e)
        {
            sortOrder = "DESC";
            LoadData();
            DescBut.BackColor = Color.Black;
            DescBut.ForeColor = Color.White;
            AscBut.BackColor = Color.FromArgb(240, 240, 240); // reset asc to default
            AscBut.ForeColor = Color.Black;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void ReturnBut_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnRental returnRental = new ReturnRental(connectionString);
            returnRental.ShowDialog();
        }
    }
}