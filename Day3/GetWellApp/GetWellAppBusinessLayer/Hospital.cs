using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GetWellAppBusinessLayer
{
    public class Hospital
    {
        public Doctor Doctor { get; set; }
        public string HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string Location { get; set; }

        static int counter;

        static Hospital()
        {
            counter = 1000;
        }

        public Hospital(Doctor doctor, string hospitalName, string location)
        {
            HospitalId = "H" + ++counter;
            Doctor = doctor;
            HospitalName = hospitalName;
            Location = location;
        }

        public string DisplayHospital()
        {
            string details = HospitalId + " " + HospitalName + " " + Location + " " + Doctor.Name;
            return details;
        }

    }
}
