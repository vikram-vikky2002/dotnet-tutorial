namespace A2ZSalesBusinessLayer
{
    public class Category
    {
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        static int counter;

        static Category()
        {
            counter = 200;
        }

        public Category(string categoryName)
        {
            CategoryId = "C" + ++counter;
            CategoryName = categoryName;
        }
    }
}
