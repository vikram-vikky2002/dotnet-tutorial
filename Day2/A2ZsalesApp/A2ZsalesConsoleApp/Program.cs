using A2ZsalesBusinessLayer;

namespace A2ZsalesConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Parameterless

            //Product productOne = new Product();
            //productOne.DisplayDetails();

            #endregion

            #region Parameterized

            //Product productTwo = new Product(1, "Wings of Fire", "Book by APJ", "Book", 200, 10);
            //productTwo.DisplayDetails();

            #endregion

            #region Static keyword

            //Product product1 = new Product("Wings of Fire", "Book by APJ", "Book", 200, 10);
            //Product product2 = new Product("Wings of Fire 2", "Book by APJ", "Book", 200, 10);

            //product1.DisplayDetails();
            //product2.DisplayDetails();

            //int c = Product.ProductCount();
            //Console.WriteLine(c);

            #endregion

            #region Encapsulation


            Customer customer1 = new Customer();
            customer1.Age = 10;

            Console.WriteLine(customer1.Age);

            #endregion

        }
    }
}
