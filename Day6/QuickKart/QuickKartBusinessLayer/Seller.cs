namespace QuickKartBusinessLayer
{
    public class Seller
    {
        string sellerId;
        static int sellerCount;
        string sellerName;

        public string SellerId { get { return sellerId; } set { sellerId = value; } }
        public string[] SellerLocations { get; set; }
        public string SellerName { get { return sellerName; } set { sellerName = value; } }

        static Seller()
        {
            sellerCount = 0;
        }

        public Seller(int maxSize)
        {
            SellerId = "" + ++sellerCount;
            SellerLocations = new string[maxSize];
        }

        public bool AddLocation(params string[] sellerLocations)
        {
            if(SellerLocations.Length > sellerLocations.Length)
            {
                SellerLocations = sellerLocations;

                return true;
            }

            return false;
            
        }
    }
}
