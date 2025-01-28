﻿using WeBankClasses;

namespace WeBankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Transaction> transactions = new List<Transaction>();
            BankAccounts accounts = new BankAccounts();
            accounts.AccountNumber = 123456;
            accounts.AccountHolderName = "John Deo";
            accounts.Balance = 5000;

            accounts.DisplayDetails();

            accounts.Deposit(1000);
            Transaction transaction1 = new Transaction();
            transaction1.TransactionType = "Deposit";
            transaction1.TransactionId = 1;
            transaction1.Amount = 1000;

            accounts.Withdraw(500);
            Transaction transaction2 = new Transaction();
            transaction2.TransactionType = "Withdraw";
            transaction2.TransactionId = 2;
            transaction2.Amount = 500;

            transaction1.DisplayTransactionDetails();
            transaction2.DisplayTransactionDetails();
        }
    }
}
