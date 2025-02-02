using ClassLibrary;
using GetWellAppClasses;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Doctor doctor1 = new Doctor("Dr. John Smith", "Cardiologist", "IGMC");
            Doctor doctor2 = new Doctor("Dr. Sankar", "Cardiologist", "JIPMER");

            Patient patient1 = new Patient("Jane Deo", 20, "BP");
            Patient patient2 = new Patient("Jane Single", 22, "HyperTension");

            doctor1.DisplayDooctorInfo();
            doctor2.DisplayDooctorInfo();

            patient1.DisplayPatientInfo();
            patient2.DisplayPatientInfo();

            Console.WriteLine("\nTotal Hospital : " + Hospital.TotalHospitals());
            


        }
    }
}
