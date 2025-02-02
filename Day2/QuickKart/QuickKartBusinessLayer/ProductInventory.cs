using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBusinessLayer
{
    public class ProductInventory
    {
        public int inventoryId;
        public int quantityInHand;

        public ProductInventory(int inventoryId, int quantityInHand)
        { 
            this.inventoryId = inventoryId;
            this.quantityInHand = quantityInHand;
        }
    }
}
