using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWellAppClasses
{
    public static class Hospital
    {
        public static int totalHospital;

        static Hospital()
        {
            totalHospital = 300;
        }

        public static int TotalHospitals()
        {
            return totalHospital;
        }
    }
}
