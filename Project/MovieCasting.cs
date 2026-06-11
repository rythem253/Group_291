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
using static ReaLTaiizor.Drawing.Poison.PoisonPaint.ForeColor;

namespace Project
{
    public partial class MovieCasting : Form
    {
        private string connectionString;
        public MovieCasting(string connString)
        {
            InitializeComponent();
            connectionString = connString;
            LoadCasting();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadCasting()
        {
            string query = @"
        SELECT Movies.Title, Actor.FName
        FROM Movies
        JOIN Features ON Features.MovieID = Movies.MovieID
        JOIN Actor ON Actor.AID = Features.AID
        ORDER BY Movies.Title ASC;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvLoadCasting.DataSource = table;
            }
        }

    }
}
