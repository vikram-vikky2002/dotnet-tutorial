using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBusinessLayer
{
    public class Seller
    {
        public string sellerId;
        public string sellerName;

        public Seller(string sellerId, string sellerName)
        {
            this.sellerId = sellerId;
            this.sellerName = sellerName;
        }
    }
}
