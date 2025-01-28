namespace WeBankClasses
{
    public class Transaction
    {
        public int TransactionId;
        public int AccountNumber;
        public string TransactionType;
        public decimal Amount;

        public void DisplayTransactionDetails()
        {
            Console.WriteLine("\nTransaction Details : ");
            Console.WriteLine("AccountNumber : " + AccountNumber);
            Console.WriteLine("Transaction Type : " + TransactionType);
            Console.WriteLine("Amount : $" + Amount);
        }
    }
}
