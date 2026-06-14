namespace Project
{
    partial class ManageRentals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRentals));
            comboBox1 = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            addBtn = new ReaLTaiizor.Controls.AirButton();
            panel1 = new Panel();
            Searchbar = new TextBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            AscBut = new Button();
            DescBut = new Button();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Returned", "In-use", "Late" });
            comboBox1.Location = new Point(77, 128);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(93, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 119);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 1;
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(77, 155);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(565, 166);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel1.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel1.Location = new Point(262, 16);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(183, 23);
            skyLabel1.TabIndex = 3;
            skyLabel1.Text = "Manage Rentals";
            skyLabel1.Click += skyLabel1_Click;
            // 
            // addBtn
            // 
            addBtn.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            addBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Image = null;
            addBtn.Location = new Point(522, 77);
            addBtn.Margin = new Padding(3, 2, 3, 2);
            addBtn.Name = "addBtn";
            addBtn.NoRounding = false;
            addBtn.Size = new Size(120, 36);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add New Rental";
            addBtn.Transparent = false;
            addBtn.Click += addBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaShell;
            panel1.Controls.Add(Searchbar);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(77, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 23);
            panel1.TabIndex = 7;
            // 
            // Searchbar
            // 
            Searchbar.Location = new Point(22, 0);
            Searchbar.Name = "Searchbar";
            Searchbar.Size = new Size(216, 23);
            Searchbar.TabIndex = 8;
            Searchbar.TextChanged += Searchbar_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 23);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 111);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 8;
            label2.Text = "Filter:";
            // 
            // AscBut
            // 
            AscBut.FlatAppearance.BorderSize = 0;
            AscBut.Location = new Point(217, 132);
            AscBut.Name = "AscBut";
            AscBut.Size = new Size(12, 12);
            AscBut.TabIndex = 9;
            AscBut.UseVisualStyleBackColor = true;
            AscBut.Click += AscBut_Click;
            // 
            // DescBut
            // 
            DescBut.FlatAppearance.BorderSize = 0;
            DescBut.Location = new Point(260, 132);
            DescBut.Name = "DescBut";
            DescBut.Size = new Size(12, 12);
            DescBut.TabIndex = 10;
            DescBut.UseVisualStyleBackColor = true;
            DescBut.Click += DescBut_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(200, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(12, 12);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(243, 131);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(12, 12);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(200, 113);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 13;
            label3.Text = "Date Order";
            label3.Click += label3_Click_1;
            // 
            // ManageRentals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(700, 338);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(DescBut);
            Controls.Add(AscBut);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(addBtn);
            Controls.Add(skyLabel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageRentals";
            Text = "ManageRentals";
            Load += ManageRentals_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private ReaLTaiizor.Controls.AirButton addBtn;
        private Panel panel1;
        private PictureBox pictureBox2;
        private TextBox Searchbar;
        private Label label2;
        private Button AscBut;
        private Button DescBut;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label3;
    }
}