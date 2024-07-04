using Transaction_Class;
using System.Runtime.CompilerServices;

namespace CustomerData
{
    /*
     * Electricity is calculated by admin charge + 12 + kwh * 0.07
     * Store int accountNo, string firstName, string lastName, int kwhUsed, decimal billAmount
     * Store customers data      
     */


    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int kwhUsed { get; set; }
        public decimal elecBill { get; set; }
        public int accountNumber { get; set; }
        public List<Transaction_Class.Transaction>? transactions { get; set; }

        public Customer(string firstName, string lastName, int accountNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            this.accountNumber = accountNumber;
            this.transactions = new List<Transaction>();
        }

        static public decimal CalculateCharge(int kwh)
        {
                if (kwh <= 0) return -1m;
                return (kwh * 0.07m) + 12;         
        }
    }
}
