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
