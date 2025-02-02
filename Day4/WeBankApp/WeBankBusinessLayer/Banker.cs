using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeBankBusinessLayer
{
    public class Banker
    {
        public int BankerId { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public string PhoneNumber { get; set; }

        public Banker(int bankerId, string name, string branch, string phoneNumber)
        {
            BankerId = bankerId;
            Name = name;
            Branch = branch;
            PhoneNumber = phoneNumber;
        }

        public bool UpdateBankerDetails(string newBranch)
        {
            if (newBranch != Branch)
            {
                Branch = newBranch;
                return true;
            }

            return false;
        }

        public bool UpdateBankerDetails(string newBranch, string newPhoneNumber)
        {
            if (newBranch != Branch)
            {
                Branch = newBranch;
                if (newPhoneNumber != PhoneNumber)
                {
                    PhoneNumber = newPhoneNumber;

                    return true;
                }

            }

            return false;
        }

        public string DisplayBankerInfo()
        {
            string info = BankerId + " " + Name + " " + Branch + " " + PhoneNumber;
            return info;
        }


    }
}
