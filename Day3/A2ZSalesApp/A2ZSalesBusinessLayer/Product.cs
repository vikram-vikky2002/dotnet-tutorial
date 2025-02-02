using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ZSalesBusinessLayer
{
    public class Product
    {

        // Attributes
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int QuantityAvailable { get; set; }

        // Property
        public Category category { get; set; }

        static int counter;

        static Product()
        {
            counter = 100;
        }


        // Constructors
        public Product(string productName, double price, int quantityAvailable, Category category)
        {
            ProductId = "P" + ++counter;
            ProductName = productName;
            Price = price;
            QuantityAvailable = quantityAvailable;
            this.category = category;
        }

        public void DisplayProduct()
        {
            Console.WriteLine("\nProduct ID : " + ProductId);
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Product Price : " + Price);
            Console.WriteLine("Product Category : " + category.CategoryId + " - " + category.CategoryName);
        }

        // Methods
        public int GetDiscount()
        {
            if(this.category.CategoryName == "Electronics")
            {
                return 10;
            }
            else if(this.category.CategoryName == "Stationary")
            {
                return 5;
            }
            else
            {
                return 2;
            }
        }
    }
}
