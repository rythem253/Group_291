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
            ((System.ComponentModel.ISupportInitialize)picEmp).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Verdana", 15F, FontStyle.Bold);
            lblEmail.ForeColor = Color.White;
            lblEmail.Location = new Point(222, 265);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(92, 31);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.Transparent;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Transparent;
            lblMessage.Location = new Point(248, 212);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(310, 28);
            lblMessage.TabIndex = 14;
            lblMessage.Text = "Welcome Back, Team Member !";
            // 
            // picEmp
            // 
            picEmp.BackColor = Color.Transparent;
            picEmp.Image = (Image)resources.GetObject("picEmp.Image");
            picEmp.Location = new Point(323, 79);
            picEmp.Name = "picEmp";
            picEmp.Size = new Size(150, 117);
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
            btnSubmit.Location = new Point(323, 321);
            btnSubmit.Margin = new Padding(5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSubmit.PressedColor = Color.FromArgb(165, 37, 37);
            btnSubmit.Size = new Size(150, 50);
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
            inputTxt.Location = new Point(323, 266);
            inputTxt.Name = "inputTxt";
            inputTxt.Size = new Size(232, 30);
            inputTxt.TabIndex = 12;
            inputTxt.TextChanged += inputTxt_TextChanged;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 471);
            Controls.Add(lblEmail);
            Controls.Add(lblMessage);
            Controls.Add(picEmp);
            Controls.Add(btnSubmit);
            Controls.Add(inputTxt);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(126, 50);
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
    }
}