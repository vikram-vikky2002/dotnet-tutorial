using iTravelBusinessLayer;

namespace iTravelApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cab cab = new Cab(50, 10, "Vikram", 1000);
            Console.WriteLine("Cab cost : " + cab.CalculateTotalFare());

            Bus bus = new Bus(20, 10, 500);
            Console.WriteLine("Bus cost : " + bus.CalculateTotalFare());
        }
    }
}
