namespace Project
{
    partial class AddNewRental
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
            eidTxt = new TextBox();
            checkoutTxt = new TextBox();
            movieNameTxt = new TextBox();
            cidTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label6 = new Label();
            submitBtn = new ReaLTaiizor.Controls.AirButton();
            label7 = new Label();
            SuspendLayout();
            // 
            // eidTxt
            // 
            eidTxt.Location = new Point(413, 87);
            eidTxt.Name = "eidTxt";
            eidTxt.Size = new Size(125, 27);
            eidTxt.TabIndex = 0;
            // 
            // checkoutTxt
            // 
            checkoutTxt.Location = new Point(413, 253);
            checkoutTxt.Name = "checkoutTxt";
            checkoutTxt.Size = new Size(125, 27);
            checkoutTxt.TabIndex = 1;
            // 
            // movieNameTxt
            // 
            movieNameTxt.Location = new Point(413, 197);
            movieNameTxt.Name = "movieNameTxt";
            movieNameTxt.Size = new Size(125, 27);
            movieNameTxt.TabIndex = 2;
            // 
            // cidTxt
            // 
            cidTxt.Location = new Point(413, 143);
            cidTxt.Name = "cidTxt";
            cidTxt.Size = new Size(125, 27);
            cidTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 19);
            label1.Name = "label1";
            label1.Size = new Size(307, 35);
            label1.TabIndex = 4;
            label1.Text = "Create New Rental:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 86);
            label2.Name = "label2";
            label2.Size = new Size(45, 28);
            label2.TabIndex = 5;
            label2.Text = "EID:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(266, 143);
            label3.Name = "label3";
            label3.Size = new Size(47, 28);
            label3.TabIndex = 6;
            label3.Text = "CID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(266, 196);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 7;
            label4.Text = "Movie Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(268, 249);
            label5.Name = "label5";
            label5.Size = new Size(144, 28);
            label5.TabIndex = 8;
            label5.Text = "Checkout Date:";
            label5.Click += label5_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(255, 315);
            label6.Name = "label6";
            label6.Size = new Size(184, 28);
            label6.TabIndex = 9;
            label6.Text = "Return Date Will Be:";
            // 
            // submitBtn
            // 
            submitBtn.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            submitBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitBtn.Image = null;
            submitBtn.Location = new Point(308, 365);
            submitBtn.Name = "submitBtn";
            submitBtn.NoRounding = false;
            submitBtn.Size = new Size(175, 56);
            submitBtn.TabIndex = 10;
            submitBtn.Text = "Submit Request";
            submitBtn.Transparent = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(445, 315);
            label7.Name = "label7";
            label7.Size = new Size(117, 28);
            label7.TabIndex = 11;
            label7.Text = "PlaceHolder";
            // 
            // AddNewRental
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(submitBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cidTxt);
            Controls.Add(movieNameTxt);
            Controls.Add(checkoutTxt);
            Controls.Add(eidTxt);
            Name = "AddNewRental";
            Text = "AddNewRental";
            Load += AddNewRental_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox eidTxt;
        private TextBox checkoutTxt;
        private TextBox movieNameTxt;
        private TextBox cidTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label6;
        private ReaLTaiizor.Controls.AirButton submitBtn;
        private Label label7;
    }
}