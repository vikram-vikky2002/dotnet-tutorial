namespace BankingSystemBusinessLayer
{
    public static class Bank
    {
        public static int totalBanks;

        static Bank()
        {
            totalBanks = 300;
        }

        public static int DisplayTotalBanks()
        {
            return totalBanks;
        }
    }
}
