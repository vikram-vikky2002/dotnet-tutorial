using System.Collections;
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

            #region Array Practice

            //int[] intArray = { 10, 20, 30, 40 };
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}

            //int[][] jaggedArray = new int[2][];
            //jaggedArray[0] = [1, 2, 3, 4];
            //jaggedArray[1] = [1, 2, 3, 4];
            //for (int j = 0; j < jaggedArray.Length; j++)
            //{
            //    for (int i = 0; i < jaggedArray[j].Length; i++)
            //    {
            //        Console.WriteLine(jaggedArray[j][i]);
            //    }
            //}

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(20);
            //arrayList.Add("30");
            //arrayList.Add(arrayList);

            //Console.WriteLine(arrayList[0]);
            //Console.WriteLine(arrayList[1]);
            //Console.WriteLine(arrayList[2]);

            //for (int k = 0; k < arrayList[2].Length; k++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}

            #endregion


        }
    }
}
