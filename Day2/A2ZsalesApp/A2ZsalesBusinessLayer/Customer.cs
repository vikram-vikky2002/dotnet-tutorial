using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ZsalesBusinessLayer
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        public string Name { get; set; }
        public long ContactNumber { get; set; }
        public string Email { get; set; }
        public bool IsPrivilegedCustomer { get; set; }

        private int age;

        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
