using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Main : Form
    {
        public static Panel? mainPanel = null;
        private static Form1? login = null;
        public Main()
        {
            InitializeComponent();
            mainPanel = panView;

            login = new Form1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panView.Controls.Add(login);
            login.Show();
        }
    }
}
