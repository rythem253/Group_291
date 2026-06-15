
namespace Project
{
    partial class ReturnRental
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
            label1 = new Label();
            label2 = new Label();
            ConBut = new Button();
            CanBut = new Button();
            RSearch = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 43);
            label1.Name = "label1";
            label1.Size = new Size(190, 29);
            label1.TabIndex = 5;
            label1.Text = "Return Rental";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(232, 123);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 6;
            label2.Text = "RentID";
            label2.Click += label2_Click;
            // 
            // ConBut
            // 
            ConBut.Location = new Point(410, 176);
            ConBut.Name = "ConBut";
            ConBut.Size = new Size(75, 23);
            ConBut.TabIndex = 8;
            ConBut.Text = "Confirm";
            ConBut.UseVisualStyleBackColor = true;
            ConBut.Click += ConBut_Click;
            // 
            // CanBut
            // 
            CanBut.Location = new Point(295, 176);
            CanBut.Name = "CanBut";
            CanBut.Size = new Size(75, 23);
            CanBut.TabIndex = 9;
            CanBut.Text = "Cancel";
            CanBut.UseVisualStyleBackColor = true;
            CanBut.Click += CanBut_Click;
            // 
            // RSearch
            // 
            RSearch.Location = new Point(295, 123);
            RSearch.Name = "RSearch";
            RSearch.Size = new Size(190, 23);
            RSearch.TabIndex = 10;
            // 
            // ReturnRental
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(RSearch);
            Controls.Add(CanBut);
            Controls.Add(ConBut);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReturnRental";
            Text = "Form2";
            Load += ReturnRental_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button ConBut;
        private Button CanBut;
        private TextBox RSearch;
    }
}