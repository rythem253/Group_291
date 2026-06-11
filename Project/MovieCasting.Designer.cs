namespace Project
{
    partial class MovieCasting
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
            dgvLoadCasting = new DataGridView();
            skyLabel1 = new ReaLTaiizor.Controls.SkyLabel();
            filterTxt = new TextBox();
            label1 = new Label();
            filterBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLoadCasting).BeginInit();
            SuspendLayout();
            // 
            // dgvLoadCasting
            // 
            dgvLoadCasting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoadCasting.Location = new Point(250, 156);
            dgvLoadCasting.Name = "dgvLoadCasting";
            dgvLoadCasting.RowHeadersWidth = 51;
            dgvLoadCasting.Size = new Size(311, 282);
            dgvLoadCasting.TabIndex = 0;
            dgvLoadCasting.CellContentClick += dataGridView1_CellContentClick;
            // 
            // skyLabel1
            // 
            skyLabel1.AutoSize = true;
            skyLabel1.Font = new Font("Verdana", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            skyLabel1.ForeColor = Color.FromArgb(27, 94, 137);
            skyLabel1.Location = new Point(250, 53);
            skyLabel1.Name = "skyLabel1";
            skyLabel1.Size = new Size(311, 45);
            skyLabel1.TabIndex = 2;
            skyLabel1.Text = "Movie Casting";
            // 
            // filterTxt
            // 
            filterTxt.Location = new Point(417, 114);
            filterTxt.Name = "filterTxt";
            filterTxt.Size = new Size(125, 27);
            filterTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(264, 113);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 4;
            label1.Text = "Filter by Movie:";
            // 
            // filterBtn
            // 
            filterBtn.BackColor = Color.Chocolate;
            filterBtn.Location = new Point(584, 113);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(52, 29);
            filterBtn.TabIndex = 5;
            filterBtn.Text = "Filter";
            filterBtn.UseVisualStyleBackColor = false;
            filterBtn.Click += filterBtn_Click;
            // 
            // MovieCasting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(filterBtn);
            Controls.Add(label1);
            Controls.Add(filterTxt);
            Controls.Add(skyLabel1);
            Controls.Add(dgvLoadCasting);
            Name = "MovieCasting";
            Text = "MovieCasting";
            ((System.ComponentModel.ISupportInitialize)dgvLoadCasting).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLoadCasting;
        private ReaLTaiizor.Controls.SkyLabel skyLabel1;
        private TextBox filterTxt;
        private Label label1;
        private Button filterBtn;
    }
}