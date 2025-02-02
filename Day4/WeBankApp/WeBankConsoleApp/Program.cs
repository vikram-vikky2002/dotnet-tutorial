using System.Reflection;
using WeBankBusinessLayer;

namespace WeBankConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccountHolder savingsAccountHolder = new SavingsAccountHolder(2.5, 50000, 101, "Anna Miller", 34, "Female", "9999999999");
            CurrentAccountHolder currentAccountHolder = new
            CurrentAccountHolder(20000, 102, "Frank Lawson", 29, "Male", "8888888888");
            Banker banker = new Banker(1, "Katie Otto", "Church Street", "7777777777");
            Bank bank = new Bank("We Trust Bank", "New York", banker);
            Console.WriteLine("Savings Account Holder details : " + savingsAccountHolder.DisplayCustomerInfo());
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Current Account Holder details : " + currentAccountHolder.DisplayCustomerInfo());
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Banker Details : " + banker.DisplayBankerInfo());
            Console.WriteLine("Updating Banker Contact Info");
            banker.UpdateBankerDetails("Mall Road");
            Console.WriteLine("Banker Details : " +
            banker.DisplayBankerInfo());
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Bank Details: " + bank.DisplayBankInfo());
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("----------------ProcessingTransactions------------------");
            Transaction transactionOne = new Transaction();
            Transaction transactionTwo = new Transaction();
            string messageOne =
            transactionOne.ProcessTransaction(savingsAccountHolder, banker, 1000, "Debit");
            Console.WriteLine("Transaction One");
            Console.WriteLine(messageOne);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Transaction Two");
            string messageTwo = transactionTwo.ProcessTransaction(savingsAccountHolder, banker, 3000, "Credit");
            Console.WriteLine(messageTwo);
        }
    }
}
