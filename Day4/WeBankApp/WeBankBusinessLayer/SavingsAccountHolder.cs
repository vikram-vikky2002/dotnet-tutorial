using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeBankBusinessLayer
{
    public class SavingsAccountHolder : Customer
    {
        public double InterestRate { get; set; }
        public double Balance { get; set; }

        public SavingsAccountHolder(double interestRate, double balance, int customerId, string name, int age, string gender, string phoneNumber) : base(customerId, name, age, gender, phoneNumber)
        {
            InterestRate = interestRate;
            Balance = balance;
        }

        public override string DisplayCustomerInfo()
        {
            string info = base.DisplayCustomerInfo() + " " + InterestRate + " " + Balance;
            return info;
        }
    }
}
