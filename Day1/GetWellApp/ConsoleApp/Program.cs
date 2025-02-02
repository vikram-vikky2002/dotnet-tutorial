using ClassLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Doctor doctor = new Doctor();
            doctor.DoctorID = 101;
            doctor.Name = "Dr. John Smith";
            doctor.Specialization = "Cardiologist";
            doctor.ContactNumber = 9876543210;
            
            Patient patient = new Patient();
            patient.PatientID = 201;
            patient.Name = "Jane Deo";
            patient.Age = 45;
            patient.Disease = "HyperTension";


            doctor.DisplayDetails();
            patient.DisplayDetails();

            doctor.UpdateContactNumber(9999999999);
            doctor.DisplayDetails();


        }
    }
}
