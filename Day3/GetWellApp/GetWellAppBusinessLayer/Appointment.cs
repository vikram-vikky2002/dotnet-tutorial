using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWellAppBusinessLayer
{
    public class Appointment
    {
        static int counter;

        public DateTime AppointmentDate { get; set; }
        public int AppointmentId { get; set; }
        public string Diagnosis { get; set; }
        public string Status { get; set; }

        static Appointment()
        {
            counter = 500;
        }

        public Appointment()
        {
            AppointmentId = ++counter;
        }

        public bool BookAppointment(Patient patient, Doctor doctor, string diagnosis)
        {
            if (patient != null && doctor != null)
            {
                AppointmentDate = DateTime.Now.AddHours(2);
                Status = "Scheduled";
                Diagnosis = diagnosis;

                Console.WriteLine($"Appointment for {patient.Name} booked successfully with Dr. {doctor.Name}.");

                DisplayAppointmentDetails();

                return true;
            }
            return false;
        }

        public void DisplayAppointmentDetails()
        {
            Console.WriteLine("Appointment Details : ");
            Console.WriteLine("Appointment ID : " + AppointmentId);
            Console.WriteLine("Appointment Diagnosis : " + Diagnosis);
            Console.WriteLine("Appointment Date : " + AppointmentDate);
        }
    }
}
