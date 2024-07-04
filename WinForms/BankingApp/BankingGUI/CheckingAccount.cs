using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Banking_Classes;

namespace BankingGUI
{
    public class CheckingAccount : Account
    {
        decimal overdraftLimit { get; set; }

        public CheckingAccount(decimal overdraftLimit, decimal Balance) : base(Balance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override bool Withdraw(decimal amount)
        {
            bool success = true;
            amount = Math.Abs(amount);
            if ((balance - amount) < overdraftLimit) // nsf
            {
                success = false;
            }
            else if ((balance - amount) >= overdraftLimit)
            {
                success = true;
                balance -= amount;
            }
            
            return success;
        }
    }
}
