using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ZSalesBusinessLayer
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }

        static int counter;

        static Customer()
        {
            counter = 100;
        }

        public Customer(string customerName, string customerEmail, string customerPhone)
        {
            CustomerId = ++counter;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            CustomerPhone = customerPhone;
        }

        public double CalculateDisconut(double amount, Coupon coupon)
        {
            double disconutAmount = amount;

            if(coupon != null)
            {
                if (coupon.CouponCode == "ANKI12345")
                    disconutAmount = (amount * 0.3);
                else if (coupon.CouponCode == "VIKKY12345")
                    disconutAmount = (amount * 0.7);
                else if (coupon.CouponCode == "SAGAR12345")
                    disconutAmount = (amount * 0.8);
                else
                    disconutAmount = amount;
            }

            return disconutAmount;
        }
    }
}
