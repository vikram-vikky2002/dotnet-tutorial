using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTravelBusinessLayer
{
    public class Vehicle
    {
        int distance;
        double farePerKM;
        protected string vehicleId;

        static int count;

        static Vehicle()
        {
            count = 1000;
        }

        public Vehicle(int distance, double farePerKM)
        {
            this.distance = distance;
            this.farePerKM = farePerKM;
            this.vehicleId = "" + ++count;
        }

        public virtual double CalculateTotalFare()
        {
            return distance * farePerKM;
        }
    }
}
