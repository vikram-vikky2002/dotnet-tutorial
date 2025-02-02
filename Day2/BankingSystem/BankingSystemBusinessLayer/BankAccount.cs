using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemBusinessLayer
{
    public class BankAccount
    {
        public int AccountNumber { get; private set; }
        public string AccountHolderName;
        public static int totalAccounts;

        static BankAccount()
        {
            totalAccounts = 100;
        }

        private decimal balance;

        public decimal Balance
        {
            get
            {
                return balance;
            }

            private set
            {
                if (balance > 0)
                {
                    balance = value;
                }
                else
                {
                    balance = 0;
                }
            }
        }

        public static int TotalAccount()
        {
            return totalAccounts - 100;
        }

        public BankAccount(string AccountHolderName, decimal balance)
        {
            this.AccountNumber = ++totalAccounts;
            this.AccountHolderName = AccountHolderName;
            this.balance = balance;
        }

        public void Withdraw(decimal amount)
        {
            Balance = balance - amount;
            Console.WriteLine("\nWithdraw Successful!! New Balance : $" + balance);
        }

        public void Deposit(decimal amount)
        {
            Balance = balance + amount;
            Console.WriteLine("\nDeposit Successful!! New Balance : $" + balance);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nAccount Details :");
            Console.WriteLine("Account Number : " + AccountNumber);
            Console.WriteLine("Account Holder : " + AccountHolderName);
            Console.WriteLine("Account Balance : $" + balance);
        }
    }
}
