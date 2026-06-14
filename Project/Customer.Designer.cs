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
            btnBack = new ReaLTaiizor.Controls.AirButton();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            SuspendLayout();
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.BackColor = Color.Transparent;
            lblMail.Font = new Font("Verdana", 15F, FontStyle.Bold);
            lblMail.ForeColor = Color.White;
            lblMail.Location = new Point(305, 316);
            lblMail.Margin = new Padding(4, 0, 4, 0);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(108, 36);
            lblMail.TabIndex = 18;
            lblMail.Text = "Email";
            // 
            // crownLabel1
            // 
            crownLabel1.AutoSize = true;
            crownLabel1.BackColor = Color.Transparent;
            crownLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crownLabel1.ForeColor = Color.Transparent;
            crownLabel1.Location = new Point(340, 251);
            crownLabel1.Margin = new Padding(4, 0, 4, 0);
            crownLabel1.Name = "crownLabel1";
            crownLabel1.Size = new Size(0, 32);
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
            submitBtn.Location = new Point(440, 415);
            submitBtn.Margin = new Padding(6);
            submitBtn.Name = "submitBtn";
            submitBtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            submitBtn.PressedColor = Color.FromArgb(165, 37, 37);
            submitBtn.Size = new Size(188, 62);
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
            inputTxtCust.Location = new Point(440, 324);
            inputTxtCust.Margin = new Padding(4);
            inputTxtCust.Name = "inputTxtCust";
            inputTxtCust.Size = new Size(290, 35);
            inputTxtCust.TabIndex = 12;
            inputTxtCust.TextChanged += inputTxtCust_TextChanged;
            // 
            // picUser
            // 
            picUser.BackColor = Color.Transparent;
            picUser.Image = (Image)resources.GetObject("picUser.Image");
            picUser.Location = new Point(440, 79);
            picUser.Margin = new Padding(4);
            picUser.Name = "picUser";
            picUser.Size = new Size(194, 208);
            picUser.TabIndex = 20;
            picUser.TabStop = false;
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
            btnBack.TabIndex = 21;
            btnBack.Text = "Back";
            btnBack.Transparent = false;
            btnBack.Click += btnBack_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1078, 615);
            Controls.Add(btnBack);
            Controls.Add(picUser);
            Controls.Add(lblMail);
            Controls.Add(crownLabel1);
            Controls.Add(submitBtn);
            Controls.Add(inputTxtCust);
            ForeColor = Color.OrangeRed;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            MinimumSize = new Size(158, 62);
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
        private ReaLTaiizor.Controls.AirButton btnBack;
    }
}