using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntorkBusinessLayer
{
    public class MeterReader : Employee
    {
        public int MeterCheckedPerDay { get; set; }

        public MeterReader(int employeeId, string name, string contactNumber, double salary, int meterCheckedPerDay) : base(employeeId, name, contactNumber, salary)
        {
            MeterCheckedPerDay = meterCheckedPerDay;
        }

        public override double CalculateSalary()
        {
            double totalSalary = base.CalculateSalary();
            if(MeterCheckedPerDay > 10)
            {
                int extraMeters = MeterCheckedPerDay - 10;
                totalSalary += (extraMeters * 250);

            }

            base.Salary = totalSalary;
            return totalSalary;
        }

        public string GetEmployeeInfo()
        {
            string info = base.GetEmployeeInfo() + " " + Salary + " " + MeterCheckedPerDay;
            return info;
        }
    }
}
