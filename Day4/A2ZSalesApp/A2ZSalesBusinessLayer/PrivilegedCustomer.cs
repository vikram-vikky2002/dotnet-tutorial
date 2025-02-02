using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ZSalesBusinessLayer
{
    public class PrivilegedCustomer : Customer
    {
        public bool CouponsOwned { get; set; }

        public PrivilegedCustomer(bool couponsOwned, int customerId, string customerName, string customerEmail, string customerPhone) : base(customerId, customerName, customerEmail, customerPhone)
        {
            CouponsOwned = couponsOwned;
        }

        public new double GenerateBillAmount(double amount)
        {
            if (CouponsOwned)
            {
                return amount * 0.5;
            }
            else
            {
                return amount * 0.2;
            }
        }
    }
}
