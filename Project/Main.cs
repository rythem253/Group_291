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

            load_login();
        }

        public static void load_login()
        {
            login = new Form1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(login);
            login.Show();
        }
    }
}
