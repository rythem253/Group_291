namespace Project
{
    partial class employeePortal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnManageCustomer = new ReaLTaiizor.Controls.Button();
            btnMovieCasting = new ReaLTaiizor.Controls.Button();
            btnRentals = new ReaLTaiizor.Controls.Button();
            btnLogout = new ReaLTaiizor.Controls.AirButton();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            imageList1 = new ImageList(components);
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            btnInventory = new ReaLTaiizor.Controls.Button();
            SuspendLayout();
            // 
            // btnManageCustomer
            // 
            btnManageCustomer.BackColor = Color.Transparent;
            btnManageCustomer.BorderColor = Color.FromArgb(32, 34, 37);
            btnManageCustomer.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnManageCustomer.EnteredColor = Color.FromArgb(32, 34, 37);
            btnManageCustomer.Font = new Font("Microsoft Sans Serif", 12F);
            btnManageCustomer.Image = null;
            btnManageCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageCustomer.InactiveColor = SystemColors.ControlDarkDark;
            btnManageCustomer.Location = new Point(315, 159);
            btnManageCustomer.Name = "btnManageCustomer";
            btnManageCustomer.PressedBorderColor = Color.Black;
            btnManageCustomer.PressedColor = Color.FromArgb(165, 37, 37);
            btnManageCustomer.Size = new Size(230, 50);
            btnManageCustomer.TabIndex = 0;
            btnManageCustomer.Text = "Manage Customers";
            btnManageCustomer.TextAlignment = StringAlignment.Center;
            btnManageCustomer.Click += btnManageCustomer_Click;
            // 
            // btnMovieCasting
            // 
            btnMovieCasting.BackColor = Color.Transparent;
            btnMovieCasting.BorderColor = Color.Black;
            btnMovieCasting.EnteredBorderColor = Color.Black;
            btnMovieCasting.EnteredColor = Color.DarkGray;
            btnMovieCasting.Font = new Font("Microsoft Sans Serif", 12F);
            btnMovieCasting.Image = null;
            btnMovieCasting.ImageAlign = ContentAlignment.MiddleLeft;
            btnMovieCasting.InactiveColor = SystemColors.ControlDarkDark;
            btnMovieCasting.Location = new Point(315, 230);
            btnMovieCasting.Name = "btnMovieCasting";
            btnMovieCasting.PressedBorderColor = Color.Black;
            btnMovieCasting.PressedColor = Color.FromArgb(165, 37, 37);
            btnMovieCasting.Size = new Size(230, 50);
            btnMovieCasting.TabIndex = 2;
            btnMovieCasting.Text = "Movie Casting";
            btnMovieCasting.TextAlignment = StringAlignment.Center;
            btnMovieCasting.Click += btnMovieCasting_Click;
            // 
            // btnRentals
            // 
            btnRentals.BackColor = Color.Transparent;
            btnRentals.BorderColor = Color.FromArgb(32, 34, 37);
            btnRentals.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnRentals.EnteredColor = Color.FromArgb(32, 34, 37);
            btnRentals.Font = new Font("Microsoft Sans Serif", 12F);
            btnRentals.Image = null;
            btnRentals.ImageAlign = ContentAlignment.MiddleLeft;
            btnRentals.InactiveColor = SystemColors.ControlDarkDark;
            btnRentals.Location = new Point(315, 371);
            btnRentals.Name = "btnRentals";
            btnRentals.PressedBorderColor = Color.Black;
            btnRentals.PressedColor = Color.FromArgb(165, 37, 37);
            btnRentals.Size = new Size(230, 50);
            btnRentals.TabIndex = 3;
            btnRentals.Text = "Manage Rentals";
            btnRentals.TextAlignment = StringAlignment.Center;
            btnRentals.Click += btnRentals_Click;
            // 
            // btnLogout
            // 
            btnLogout.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnLogout.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Image = null;
            btnLogout.Location = new Point(366, 458);
            btnLogout.Name = "btnLogout";
            btnLogout.NoRounding = false;
            btnLogout.Size = new Size(125, 56);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.Transparent = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Showcard Gothic", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(315, 89);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(230, 52);
            bigLabel1.TabIndex = 7;
            bigLabel1.Text = "Controls";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel1.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel1.Location = new Point(295, 9);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(275, 34);
            skyLabel1.TabIndex = 8;
            skyLabel1.Text = "Employee Portal";
            skyLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.Transparent;
            btnInventory.BorderColor = Color.FromArgb(32, 34, 37);
            btnInventory.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnInventory.EnteredColor = Color.FromArgb(32, 34, 37);
            btnInventory.Font = new Font("Microsoft Sans Serif", 12F);
            btnInventory.Image = null;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.InactiveColor = SystemColors.ControlDarkDark;
            btnInventory.Location = new Point(315, 299);
            btnInventory.Name = "btnInventory";
            btnInventory.PressedBorderColor = Color.Black;
            btnInventory.PressedColor = Color.FromArgb(165, 37, 37);
            btnInventory.Size = new Size(230, 50);
            btnInventory.TabIndex = 1;
            btnInventory.Text = "Manage Movie Inventory";
            btnInventory.TextAlignment = StringAlignment.Center;
            btnInventory.Click += button2_Click;
            // 
            // employeePortal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(877, 556);
            Controls.Add(skyLabel1);
            Controls.Add(bigLabel1);
            Controls.Add(btnLogout);
            Controls.Add(btnRentals);
            Controls.Add(btnMovieCasting);
            Controls.Add(btnInventory);
            Controls.Add(btnManageCustomer);
            Name = "employeePortal";
            Text = "employeePortal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.Button btnManageCustomer;
        private ReaLTaiizor.Controls.Button btnMovieCasting;
        private ReaLTaiizor.Controls.Button btnRentals;
        private ReaLTaiizor.Controls.AirButton btnLogout;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.Button btnInventory;
    }
}