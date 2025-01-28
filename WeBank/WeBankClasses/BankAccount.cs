namespace WeBankClasses
{
    public class BankAccounts
    {
        public string AccountHolderName;
        public int AccountNumber;
        public decimal Balance;

        public void Withdraw(decimal amount)
        {
            Balance = Balance - amount;
            Console.WriteLine("\nWithdraw Successful!! New Balance : $" + Balance);
        }

        public void Deposit(decimal amount)
        {
            Balance = Balance + amount;
            Console.WriteLine("\nDeposit Successful!! New Balance : $" + Balance);
            Transaction transaction1 = new Transaction();
            transaction1.TransactionType = "Deposit";
            transaction1.TransactionId = 1;
            transaction1.Amount = 1000;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nAccount Details :");
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Account Holder : " + AccountHolderName);
            Console.WriteLine("Account Balance : $" + Balance);
        }
    }
}
