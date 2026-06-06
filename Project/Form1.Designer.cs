namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SelectionScreen = new ReaLTaiizor.Forms.FormTheme();
            lblSelect = new ReaLTaiizor.Controls.NightHeaderLabel();
            customerSelection = new ReaLTaiizor.Controls.CyberButton();
            empSelection = new ReaLTaiizor.Controls.CyberButton();
            SelectionScreen.SuspendLayout();
            SuspendLayout();
            // 
            // SelectionScreen
            // 
            SelectionScreen.BackColor = Color.FromArgb(32, 41, 50);
            SelectionScreen.Controls.Add(lblSelect);
            SelectionScreen.Controls.Add(customerSelection);
            SelectionScreen.Controls.Add(empSelection);
            SelectionScreen.Dock = DockStyle.Fill;
            SelectionScreen.Font = new Font("Segoe UI", 8F);
            SelectionScreen.ForeColor = Color.White;
            SelectionScreen.Location = new Point(0, 0);
            SelectionScreen.Name = "SelectionScreen";
            SelectionScreen.Padding = new Padding(3, 28, 3, 28);
            SelectionScreen.Sizable = true;
            SelectionScreen.Size = new Size(800, 450);
            SelectionScreen.SmartBounds = false;
            SelectionScreen.StartPosition = FormStartPosition.WindowsDefaultLocation;
            SelectionScreen.TabIndex = 0;
            SelectionScreen.Text = " ";
            SelectionScreen.Click += SelectionScreen_Click;
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.BackColor = Color.Transparent;
            lblSelect.Font = new Font("Microsoft Sans Serif", 22F);
            lblSelect.ForeColor = Color.FromArgb(250, 250, 250);
            lblSelect.LeftSideForeColor = Color.FromArgb(250, 250, 250);
            lblSelect.Location = new Point(290, 84);
            lblSelect.Name = "lblSelect";
            lblSelect.RightSideForeColor = Color.FromArgb(170, 171, 176);
            lblSelect.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            lblSelect.Size = new Size(248, 50);
            lblSelect.TabIndex = 7;
            lblSelect.Text = "Please select:";
            lblSelect.TextAlign = ContentAlignment.MiddleCenter;
            lblSelect.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            lblSelect.UseCompatibleTextRendering = true;
            lblSelect.Click += lblSelect_Click;
            // 
            // customerSelection
            // 
            customerSelection.Alpha = 20;
            customerSelection.BackColor = Color.Transparent;
            customerSelection.Background = true;
            customerSelection.Background_WidthPen = 4F;
            customerSelection.BackgroundPen = true;
            customerSelection.ColorBackground = Color.FromArgb(37, 52, 68);
            customerSelection.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            customerSelection.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            customerSelection.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            customerSelection.ColorLighting = Color.FromArgb(29, 200, 238);
            customerSelection.ColorPen_1 = Color.FromArgb(37, 52, 68);
            customerSelection.ColorPen_2 = Color.FromArgb(41, 63, 86);
            customerSelection.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            customerSelection.Effect_1 = true;
            customerSelection.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            customerSelection.Effect_1_Transparency = 25;
            customerSelection.Effect_2 = true;
            customerSelection.Effect_2_ColorBackground = Color.White;
            customerSelection.Effect_2_Transparency = 20;
            customerSelection.Font = new Font("Arial", 11F);
            customerSelection.ForeColor = Color.FromArgb(245, 245, 245);
            customerSelection.Lighting = false;
            customerSelection.LinearGradient_Background = false;
            customerSelection.LinearGradientPen = false;
            customerSelection.Location = new Point(459, 176);
            customerSelection.Name = "customerSelection";
            customerSelection.PenWidth = 15;
            customerSelection.Rounding = true;
            customerSelection.RoundingInt = 70;
            customerSelection.Size = new Size(162, 62);
            customerSelection.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            customerSelection.TabIndex = 5;
            customerSelection.Tag = "Cyber";
            customerSelection.TextButton = "Customer";
            customerSelection.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            customerSelection.Timer_Effect_1 = 5;
            customerSelection.Timer_RGB = 300;
            customerSelection.Click += customerSelection_Click;
            // 
            // empSelection
            // 
            empSelection.Alpha = 20;
            empSelection.BackColor = Color.Transparent;
            empSelection.Background = true;
            empSelection.Background_WidthPen = 4F;
            empSelection.BackgroundPen = true;
            empSelection.ColorBackground = Color.FromArgb(37, 52, 68);
            empSelection.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            empSelection.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            empSelection.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            empSelection.ColorLighting = Color.FromArgb(29, 200, 238);
            empSelection.ColorPen_1 = Color.FromArgb(37, 52, 68);
            empSelection.ColorPen_2 = Color.FromArgb(41, 63, 86);
            empSelection.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            empSelection.Effect_1 = true;
            empSelection.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            empSelection.Effect_1_Transparency = 25;
            empSelection.Effect_2 = true;
            empSelection.Effect_2_ColorBackground = Color.White;
            empSelection.Effect_2_Transparency = 20;
            empSelection.Font = new Font("Arial", 11F);
            empSelection.ForeColor = Color.FromArgb(245, 245, 245);
            empSelection.Lighting = false;
            empSelection.LinearGradient_Background = false;
            empSelection.LinearGradientPen = false;
            empSelection.Location = new Point(201, 176);
            empSelection.Name = "empSelection";
            empSelection.PenWidth = 15;
            empSelection.Rounding = true;
            empSelection.RoundingInt = 70;
            empSelection.Size = new Size(162, 62);
            empSelection.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            empSelection.TabIndex = 4;
            empSelection.Tag = "Cyber";
            empSelection.TextButton = "Employee";
            empSelection.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            empSelection.Timer_Effect_1 = 5;
            empSelection.Timer_RGB = 300;
            empSelection.Click += empSelection_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SelectionScreen);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(126, 50);
            Name = "Form1";
            Text = " ";
            TransparencyKey = Color.Fuchsia;
            Load += Form1_Load;
            SelectionScreen.ResumeLayout(false);
            SelectionScreen.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme SelectionScreen;
        private ReaLTaiizor.Controls.CyberButton empSelection;
        private ReaLTaiizor.Controls.CyberButton customerSelection;
        private ReaLTaiizor.Controls.NightHeaderLabel lblSelect;
    }
}
