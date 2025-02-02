using QuickKartBusinessLayer;

namespace QuickKartConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(101, "John Doe", "Privileged", new DateTime(1990, 5, 15), "johndoe@example.com", "Male", "password123");
            Customer customer2 = new Customer(102, "Jane Smith", "Elite", new DateTime(1995, 8, 20), "janesmith@example.com", "Female", "securepass");

            Console.WriteLine($"Customer 1 Discount: {customer1.GetDiscount()}%");
            Console.WriteLine($"Customer 2 Discount: {customer2.GetDiscount()}%");

            Product product1 = new Product("Gaming Laptop", 1200.50, "P001", "Laptop");
            Product product2 = new Product("Smartphone", 799.99, "P002", "Phone");
            Product product3 = new Product("Wireless Headphones", 199.99, "P003", "Headphones");
            Product product4 = new Product("Smartwatch", 249.99, "P004", "Watch");
            Product product5 = new Product("Mechanical Keyboard", 149.99, "P005", "Keyboard");

            ProductInventory inventory1 = new ProductInventory(1, 50);
            ProductInventory inventory2 = new ProductInventory(2, 30);

            Seller seller1 = new Seller("S001", "TechMart");
            Seller seller2 = new Seller("S002", "GadgetWorld");

            Category category1 = new Category(10, "Electronics");

            Purchase purchase1 = new Purchase("PR001", 2, "456 Avenue, City", DateTime.Now, "Credit Card");
            Console.WriteLine($"Total Bill Amount for Purchase 1: ${purchase1.CalculateBillAmount(product1.price)}");
        }
    }
}
