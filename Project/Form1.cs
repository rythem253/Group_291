namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SelectionScreen_Click(object sender, EventArgs e)
        {

        }

        private void customerSelection_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Customer customerForm = new Customer();
            customerForm.Show();
            this.Hide();
        }

        private void lblSelect_Click(object sender, EventArgs e)
        {

        }

        private void empSelection_Click(object sender, EventArgs e)
        {
            // Create an instance of the second form
            Employee employeeForm = new Employee();
            employeeForm.Show();
            this.Hide();
        }
    }
}
