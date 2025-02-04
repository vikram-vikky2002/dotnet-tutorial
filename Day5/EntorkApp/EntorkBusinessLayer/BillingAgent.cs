using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntorkBusinessLayer
{
    public class BillingAgent : Employee
    {
        public string BaseWorkLocation { get; set; }
        public int BillsProcessedPerDay { get; set; }

        public BillingAgent(int employeeId, string name, string contactNumber, double salary, int billsProcessedPerDay, string baseWorkLocation) : base(employeeId,  name, contactNumber, salary)
        {
            BaseWorkLocation = baseWorkLocation;
            BillsProcessedPerDay = billsProcessedPerDay;
        }

        public override double CalculateSalary()
        {
            double totalSalary = base.CalculateSalary();
            if (BaseWorkLocation == "New York" || BaseWorkLocation == "London")
            {
                if(BillsProcessedPerDay > 20)
                {
                    totalSalary += (BillsProcessedPerDay * 100);
                }
                else if(BillsProcessedPerDay > 10)
                {
                    totalSalary += (BillsProcessedPerDay * 75);
                }
                else 
                {
                    totalSalary += (BillsProcessedPerDay * 50);
                }
            }
            else
            {
                if (BillsProcessedPerDay > 20)
                {
                    totalSalary += (BillsProcessedPerDay * 80);
                }
                else if (BillsProcessedPerDay > 10)
                {
                    totalSalary += (BillsProcessedPerDay * 60);
                }
                else
                {
                    totalSalary += (BillsProcessedPerDay * 40);
                }
            }

            base.Salary = totalSalary;
            return totalSalary;
        }

        public override string GetEmployeeInfo()
        {
            string info = base.GetEmployeeInfo() + " " + Salary + " " + BaseWorkLocation + " " + BillsProcessedPerDay;
            return info;
        }
    }
}
