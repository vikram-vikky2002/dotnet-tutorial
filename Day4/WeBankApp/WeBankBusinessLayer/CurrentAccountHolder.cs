using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeBankBusinessLayer
{
    public class CurrentAccountHolder : Customer
    {
        public double OverdraftLimit { get; set; }

        public CurrentAccountHolder(double overdraftLimit, int customerId, string name, int age, string gender, string phoneNumber) : base(customerId, name, age, gender, phoneNumber)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override string DisplayCustomerInfo()
        {
            string info = base.DisplayCustomerInfo() + " " + OverdraftLimit;
            return info;
        }
    }
}
