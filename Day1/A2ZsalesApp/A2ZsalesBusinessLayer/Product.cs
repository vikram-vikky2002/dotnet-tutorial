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
        
        public string DisplayDetails()
        {
            string data = ProductId + ") " + ProductName + " || " + ProductDescription + " || " + ProductCategory + " || " + ProductPrice + " || " + QuantityAvailable;
            return data;
        }

        public void UpdateQuantity(int addOnQuantity)
        {
            QuantityAvailable = QuantityAvailable + addOnQuantity;
        }
    }
}
