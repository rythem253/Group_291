namespace Project
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            lblEmail = new ReaLTaiizor.Controls.SkyLabel();
            lblMessage = new ReaLTaiizor.Controls.CrownLabel();
            picEmp = new PictureBox();
            btnSubmit = new ReaLTaiizor.Controls.Button();
            inputTxt = new ReaLTaiizor.Controls.CrownTextBox();
            btnBack = new ReaLTaiizor.Controls.AirButton();
            ((System.ComponentModel.ISupportInitialize)picEmp).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Verdana", 15F, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(278, 331);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(108, 36);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Transparent;
            lblMessage.Location = new Point(310, 265);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(372, 32);
            lblMessage.TabIndex = 14;
            lblMessage.Text = "Welcome Back, Team Member !";
            // 
            // picEmp
            // 
            picEmp.BackColor = Color.Transparent;
            picEmp.Image = (Image)resources.GetObject("picEmp.Image");
            picEmp.Location = new Point(404, 99);
            picEmp.Margin = new Padding(4);
            picEmp.Name = "picEmp";
            picEmp.Size = new Size(188, 146);
            picEmp.TabIndex = 15;
            picEmp.TabStop = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.BorderColor = Color.White;
            btnSubmit.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSubmit.EnteredColor = Color.White;
            btnSubmit.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Image = null;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.InactiveColor = Color.FromArgb(32, 34, 37);
            btnSubmit.Location = new Point(404, 401);
            btnSubmit.Margin = new Padding(6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSubmit.PressedColor = Color.FromArgb(165, 37, 37);
            btnSubmit.Size = new Size(188, 62);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.TextAlignment = StringAlignment.Center;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // inputTxt
            // 
            inputTxt.BackColor = Color.FromArgb(69, 73, 74);
            inputTxt.BorderStyle = BorderStyle.FixedSingle;
            inputTxt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputTxt.ForeColor = Color.Silver;
            inputTxt.Location = new Point(404, 332);
            inputTxt.Margin = new Padding(4);
            inputTxt.Name = "inputTxt";
            inputTxt.Size = new Size(290, 35);
            inputTxt.TabIndex = 12;
            inputTxt.TextChanged += inputTxt_TextChanged;
            // 
            // btnBack
            // 
            btnBack.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            btnBack.Font = new Font("Segoe UI", 9F);
            btnBack.Image = null;
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.NoRounding = false;
            btnBack.Size = new Size(117, 36);
            btnBack.TabIndex = 22;
            btnBack.Text = "Back";
            btnBack.Transparent = false;
            btnBack.Click += btnBack_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 589);
            Controls.Add(btnBack);
            Controls.Add(lblEmail);
            Controls.Add(lblMessage);
            Controls.Add(picEmp);
            Controls.Add(btnSubmit);
            Controls.Add(inputTxt);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MinimumSize = new Size(158, 62);
            Name = "Employee";
            Text = " ";
            TransparencyKey = Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)picEmp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.SkyLabel lblEmail;
        private ReaLTaiizor.Controls.CrownLabel lblMessage;
        private PictureBox picEmp;
        private ReaLTaiizor.Controls.Button btnSubmit;
        private ReaLTaiizor.Controls.CrownTextBox inputTxt;
        private ReaLTaiizor.Controls.AirButton btnBack;
    }
}