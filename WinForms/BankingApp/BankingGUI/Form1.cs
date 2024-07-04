using Banking_Classes;

namespace BankingGUI
{
    public partial class Form1 : Form
    {
        int lastIndex = 0; // to preserve account selection
        List<Account> accounts = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }

        // "hardcode" three accounts
        private void Form1_Load(object sender, EventArgs e)
        {
            accounts.Add(new Account()); // account with zero balance
            accounts.Add(new Account(500));
            accounts.Add(new Account(100));
            accounts.Add(new CheckingAccount(-100, 200));
            DisplayAccounts();
        }

        // dispay the accounts in the list box and make the  first one selected
        private void DisplayAccounts()
        {
            lastIndex = lstAccounts.SelectedIndex;
            lstAccounts.Items.Clear(); // start with empty list box
            foreach (Account account in accounts)
            {
                lstAccounts.Items.Add(account);// calls ToString() from Account class
            }
            lstAccounts.SelectedIndex = lastIndex;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // ensure account is selected
            if (lstAccounts.SelectedIndex == -1) // no selection
            {
                MessageBox.Show("you must select an account first");
                lstAccounts.Focus();
            }
            else // account is selected
            {
                Account acct = accounts[lstAccounts.SelectedIndex];
                // validate the amount
                if (Validator.IsPresent(txtAmount) &&
                    Validator.IsNonNegativeDecimal(txtAmount)
                   )
                {
                    decimal amount = Convert.ToDecimal(txtAmount.Text);
                    acct.Deposit(amount);
                    DisplayAccounts();
                }
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // ensure account is selected
            if (lstAccounts.SelectedIndex == -1) // no selection
            {
                MessageBox.Show("you must select an account first");
                lstAccounts.Focus();
            }
            else // account is selected
            {
                Account acct = accounts[lstAccounts.SelectedIndex];
                // validate the amount
                if (Validator.IsPresent(txtAmount) &&
                    Validator.IsNonNegativeDecimal(txtAmount)
                   )
                {
                    decimal amount = Convert.ToDecimal(txtAmount.Text);
                    bool success = acct.Withdraw(amount);
                    if(!success)
                    {
                        MessageBox.Show($"Not sufficient funds: you may withdraw only up to {acct.Balance:c}");
                    }
                    DisplayAccounts();
                }
            }
        }
    }
}
