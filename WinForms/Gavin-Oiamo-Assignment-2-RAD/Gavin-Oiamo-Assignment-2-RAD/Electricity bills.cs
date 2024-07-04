using Transaction_Class;
using CustomerData;
using System.Diagnostics;
using System.Transactions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Gavin_Oiamo_Assignment_2_RAD
{
    public partial class Form1 : Form
    {
        // variables
        public List<Customer> customers = new List<Customer>();
        int accountNum = 12345;

        public Form1()
        {
            InitializeComponent();
        }

        // clears inputs
        private void resetInputs()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtKwh.Text = "";
        }

        // open statistics dialog when statistics button is clicked
        private void btnStats_Click(object sender, EventArgs e)
        {
            // pass customers into constructor function
            Form statistics = new Statistics(customers);
            statistics.ShowDialog();
        }

        // close form when btn exit is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // reset inputs when reset button is clicked
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetInputs();
        }

        // only allow charactors and backspace on keypress
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        // only allow charactors and backspace on keypress
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        // only allow digits and backspace on keypress
        private void txtKwh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        // when user clicks submit button, check if user exists. if they do, add transaction to that account else create new account and add transaction
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // veryify that inputs are not empty and get kwh
                List<TextBox> textboxes = new List<TextBox>() { txtFirstName, txtLastName, txtKwh };
                if (textboxes.Any(textbox => textbox.Text == "")) throw new Exception("input(s) cannot be empty");
                int kwh = int.Parse(txtKwh.Text);

                // check to see if customer exists. if not create customer, add transaction and add customer to customers list.
                // else add transaction to customer.
                if (!customers.Exists(customer => customer.FirstName == txtFirstName.Text &&
                customer.LastName == txtLastName.Text))
                {
                    Customer cust = new Customer(txtFirstName.Text, txtLastName.Text, accountNum);
                    customers.Add(cust);

                    accountNum++;

                    addTransaction(kwh, cust);
                }
                else
                {
                    Customer? cust = customers.Find(customer => customer.FirstName == txtFirstName.Text &&
                    customer.LastName == txtLastName.Text);

                    addTransaction(kwh, cust);
                }

                // reset inputs and focus on firstname textbox
                resetInputs();
                txtFirstName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // creates and adds a transaction to customer
        static public void addTransaction(int kwh, Customer customer)
        {
            try
            {
                // create transaction
                decimal chargeCalculated = Customer.CalculateCharge(kwh);
                if (chargeCalculated == -1) throw new Exception("Value is too low");

                Transaction_Class.Transaction transaction = new Transaction_Class.Transaction(kwh, Customer.CalculateCharge(kwh));

                // add transaction
                customer.transactions.Add(transaction);

                // add kwh and transaction cost to customer totals
                customer.kwhUsed += kwh;
                customer.elecBill += transaction.transactionCost;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
