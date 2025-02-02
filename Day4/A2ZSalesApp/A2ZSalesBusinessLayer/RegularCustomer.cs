using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ZSalesBusinessLayer
{
    public class RegularCustomer : Customer
    {
        public int DiscountPercentage { get; set; }

        public RegularCustomer(int discountPercentage, int customerId, string customerName, string customerEmail, string customerPhone) : base(customerId, customerName, customerEmail, customerPhone)
        {
            Console.WriteLine("Child class ctor");
            DiscountPercentage = discountPercentage;
        }

        public override double GenerateBillAmount(double amount)
        {
            double discountedAmount = base.GenerateBillAmount(amount);
            discountedAmount = discountedAmount - (discountedAmount * DiscountPercentage/100);
            return discountedAmount;
        }
    }
}
