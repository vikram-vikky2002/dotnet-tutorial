using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GetWellAppBusinessLayer
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Specialization { get; set; }

        public Doctor(int doctorId, string name, string specialization, string phoneNumber)
        {
            DoctorId = doctorId;
            Name = name;
            PhoneNumber = phoneNumber;
            Specialization = specialization;
        }

        public string DisplayDoctorInfo()
        {
            string details = DoctorId + " " + Name + " " + Specialization + " " + PhoneNumber;
            return details;
        }
    }
}
