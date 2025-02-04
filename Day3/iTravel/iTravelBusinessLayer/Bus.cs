namespace iTravelBusinessLayer
{
    public class Bus : Vehicle
    {
        public Bus(double farePerKM, int distance, int vehicleNumber) : base(distance, vehicleNumber)
        {
            base.vehicleId = "B" + vehicleId;
        }

        public override double CalculateTotalFare()
        {
            double totalPrice = base.CalculateTotalFare();
            if (totalPrice > 1000)
            {
                totalPrice = totalPrice + (totalPrice * 0.02);
            }
            
            return totalPrice;
        }
    }
}
