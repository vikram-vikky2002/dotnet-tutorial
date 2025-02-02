using A2ZSalesBusinessLayer;

namespace A2ZSalesConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aggregation

            ////Category category = new Category();  // Step 1 - Allocating memory

            ////// Step 2 - Assign values
            ////category.CategoryId = 1;
            ////category.CategoryName = "Electronics";

            //Category category = new Category("Electronics");
            ////Console.WriteLine(category.CategoryName);

            //Category category1 = new Category("Vehicle");
            ////Console.WriteLine(category.CategoryName);

            //Product product = new Product("Mobile Phone", 15000, 5, category);
            //Product product2 = new Product("Pulsar", 85000, 3, category1);

            //Console.WriteLine("\nProducts");
            //product.DisplayProduct();
            //int discountAmount = product.GetDiscount();
            //Console.WriteLine("Discount Amount : " + discountAmount + "%");

            //product2.DisplayProduct();
            //int discountAmount2 = product2.GetDiscount();
            //Console.WriteLine("Discount Amount : " + discountAmount2 + "%");


            #endregion

            #region Association

            Coupon coupon1 = new Coupon(1, "VIKKY12345", DateTime.Now.AddDays(5));
            Coupon coupon2 = new Coupon(2, "ANKI12345", DateTime.Now.AddDays(12));
            Coupon coupon3 = new Coupon(3, "VISHNU12345", DateTime.Now.AddDays(10));
            Coupon coupon4 = new Coupon(4, "SAGAR12345", DateTime.Now.AddDays(3));

            Customer customer1 = new Customer("Vikram", "vikram@gmail.com", "8309365005");
            double amount = customer1.CalculateDisconut(1000, coupon2);
            Console.WriteLine("Final Price : " + amount);

            #endregion
        }
    }
}
