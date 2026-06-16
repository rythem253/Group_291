using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public partial class customerPortal : Form
    {
        private string connectionString;
        private int currentCustomerId;
        private bool isEditingProfile = false;


        private string selectedMovieId = "";
        private string selectedMovieTitle = "";

        private string watchlistSelectedMovieId = "";
        private string watchlistSelectedMovieTitle = "";
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;

        public customerPortal(string connString, int customerId)
        {
            InitializeComponent();
            connectionString = connString;
            currentCustomerId = customerId;

            this.Controls.Add(panelNewReleases);
            this.Controls.Add(panelOnHold);
            this.Controls.Add(panelPending);
            this.Controls.Add(panelAccount);

            onHoldToolStripMenuItem.Click += onHoldToolStripMenuItem_Click;
            rentalsToolStripMenuItem.Click += pendingRentalsToolStripMenuItem_Click;
            accountInformationToolStripMenuItem.Click += accountInformationToolStripMenuItem_Click;


            dgvNewReleases.CellClick += dgvNewReleases_CellClick;
            dgvWatchlist.CellClick += dgvWatchlist_CellClick;
            btnUpdateOrder.Click += btnUpdateOrder_Click;
            dgvAllMovies.CellClick += dgvAllMovies_CellClick;
            dgvWatchlist.AllowDrop = true;

            dgvWatchlist.MouseDown += dgvWatchlist_MouseDown;
            dgvWatchlist.MouseMove += dgvWatchlist_MouseMove;
            dgvWatchlist.DragOver += dgvWatchlist_DragOver;
            dgvWatchlist.DragDrop += dgvWatchlist_DragDrop;

            PopulateNewReleaseGenreMenu(newReleaseToolStripMenuItem);

            panelNewReleases.Dock = DockStyle.Fill;
            ShowPanel(panelMainContainer);
        }

        private void panelWelcome_Paint(object sender, PaintEventArgs e)
        {
            LoadCustomerName();
        }

        private void ShowPanel(Panel activePanel)
        {
            panelAllMovies.Visible = (activePanel == panelAllMovies);
            panelNewReleases.Visible = (activePanel == panelNewReleases);
            panelOnHold.Visible = (activePanel == panelOnHold);
            panelPending.Visible = (activePanel == panelPending);
            panelRentalRecords.Visible = (activePanel == panelRentalRecords);
            panelAccount.Visible = (activePanel == panelAccount);
            if (activePanel != null)
            {
                activePanel.BringToFront();
            }
        }

        private void viewAllMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(panelAllMovies);
            LoadAllMovies();
        }

        private void btnSearchMovies_Click(object sender, EventArgs e)
        {
            string criteria = cmbSearchCriteria.SelectedItem?.ToString();
            string searchString = txtSearchAllMovies.TextButton.Trim();
            if (string.IsNullOrEmpty(searchString))
            {
                LoadAllMovies();
                return;
            }
            ExecuteMovieSearch(criteria, searchString);
        }

        private void ExecuteMovieSearch(string criteria, string searchString)
        {
            string query = "";
            List<SqlParameter> parameters = new List<SqlParameter>();
            string wildCardValue = "%" + searchString + "%";

            if (criteria == "Title")
            {
                query = @"SELECT MovieID, Title, Genre, Quantity, Price, PopScore 
                 FROM Movies 
                 WHERE Title LIKE @Search;";
                parameters.Add(new SqlParameter("@Search", wildCardValue));
            }
            else if (criteria == "Genre")
            {
                query = @"SELECT MovieID, Title, Genre, Quantity, Price, PopScore 
                 FROM Movies 
                 WHERE Genre LIKE @Search;";
                parameters.Add(new SqlParameter("@Search", wildCardValue));
            }
            else if (criteria == "Actor Name")
            {
                query = @"SELECT DISTINCT M.MovieID, M.Title, M.Genre, M.Quantity, M.Price, M.PopScore, A.FName + ' ' + A.LName AS ActorName
                 FROM Movies M
                 JOIN Features F ON M.MovieID = F.MovieID
                 JOIN Actor A ON F.AID = A.AID
                 WHERE (A.FName + ' ' + A.LName) LIKE @Search;";
                parameters.Add(new SqlParameter("@Search", wildCardValue));
            }

            ExecuteGridLoader(query, dgvAllMovies, parameters.ToArray());
            ConfigureAllMoviesGridColumns();
        }

        private void LoadAllMovies()
        {
            string query = "SELECT MovieID, Title, Genre, Quantity, Price, PopScore FROM Movies;";

            ExecuteGridLoader(query, dgvAllMovies, (SqlParameter)null);

            ConfigureAllMoviesGridColumns();
        }

        private void ConfigureAllMoviesGridColumns()
        {
            dgvAllMovies.ReadOnly = false;

            if (dgvAllMovies.Columns["MovieID"] != null) dgvAllMovies.Columns["MovieID"].ReadOnly = true;
            if (dgvAllMovies.Columns["Title"] != null) dgvAllMovies.Columns["Title"].ReadOnly = true;
            if (dgvAllMovies.Columns["Genre"] != null) dgvAllMovies.Columns["Genre"].ReadOnly = true;
            if (dgvAllMovies.Columns["Quantity"] != null) dgvAllMovies.Columns["Quantity"].ReadOnly = true;
            if (dgvAllMovies.Columns["Price"] != null) dgvAllMovies.Columns["Price"].ReadOnly = true;
            if (dgvAllMovies.Columns["PopScore"] != null) dgvAllMovies.Columns["PopScore"].ReadOnly = true;

            if (dgvAllMovies.Columns["WatchlistBtnColumn"] == null)
            {
                DataGridViewButtonColumn watchlistButtonColumn = new DataGridViewButtonColumn();
                watchlistButtonColumn.Name = "WatchlistBtnColumn";
                watchlistButtonColumn.HeaderText = "Watchlist";
                watchlistButtonColumn.Text = "Add to Watchlist";
                watchlistButtonColumn.UseColumnTextForButtonValue = true;
                watchlistButtonColumn.Width = 120;

                dgvAllMovies.Columns.Add(watchlistButtonColumn);
            }
        }

        private void dgvAllMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvAllMovies.Columns[e.ColumnIndex].Name == "WatchlistBtnColumn")
                {
                    DataGridViewRow row = dgvAllMovies.Rows[e.RowIndex];
                    string mID = row.Cells["MovieID"].Value.ToString();
                    string title = row.Cells["Title"].Value.ToString();

                    AddMovieToWatchlistFromSearch(mID, title);
                }
            }
        }

        private void AddMovieToWatchlistFromSearch(string movieId, string title)
        {
            string watchlistQuery = @"
                                        IF NOT EXISTS (SELECT 1 FROM Watchlist WHERE CID = @CID AND MovieID = @MovieID)
                                        BEGIN
                                            INSERT INTO Watchlist (CID, MovieID, WatchOrder) 
                                            VALUES (@CID, @MovieID, (SELECT ISNULL(MAX(WatchOrder), 0) + 1 FROM Watchlist WHERE CID = @CID));
                                        END;";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CID", currentCustomerId),
                new SqlParameter("@MovieID", movieId)
            };

            int rowsAffected = ExecuteNonQueryLoader(watchlistQuery, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show($"'{title}' has been added to your watchlist!", "Watchlist Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rowsAffected == 0 || rowsAffected == -1)
            {
                MessageBox.Show("This movie is already in your watchlist.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PopulateNewReleaseGenreMenu(ToolStripMenuItem newReleaseMenuItem)
        {
            string query = "SELECT DISTINCT Genre FROM Movies WHERE Genre IS NOT NULL AND Genre <> '' AND YEAR(Release) > YEAR('2012') ORDER BY Genre ASC;";
            newReleaseMenuItem.DropDownItems.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string genre = reader["Genre"].ToString();
                                ToolStripMenuItem genreItem = new ToolStripMenuItem(genre);
                                genreItem.Click += GenreItem_Click;
                                newReleaseMenuItem.DropDownItems.Add(genreItem);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading categories: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void GenreItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            if (clickedItem != null)
            {
                ShowPanel(panelNewReleases);
                LoadNewReleases(clickedItem.Text, dgvNewReleases);
            }
        }

        public void LoadNewReleases(string selectedGenre, DataGridView targetGrid)
        {
            string query = "SELECT MovieID, Title, Genre, Quantity, Price, PopScore FROM Movies WHERE Quantity > 0 AND Genre = @Genre AND YEAR(Release) > YEAR('2012') ORDER BY Release DESC;";
            SqlParameter param = new SqlParameter("@Genre", selectedGenre);

            ExecuteGridLoader(query, targetGrid, param);

            ConfigureNewReleasesGridColumns(targetGrid);
        }

        private void ConfigureNewReleasesGridColumns(DataGridView targetGrid)
        {
            targetGrid.ReadOnly = false;
            if (targetGrid.Columns["MovieID"] != null) targetGrid.Columns["MovieID"].ReadOnly = true;
            if (targetGrid.Columns["Title"] != null) targetGrid.Columns["Title"].ReadOnly = true;
            if (targetGrid.Columns["Genre"] != null) targetGrid.Columns["Genre"].ReadOnly = true;
            if (targetGrid.Columns["Quantity"] != null) targetGrid.Columns["Quantity"].ReadOnly = true;
            if (targetGrid.Columns["Price"] != null) targetGrid.Columns["Price"].ReadOnly = true;
            if (targetGrid.Columns["PopScore"] != null) targetGrid.Columns["PopScore"].ReadOnly = true;

            if (targetGrid.Columns["NewReleaseWatchlistBtn"] == null)
            {
                DataGridViewButtonColumn actionButtonColumn = new DataGridViewButtonColumn();
                actionButtonColumn.Name = "NewReleaseWatchlistBtn";
                actionButtonColumn.HeaderText = "Watchlist";
                actionButtonColumn.Text = "Add to Watchlist";
                actionButtonColumn.UseColumnTextForButtonValue = true;
                actionButtonColumn.Width = 120;

                targetGrid.Columns.Add(actionButtonColumn);
            }
        }

        private void dgvNewReleases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvNewReleases.Columns[e.ColumnIndex].Name == "NewReleaseWatchlistBtn")
                {
                    DataGridViewRow row = dgvNewReleases.Rows[e.RowIndex];
                    string mID = row.Cells["MovieID"].Value.ToString();
                    string title = row.Cells["Title"].Value.ToString();

                    AddMovieToWatchlistFromSearch(mID, title);
                }
            }
        }


        private void ExecuteGridLoader(string statement, DataGridView grid, SqlParameter parameter)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(statement, conn))
                {
                    if (parameter != null) cmd.Parameters.Add(parameter);
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        grid.DataSource = dt;
                        grid.BringToFront();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Pipeline failed reading data: " + ex.Message, "Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ExecuteGridLoader(string statement, DataGridView grid, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(statement, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    try
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        grid.DataSource = dt;
                        grid.BringToFront();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Pipeline failed reading data: " + ex.Message, "Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private int ExecuteNonQueryLoader(string statement, SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(statement, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database transaction execution error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -2;
                    }
                }
            }
        }

        private void watchListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(panelWatchList);
            RefreshWatchlistGrid();
        }
        private void RefreshWatchlistGrid()
        {
            string query = @"SELECT W.MovieID, M.Title, M.Genre, M.Quantity, W.WatchOrder 
                     FROM Watchlist W 
                     JOIN Movies M ON W.MovieID = M.MovieID 
                     WHERE W.CID = @CID 
                     ORDER BY W.WatchOrder ASC;";

            SqlParameter param = new SqlParameter("@CID", currentCustomerId);

            ExecuteGridLoader(query, dgvWatchlist, param);

            dgvWatchlist.ReadOnly = true;
            if (dgvWatchlist.Columns["MovieID"] != null) dgvWatchlist.Columns["MovieID"].Visible = false;

            if (dgvWatchlist.Columns["RentBtnColumn"] == null)
            {
                DataGridViewButtonColumn rentButtonColumn = new DataGridViewButtonColumn();
                rentButtonColumn.Name = "RentBtnColumn";
                rentButtonColumn.HeaderText = "Rent";
                rentButtonColumn.Text = "Rent Movie";
                rentButtonColumn.UseColumnTextForButtonValue = true;
                rentButtonColumn.Width = 90;
                dgvWatchlist.Columns.Add(rentButtonColumn);
            }

            if (dgvWatchlist.Columns["RemoveBtnColumn"] == null)
            {
                DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();
                removeButtonColumn.Name = "RemoveBtnColumn";
                removeButtonColumn.HeaderText = "Remove";
                removeButtonColumn.Text = "Remove";
                removeButtonColumn.UseColumnTextForButtonValue = true;
                removeButtonColumn.Width = 80;
                dgvWatchlist.Columns.Add(removeButtonColumn);
            }
        }

        private void dgvWatchlist_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dgvWatchlist.PointToClient(new Point(e.X, e.Y));
            rowIndexOfItemUnderMouseToDrop = dgvWatchlist.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            if (e.Effect == DragDropEffects.Move && rowIndexOfItemUnderMouseToDrop >= 0 && rowIndexFromMouseDown != rowIndexOfItemUnderMouseToDrop)
            {
                DataTable dt = (DataTable)dgvWatchlist.DataSource;

                DataRow sourceRow = dt.Rows[rowIndexFromMouseDown];
                DataRow newRow = dt.NewRow();
                newRow.ItemArray = sourceRow.ItemArray;

                dt.Rows.RemoveAt(rowIndexFromMouseDown);
                dt.Rows.InsertAt(newRow, rowIndexOfItemUnderMouseToDrop);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string mID = dt.Rows[i]["MovieID"].ToString();
                    int cleanNewOrder = i + 1;

                    string updateQuery = "UPDATE Watchlist SET WatchOrder = @WatchOrder WHERE CID = @CID AND MovieID = @MovieID;";
                    SqlParameter[] parameters = new SqlParameter[]
                    {
                        new SqlParameter("@WatchOrder", cleanNewOrder),
                        new SqlParameter("@CID", currentCustomerId),
                        new SqlParameter("@MovieID", mID)
                    };

                    ExecuteNonQueryLoader(updateQuery, parameters);
                }

                RefreshWatchlistGrid();
            }
        }

        private void dgvWatchlist_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dgvWatchlist.HitTest(e.X, e.Y).RowIndex;

            if (rowIndexFromMouseDown != -1)
            {
                Size dragSize = SystemInformation.DragSize;
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
            }
            else
            {
                dragBoxFromMouseDown = Rectangle.Empty;
            }
        }

        private void dgvWatchlist_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    DragDropEffects dropEffect = dgvWatchlist.DoDragDrop(dgvWatchlist.Rows[rowIndexFromMouseDown], DragDropEffects.Move);
                }
            }
        }

        private void dgvWatchlist_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvWatchlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvWatchlist.Rows[e.RowIndex];
                string mID = row.Cells["MovieID"].Value.ToString();
                string title = row.Cells["Title"].Value.ToString();

                if (dgvWatchlist.Columns[e.ColumnIndex].Name == "RentBtnColumn")
                {
                    DialogResult result = MessageBox.Show($"Would you like to finalize a rental checkout for '{title}' right now?", "Confirm Rental", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ProcessRentalFromWatchlist(mID, title);
                    }
                    return;
                }

                if (dgvWatchlist.Columns[e.ColumnIndex].Name == "RemoveBtnColumn")
                {
                    DialogResult deleteConfirm = MessageBox.Show($"Are you sure you want to remove '{title}' from your watchlist?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (deleteConfirm == DialogResult.Yes)
                    {
                        RemoveMovieFromWatchlist(mID, title);
                    }
                    return;
                }
            }
        }

        private void RemoveMovieFromWatchlist(string movieId, string title)
        {
            string deleteQuery = "DELETE FROM Watchlist WHERE CID = @CID AND MovieID = @MovieID;";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@CID", currentCustomerId),
                new SqlParameter("@MovieID", movieId)
            };

            if (ExecuteNonQueryLoader(deleteQuery, parameters) >= 0)
            {
                MessageBox.Show($"'{title}' has been removed from your watchlist.", "Item Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshWatchlistGrid();
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            dgvWatchlist.EndEdit();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    foreach (DataGridViewRow row in dgvWatchlist.Rows)
                    {
                        if (row.Cells["MovieID"].Value != null && row.Cells["WatchOrder"].Value != null)
                        {
                            string mID = row.Cells["MovieID"].Value.ToString();

                            if (int.TryParse(row.Cells["WatchOrder"].Value.ToString(), out int newOrder))
                            {
                                string updateQuery = "UPDATE Watchlist SET WatchOrder = @WatchOrder WHERE CID = @CID AND MovieID = @MovieID;";

                                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@WatchOrder", newOrder);
                                    cmd.Parameters.AddWithValue("@CID", currentCustomerId);
                                    cmd.Parameters.AddWithValue("@MovieID", mID);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Watchlist priority layout order saved successfully!", "Order Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshWatchlistGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed saving order updates to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProcessRentalFromWatchlist(string movieId, string title)
        {
            int currentStock = 0;
            int nextRentId = 0;

            try
            {
                string checkQuery = "SELECT Quantity FROM Movies WHERE MovieID = @MovieID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MovieID", movieId);
                        currentStock = Convert.ToInt32(checkCmd.ExecuteScalar());
                    }
                }

                if (currentStock <= 0)
                {
                    MessageBox.Show($"'{title}' is currently out of stock. Redirecting this item straight to your hold positions queue...", "Out of Physical Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AddToQueue(movieId, title);

                    watchlistSelectedMovieId = "";
                    watchlistSelectedMovieTitle = "";
                    RefreshWatchlistGrid();
                    return;
                }

                string maxRentIdQuery = "SELECT ISNULL(MAX(RentID), 0) + 1 FROM Rental;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand maxCmd = new SqlCommand(maxRentIdQuery, conn))
                    {
                        nextRentId = Convert.ToInt32(maxCmd.ExecuteScalar());
                    }
                }

                string transactionQuery = @"UPDATE Movies SET Quantity = Quantity - 1 WHERE MovieID = @MovieID;
            
                                            INSERT INTO Rental (RentID, CID, EID, CheckoutDate, [Status], ReturnDate) 
                                            VALUES (@RentID, @CID, 0, GETDATE(), 'In-use', DATEADD(day, 7, GETDATE()));
            
                                            INSERT INTO Rented (MovieID, RentID) VALUES (@MovieID, @RentID);
            
                                            DELETE FROM Watchlist WHERE CID = @CID AND MovieID = @MovieID;";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MovieID", movieId),
                    new SqlParameter("@RentID", nextRentId),
                    new SqlParameter("@CID", currentCustomerId)
                };

                ExecuteNonQueryLoader(transactionQuery, parameters);

                MessageBox.Show($"Enjoy watching {title}! Your checkout transaction is complete.", "Rental Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                watchlistSelectedMovieId = "";
                watchlistSelectedMovieTitle = "";
                RefreshWatchlistGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rental pipeline processing aborted: " + ex.Message, "Transaction Crash Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddToQueue(string movieId, string title)
        {
            string queueQuery = @"INSERT INTO Queue (CID, MovieID, Queueorder) 
                                VALUES (@CID, @MovieID, (SELECT ISNULL(MAX(Queueorder), 0) + 1 FROM Queue WHERE CID = @CID));

                                DELETE FROM Watchlist WHERE CID = @CID AND MovieID = @MovieID;";

            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@CID", currentCustomerId),
                new SqlParameter("@MovieID", movieId)
            };

            int rowsAffected = ExecuteNonQueryLoader(queueQuery, paras);

            if (rowsAffected >= 0)
            {
                MessageBox.Show($"'{title}' has been added seamlessly to your Queue hold position!", "Queue Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void onHoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(panelOnHold);
            string query = @"SELECT M.Title, M.Genre, Q.Queueorder 
                             FROM Queue Q 
                             JOIN Movies M ON Q.MovieID = M.MovieID 
                             WHERE Q.CID = @CID 
                             ORDER BY Q.Queueorder ASC;";
            ExecuteGridLoader(query, dgvOnHold, new SqlParameter("@CID", currentCustomerId));
        }

        private void pendingRentalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(panelPending);
            string query = @"SELECT R.RentID, M.Title, R.CheckoutDate, R.[Status]
                             FROM Rental R
                             JOIN Rented RD ON R.RentID = RD.RentID
                             JOIN Movies M ON RD.MovieID = M.MovieID
                             WHERE R.CID = @CID AND R.[Status] <> 'Returned';";
        }

        private void accountInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(panelAccount);
            SetProfileFieldsReadOnly(false);
            isEditingProfile = false;
            btnEditSave.Text = "Edit Profile";
            LoadCustomerProfile();
        }

        private void LoadCustomerProfile()
        {
            string query = "SELECT FName, LName, Email, PhoneNum, [Address], City, Province, PostalCode FROM Customer WHERE CID = @CID;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CID", currentCustomerId);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtFirstName.TextButton = reader["FName"].ToString();
                                txtLastName.TextButton = reader["LName"].ToString();
                                txtEmail.TextButton = reader["Email"].ToString();
                                txtPhone.TextButton = reader["PhoneNum"].ToString();
                                txtAddress.TextButton = reader["Address"].ToString();
                                txtCity.TextButton = reader["City"].ToString();
                                txtProvince.TextButton = reader["Province"].ToString();
                                txtPostalCode.TextButton = reader["PostalCode"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error displaying profile data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (!isEditingProfile)
            {
                SetProfileFieldsReadOnly(true);
                isEditingProfile = true;
                btnEditSave.TextButton = "Save Changes";
            }
            else
            {
                string query = @"UPDATE Customer 
                                 SET FName = @FName, LName = @LName, PhoneNum = @Phone, 
                                     [Address] = @Address, City = @City, Province = @Prov, PostalCode = @Post
                                 WHERE CID = @CID;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FName", txtFirstName.TextButton.Trim());
                        cmd.Parameters.AddWithValue("@LName", txtLastName.TextButton.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.TextButton.Trim());
                        cmd.Parameters.AddWithValue("@Address", txtAddress.TextButton.Trim());
                        cmd.Parameters.AddWithValue("@City", txtCity.TextButton.Trim());
                        cmd.Parameters.AddWithValue("@Prov", txtProvince.TextButton.Trim());
                        cmd.Parameters.AddWithValue("@Post", txtPostalCode.TextButton.Trim());
                        cmd.Parameters.AddWithValue("@CID", currentCustomerId);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            SetProfileFieldsReadOnly(false);
                            isEditingProfile = false;
                            btnEditSave.TextButton = "Edit Profile";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to save updates: " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void SetProfileFieldsReadOnly(bool value)
        {
            txtFirstName.Enabled = value;
            txtLastName.Enabled = value;
            txtPhone.Enabled = value;
            txtAddress.Enabled = value;
            txtCity.Enabled = value;
            txtProvince.Enabled = value;
            txtPostalCode.Enabled = value;
            txtEmail.Enabled = false;
        }

        private void LoadCustomerName()
        {
            string query = "SELECT FName FROM Customer WHERE CID = @CID;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CID", currentCustomerId);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblWelcome.Text += reader["FName"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error displaying customer name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void rentalsCurrentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(panelRentalRecords);
            LoadRentalRecords(true);
        }

        private void rentalsPastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(panelRentalRecords);
            LoadRentalRecords(false);
        }
        private void LoadRentalRecords(bool showCurrentOnly)
        {
            string query = "";
            SqlParameter param = new SqlParameter("@CID", currentCustomerId);

            if (showCurrentOnly)
            {
                query = @"SELECT M.Title, M.Genre, R.CheckoutDate, R.[Status]
                 FROM Rental R
                 JOIN Rented RD ON R.RentID = RD.RentID
                 JOIN Movies M ON RD.MovieID = M.MovieID
                 WHERE R.CID = @CID AND R.[Status] <> 'Returned'
                 ORDER BY R.CheckoutDate DESC;";
            }
            else
            {
                query = @"SELECT M.Title, M.Genre, R.CheckoutDate, R.ReturnDate, R.[Status]
                 FROM Rental R
                 JOIN Rented RD ON R.RentID = RD.RentID
                 JOIN Movies M ON RD.MovieID = M.MovieID
                 WHERE R.CID = @CID AND R.[Status] = 'Returned'
                 ORDER BY R.ReturnDate DESC;";
            }

            ExecuteGridLoader(query, dgvRentalRecords, param);

            dgvRentalRecords.ReadOnly = true;
            dgvRentalRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dgvRentalRecords.Columns["RentID"] != null) dgvRentalRecords.Columns["RentID"].HeaderText = "Rental ID";
            if (dgvRentalRecords.Columns["CheckoutDate"] != null) dgvRentalRecords.Columns["CheckoutDate"].HeaderText = "Checkout Date";

            if (dgvRentalRecords.Columns["ReturnDate"] != null)
            {
                dgvRentalRecords.Columns["ReturnDate"].HeaderText = "Date Returned";
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel(panelWelcome);
            LoadRentalRecords(false);
        }

        private void airButton1_Click(object sender, EventArgs e)
        {
            Main.load_login();
        }
    }
}