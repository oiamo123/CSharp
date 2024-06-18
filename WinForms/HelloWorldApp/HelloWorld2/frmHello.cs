namespace HelloWorld2
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = $"Hello {txtName.Text}";
            // Template literal
            // lblGreeting.Text = "Hello " + lblGreeting.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello World";
            txtName.Clear();
            // txtName.Text = ""; // erase the textbox
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Terminate the execution
        }
    }
}
