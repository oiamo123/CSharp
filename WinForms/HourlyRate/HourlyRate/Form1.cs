namespace HourlyRate
{
    public partial class hoursWorked : Form
    {
        public hoursWorked()
        {
            InitializeComponent();
        }
        // at the start
        private void hoursWorked_Load(object sender, EventArgs e)
        {
            grbDetails.Visible = false;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            const decimal FULL_WEEK = 37.5m;
            const decimal OT_RATE = 1.5m;
            decimal hours; // hours worked
            decimal rate;  // hourly rate
            decimal pay;   // employee pay
            decimal regularPay;
            decimal overtimePay;

            // get hours and rate
            hours = Convert.ToDecimal(txtHrsWorked.Text);
            rate = Convert.ToDecimal(txtHrRate.Text);

            // calculate pay
            if (hours <= FULL_WEEK) // regular pay
            {
                regularPay = hours * rate;
                overtimePay = 0;
                pay = regularPay + overtimePay;
                grbDetails.Visible = false;
            }
            else // with overtime
            {
                regularPay = FULL_WEEK * rate;
                overtimePay = (hours - FULL_WEEK) * rate * OT_RATE; // overtime calc
                pay = regularPay + overtimePay;
                grbDetails.Visible=true;
            }

            // display pay
            txtPay.Text = pay.ToString("c"); // currency format
            txtRegularPay.Text = regularPay.ToString("c");
            txtOtPay.Text = overtimePay.ToString("c");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHrRate.Text = "";
            txtHrsWorked.Text = "";
            txtPay.Text = "";
            txtRegularPay.Text = "";
            txtOtPay.Text = "";
            grbDetails.Visible = false;
            txtHrsWorked.Focus();
        }
    }
}
