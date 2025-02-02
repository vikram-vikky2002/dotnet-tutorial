using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeBankBusinessLayer
{
    public class Transaction
    {
        public string TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public double Amount { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

        static int counter;

        static Transaction()
        {
            counter = 500;
        }

        public Transaction()
        {
           
        }

        public string DisplayTransactionDetails()
        {
            string info = TransactionId + " " + TransactionDate + " " + Amount + " " + Type + " " + Status;
            return info;
        }

        public string ProcessTransaction(SavingsAccountHolder customer, Banker banker, double amount, string type)
        {
            try
            {
                if (customer != null && banker != null)
                {
                    if (type == "Debit")
                    {
                        if (customer.Balance >= amount)
                        {
                            TransactionId = "D" + ++counter;
                            Amount = amount;
                            Type = type;
                            TransactionDate = DateTime.Now;
                            Status = "Completed";

                            return $"Transaction completed for customer {customer.Name} with banker {banker.Name} with Transaction ID : {TransactionId}";
                        }
                    }
                    else if (type == "Credit")
                    {
                        TransactionId = "C" + ++counter;
                        Amount = amount;
                        Type = type;
                        TransactionDate = DateTime.Now;
                        Status = "Completed";

                        return $"Transaction completed for customer {customer.Name} with banker {banker.Name} with Transaction ID : {TransactionId}";
                    }

                }

                return "Transaction could not be completed.";
            }
            catch (Exception ex)
            {
                return "Some Error occured, Transaction failed.";
            }
        }
    }
}
