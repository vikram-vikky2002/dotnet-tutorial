using BankingSystemBusinessLayer;

namespace BankingSystemApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount("Vikram", 20000);
            BankAccount bankAccount1 = new BankAccount("Sagar", 25000);

            bankAccount.DisplayDetails();
            bankAccount1.DisplayDetails();

            Console.WriteLine("Deposit");
            bankAccount.Deposit(1000);
            bankAccount1.Deposit(2000);

            bankAccount.DisplayDetails();
            bankAccount1.DisplayDetails();

            Console.WriteLine("Withdraw");
            bankAccount.Withdraw(500);
            bankAccount1.Withdraw(1000);

            bankAccount.DisplayDetails();
            bankAccount1.DisplayDetails();
        }
    }
}
