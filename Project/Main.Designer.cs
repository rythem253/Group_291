namespace Project
{
    partial class Main
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
            panView = new Panel();
            SuspendLayout();
            // 
            // panView
            // 
            panView.Dock = DockStyle.Fill;
            panView.Location = new Point(0, 0);
            panView.Name = "panView";
            panView.Size = new Size(1022, 695);
            panView.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 695);
            Controls.Add(panView);
            Name = "Main";
            Text = "Login Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Panel panView;
    }
}