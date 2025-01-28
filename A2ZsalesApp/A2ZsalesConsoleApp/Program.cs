using A2ZsalesBusinessLayer;

namespace A2ZsalesConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product productOne = new Product();

            //set data
            productOne.ProductId = 1;
            productOne.ProductName = "Mobile Phone";
            productOne.ProductDescription = "new phone 256GB";
            productOne.ProductPrice = 90000;
            productOne.ProductCategory = "Electronics";
            productOne.QuantityAvailable = 10;

            //Get data
            Console.WriteLine("Product Details");
            Console.WriteLine("Product Name : " + productOne.ProductName);
            Console.WriteLine("Product Description : " + productOne.ProductDescription);
            Console.WriteLine("Product Category : " + productOne.ProductCategory);
            Console.WriteLine("Product Price : " + productOne.ProductPrice);          
            Console.WriteLine("Product Stock : " + productOne.QuantityAvailable);   

            //invoke method
            Console.WriteLine("\nDetails in one line : " + productOne.DisplayDetails());

            //update value method
            productOne.UpdateQuantity(5);
            Console.WriteLine("Updated Stock : " + productOne.QuantityAvailable);


        }
    }
}
