namespace Banking_Classes
{
    // bank account
    public class Account
    {
        private int acctNo;
        protected decimal balance;

        private static int nextNo = 100; // static data to generate account numbers

        public int AccountNo {  get { return acctNo; } } // read-only
        public decimal Balance { get; set; }

        public Account(decimal initBalance = 0) // if not provided, set it to zero
        {
            acctNo = nextNo++; // use static data for account number and incement it for next account
            initBalance= Math.Abs(initBalance);
            balance = initBalance; 
        }

        // returns false if NSF, otherwise true
        public virtual bool Withdraw(decimal amount)
        {
            bool success = true;
            amount = Math.Abs(amount); // make it non-negative
            if(amount <= balance) // can withdraw
            {
                balance -= amount;
            }
            else // NSF
            {
                success = false;
            }
            return success;
        }

        public void Deposit(decimal amount)
        {
            amount = Math.Abs(amount); // make it non-negative
            balance += amount; // can always deposit
        }


        public override string ToString()
        {
            return $"{acctNo}: {balance:c}";
        }

    }
}
