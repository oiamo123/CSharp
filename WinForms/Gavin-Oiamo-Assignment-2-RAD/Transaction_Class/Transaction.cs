namespace Transaction_Class
{
    public class Transaction
    {
        public DateTime transactionDate { get; set; }
        public decimal transactionKwh { get; set; }
        public decimal transactionCost { get; set; }

        public Transaction(decimal transactionKwh, decimal transactionCost)
        {
            this.transactionDate = DateTime.Now;
            this.transactionKwh = transactionKwh;
            this.transactionCost = transactionCost;
        }

    }
}
