namespace A2ZsalesBusinessLayer
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public string ProductDescription;
        public string ProductCategory;
        public double ProductPrice;
        public int QuantityAvailable;

        public static int counter;

        static Product()
        {
            counter = 100;
        }

        public static int ProductCount()
        {
            int c = counter - 100;
            return c;
        }

        public Product()
        {
            ProductId = -1;
            ProductName = "...";
            ProductDescription = "NA";
            ProductCategory = "NA";
            ProductPrice = 0;
            QuantityAvailable = 0;
        }

        public Product(string productName, string productDescription, string productCategory, double productPrice, int quantityAvailable)
        {
            ProductId = ++counter;
            ProductName = productName;
            ProductDescription = productDescription;
            ProductCategory = productCategory;
            ProductPrice = productPrice;
            QuantityAvailable = quantityAvailable;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Product ID : " + ProductId);
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Product Description : " + ProductDescription);
            Console.WriteLine("Product Price : " + ProductPrice);
            Console.WriteLine("Product Quantity Available : " + QuantityAvailable);
            Console.WriteLine();
        }

        public void UpdateQuantity(int addOnQuantity)
        {
            QuantityAvailable = QuantityAvailable + addOnQuantity;
        }
    }
}
