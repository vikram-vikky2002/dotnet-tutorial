using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntorkBusinessLayer
{
    public class Customer
    {
        public string Address { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public List<MeterReading> Readings { get; set; }

        public Customer(int customerId, string customerName, string address, string phoneNumber)
        {
            Address = address;
            CustomerId = customerId;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            Readings = new List<MeterReading>();
        }

        public bool AddCustomerReading(MeterReading reading)
        {
            try
            {
                Readings.Add(reading);
                return true;
            }
            catch 
            { 
                return false; 
            }

        }

        public string GetCustomerInfo()
        {
            string info = CustomerId + " " + CustomerName + " " + Address + " " + PhoneNumber;
            return info;
        }
    }
}
