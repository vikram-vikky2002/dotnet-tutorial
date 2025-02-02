using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTravelBusinessLayer
{
    public class Cab : Vehicle
    {
        string voucher;

        public Cab(double farePerKM, int distance, string voucher, int vehicleNumber) : base(distance, farePerKM)
        {
            this.voucher = voucher;
            base.vehicleId = "C" + vehicleNumber;
        }

        public override double CalculateTotalFare()
        {
            double totalPrice = base.CalculateTotalFare();
            if(voucher != null)
            {
                totalPrice = totalPrice - 100;
            }
            totalPrice = totalPrice + (totalPrice * 0.05);

            return totalPrice;
        }
    }
}
