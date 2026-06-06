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
            formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            authEmailEmp = new ReaLTaiizor.Controls.FoxBigLabel();
            crownTextBox1 = new ReaLTaiizor.Controls.CrownTextBox();
            submitBtn = new ReaLTaiizor.Controls.Button();
            formTheme1.SuspendLayout();
            SuspendLayout();
            // 
            // formTheme1
            // 
            formTheme1.BackColor = Color.FromArgb(32, 41, 50);
            formTheme1.Controls.Add(submitBtn);
            formTheme1.Controls.Add(authEmailEmp);
            formTheme1.Controls.Add(crownTextBox1);
            formTheme1.Dock = DockStyle.Fill;
            formTheme1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formTheme1.ForeColor = Color.FromArgb(142, 142, 142);
            formTheme1.Location = new Point(0, 0);
            formTheme1.Name = "formTheme1";
            formTheme1.Padding = new Padding(3, 28, 3, 28);
            formTheme1.Sizable = true;
            formTheme1.Size = new Size(800, 450);
            formTheme1.SmartBounds = false;
            formTheme1.StartPosition = FormStartPosition.WindowsDefaultLocation;
            formTheme1.TabIndex = 0;
            formTheme1.Text = " ";
            formTheme1.Click += formTheme1_Click;
            // 
            // authEmailEmp
            // 
            authEmailEmp.BackColor = Color.Transparent;
            authEmailEmp.Font = new Font("Segoe UI Semibold", 20F);
            authEmailEmp.ForeColor = Color.White;
            authEmailEmp.Line = ReaLTaiizor.Controls.FoxBigLabel.Direction.Bottom;
            authEmailEmp.LineColor = Color.FromArgb(200, 200, 200);
            authEmailEmp.Location = new Point(56, 194);
            authEmailEmp.Name = "authEmailEmp";
            authEmailEmp.Size = new Size(363, 51);
            authEmailEmp.TabIndex = 1;
            authEmailEmp.Text = "Please enter your email:]";
            // 
            // crownTextBox1
            // 
            crownTextBox1.BackColor = Color.FromArgb(69, 73, 74);
            crownTextBox1.BorderStyle = BorderStyle.FixedSingle;
            crownTextBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crownTextBox1.ForeColor = Color.Silver;
            crownTextBox1.Location = new Point(439, 205);
            crownTextBox1.Name = "crownTextBox1";
            crownTextBox1.Size = new Size(232, 30);
            crownTextBox1.TabIndex = 0;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Transparent;
            submitBtn.BorderColor = Color.White;
            submitBtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            submitBtn.EnteredColor = Color.White;
            submitBtn.Font = new Font("Microsoft Sans Serif", 12F);
            submitBtn.Image = null;
            submitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            submitBtn.InactiveColor = Color.FromArgb(32, 34, 37);
            submitBtn.Location = new Point(482, 268);
            submitBtn.Name = "submitBtn";
            submitBtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            submitBtn.PressedColor = Color.FromArgb(165, 37, 37);
            submitBtn.Size = new Size(150, 50);
            submitBtn.TabIndex = 2;
            submitBtn.Text = "Submit";
            submitBtn.TextAlignment = StringAlignment.Center;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formTheme1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(126, 50);
            Name = "Employee";
            Text = " ";
            TransparencyKey = Color.Fuchsia;
            formTheme1.ResumeLayout(false);
            formTheme1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private ReaLTaiizor.Controls.CrownTextBox crownTextBox1;
        private ReaLTaiizor.Controls.FoxBigLabel authEmailEmp;
        private ReaLTaiizor.Controls.Button submitBtn;
    }
}