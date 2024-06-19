namespace Timers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDateTime();
        }

        private void DisplayDateTime()
        {
            DateTime today = DateTime.Now;
            lblDay.Text = today.ToLongDateString();
            lblTime.Text = today.ToLongTimeString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime partyDate = dateTimePicker1.Value.Date;
            lblMessage.Text = $"The party is on {partyDate.ToLongDateString()}";
            DateTime today = DateTime.Today;
            TimeSpan diff = partyDate.Subtract(today);
            int days = diff.Days;
            if (days < 0) lblMessage.Text = $"It was {-days} day(s) ago. Sorry you missed it.";
            lblMessage.Text += $"\n{days} more sleep(s)";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            DateTime today = DateTime.Now;
            lblTime.Text = today.ToLongTimeString();
        }
    }
}
