namespace Project
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            lblMail = new ReaLTaiizor.Controls.SkyLabel();
            crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
            submitBtn = new ReaLTaiizor.Controls.Button();
            inputTxtCust = new ReaLTaiizor.Controls.CrownTextBox();
            picUser = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            SuspendLayout();
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.BackColor = Color.Transparent;
            lblMail.Font = new Font("Verdana", 15F, FontStyle.Bold);
            lblMail.ForeColor = Color.White;
            lblMail.Location = new Point(244, 253);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(92, 31);
            lblMail.TabIndex = 18;
            lblMail.Text = "Email";
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.BackColor = Color.Transparent;
            crownLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crownLabel1.ForeColor = Color.Transparent;
            crownLabel1.Location = new Point(272, 201);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(0, 28);
            crownLabel1.TabIndex = 14;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.Transparent;
            submitBtn.BorderColor = Color.White;
            submitBtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            submitBtn.EnteredColor = Color.White;
            submitBtn.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submitBtn.Image = null;
            submitBtn.ImageAlign = ContentAlignment.MiddleLeft;
            submitBtn.InactiveColor = Color.FromArgb(32, 34, 37);
            submitBtn.Location = new Point(352, 332);
            submitBtn.Margin = new Padding(5);
            submitBtn.Name = "submitBtn";
            submitBtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            submitBtn.PressedColor = Color.FromArgb(165, 37, 37);
            submitBtn.Size = new Size(150, 50);
            submitBtn.TabIndex = 13;
            submitBtn.Text = "Submit";
            submitBtn.TextAlignment = StringAlignment.Center;
            submitBtn.Click += submitBtn_Click;
            // 
            // inputTxtCust
            // 
            inputTxtCust.BackColor = Color.FromArgb(69, 73, 74);
            inputTxtCust.BorderStyle = BorderStyle.FixedSingle;
            inputTxtCust.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputTxtCust.ForeColor = Color.Silver;
            inputTxtCust.Location = new Point(352, 259);
            inputTxtCust.Name = "inputTxtCust";
            inputTxtCust.Size = new Size(232, 30);
            inputTxtCust.TabIndex = 12;
            // 
            // picUser
            // 
            picUser.BackColor = Color.Transparent;
            picUser.Image = (Image)resources.GetObject("picUser.Image");
            picUser.Location = new Point(352, 63);
            picUser.Name = "picUser";
            picUser.Size = new Size(155, 166);
            picUser.TabIndex = 20;
            picUser.TabStop = false;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(862, 492);
            Controls.Add(picUser);
            Controls.Add(lblMail);
            Controls.Add(crownLabel1);
            Controls.Add(submitBtn);
            Controls.Add(inputTxtCust);
            ForeColor = Color.OrangeRed;
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(126, 50);
            Name = "Customer";
            TransparencyKey = Color.Fuchsia;
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.SkyLabel lblMail;
        private ReaLTaiizor.Controls.CrownLabel crownLabel1;
        private ReaLTaiizor.Controls.Button submitBtn;
        private ReaLTaiizor.Controls.CrownTextBox inputTxtCust;
        private PictureBox picUser;
    }
}