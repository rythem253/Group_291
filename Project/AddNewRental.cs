using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Project
{
    public partial class AddNewRental : Form
    {
        private string connectionString;
        public AddNewRental(string connString)
        {
            InitializeComponent();
            connectionString = connString;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddNewRental_Load(object sender, EventArgs e)
        {
            label7.Text = "Due: --";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rb1Day_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDueDate();
        }

        private void rb3Day_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDueDate();
        }

        private void rb7Day_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDueDate();
        }

        private void UpdateDueDate()
        {
            if (!DateTime.TryParse(checkoutTxt.Text, out DateTime checkoutDate))
            {
                label7.Text = "Due: --";
                return;
            }

            int daysToAdd = GetSelectedRentalDays();

            if (daysToAdd == 0)
            {
                label7.Text = "Due: --";
                return;
            }

            DateTime dueDate = checkoutDate.AddDays(daysToAdd);
            label7.Text = "Due: " + dueDate.ToShortDateString();
        }

        private int GetSelectedRentalDays()
        {
            if (radioButton1.Checked) return 1;
            if (radioButton2.Checked) return 3;
            if (radioButton3.Checked) return 7;

            return 0;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string EID = eidTxt.Text;
            string CID = cidTxt.Text;

            string parseMovieName = movieNameTxt.Text;

            string findMovieID = @"Select Movies.MovieID
                    From Movies
                    Where Movies.Title = @parseMovieName";

            string Status = "In Use";
            string Rating = null;

            DateTime checkoutDate = DateTime.Parse(checkoutTxt.Text);

            int rentalDays = GetSelectedRentalDays();
            if (rentalDays == 0)
            {
                MessageBox.Show("Please select a rental length.");
                return;
            }
            DateTime dueDate = checkoutDate.AddDays(rentalDays);

            string findRentNum = @"SELECT ISNULL(MAX(RentID), 0) FROM Rental";

            string insertRental = @"
                INSERT INTO Rental
                (RentID, EID, CID, CheckoutDate, DueDate, Status, Rating)
                VALUES
                (@RentID, @EID, @CID, @CheckoutDate, @DueDate, @Status, @Rating)";

            string insertRented = @"
                INSERT INTO Rented
                (RentID, MovieID)
                VALUES
                (@RentID, @MovieID)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmdCount = new SqlCommand(findRentNum, conn))
            using (SqlCommand cmd = new SqlCommand(insertRental, conn))
            using (SqlCommand cmdMovieID = new SqlCommand(findMovieID, conn))
            using (SqlCommand cmd2 = new SqlCommand(insertRented, conn))
            {
                try
                {
                    conn.Open();

                    int RentID = Convert.ToInt32(cmdCount.ExecuteScalar()) + 1;
                    cmdMovieID.Parameters.AddWithValue("@parseMovieName", parseMovieName);

                    object result = cmdMovieID.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Movie not found.");
                        return;
                    }

                    int MovieID = Convert.ToInt32(result);

                    // Rental insert
                    cmd.Parameters.AddWithValue("@RentID", RentID);
                    cmd.Parameters.AddWithValue("@EID", EID);
                    cmd.Parameters.AddWithValue("@CID", CID);
                    cmd.Parameters.AddWithValue("@CheckoutDate", checkoutDate);
                    cmd.Parameters.AddWithValue("@DueDate", dueDate);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@Rating", (object)Rating ?? DBNull.Value);

                    // Rented insert
                    cmd2.Parameters.AddWithValue("@RentID", RentID);
                    cmd2.Parameters.AddWithValue("@MovieID", MovieID);

                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    MessageBox.Show("Inserted successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void checkoutTxt_TextChanged(object sender, EventArgs e)
        {
            UpdateDueDate();
        }
    }
}