using GetWellAppBusinessLayer;

namespace GetWellAppConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient = new Patient(201, "John Doe", 45, "Male", "9998887776");
            
            
            Doctor doctor = new Doctor(101, "Smith Jones", "Cardiologist", "9876543210");
            Hospital hospital = new Hospital(doctor, "City Hospital", "Church Street");
            Console.WriteLine("Patient Details : " + patient.DisplayPatientInfo());
            Console.WriteLine("Doctor Details : " + doctor.DisplayDoctorInfo());
            Console.WriteLine("Hospital Details : " + hospital.DisplayHospital());
            Appointment appointment = new Appointment();
            bool status = appointment.BookAppointment(patient, doctor, "Diabetes");

            if (status)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
