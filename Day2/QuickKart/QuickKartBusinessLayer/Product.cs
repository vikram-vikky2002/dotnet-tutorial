using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBusinessLayer
{
    public class Product
    {
        public string description;
        public double price;
        public string productId;
        public string productName;

        public Product(string description, double price, string productId, string productName)
        {
            this.description = description;
            this.price = price;
            this.productId = productId;
            this.productName = productName;
        }
    }
}
