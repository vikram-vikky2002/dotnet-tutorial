using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBusinessLayer
{
    public class Category
    {
        public int categoryId;
        public string categoryName;

        public Category(int categoryId, string categoryName) 
        {
            this.categoryId = categoryId;
            this.categoryName = categoryName;
        }
    }
}
