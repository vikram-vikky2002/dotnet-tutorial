using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeBankBusinessLayer
{
    public class Bank
    {
        public string BankId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Banker Banker { get; set; }

        static int counter;

        static Bank()
        {
            counter = 1000;
        }

        public Bank(string name, string location, Banker banker)
        {
            BankId = "B" + ++counter;
            Name = name;
            Location = location;
            Banker = banker;
        }

        public string DisplayBankInfo()
        {
            string info = BankId + " " + Name + " " + Location;
            return info;
        }
    }
}
