using CareHospitalBusinessLayer;

namespace CareHospitalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient(["L1", "L1", "L1"], 101, "Shankar");
            Console.WriteLine("Total Cost : " + patient.CalculateCharge());
        }
    }
}
