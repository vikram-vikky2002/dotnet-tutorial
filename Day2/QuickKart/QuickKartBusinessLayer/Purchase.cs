using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBusinessLayer
{
    public class Purchase
    {
        public DateTime dateOfPurchase;
        public string paymentType;
        public string purchaseId;
        public int quantityOrdered;
        public string shippingAddress;

        public Purchase(string purchaseId, int quantityOrdered, string shippingAddress, DateTime dateOfPurchase, string paymentType)
        {
            this.paymentType = paymentType;
            this.purchaseId = purchaseId;
            this.quantityOrdered = quantityOrdered; 
            this.shippingAddress = shippingAddress; 
            this.dateOfPurchase = dateOfPurchase;
        }
        
        public double CalculateBillAmount(double price)
        {
            double total = price * quantityOrdered;
            return total;
        }
    }
}
