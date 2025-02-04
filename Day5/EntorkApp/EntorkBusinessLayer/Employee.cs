using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntorkBusinessLayer
{
    public class Employee
    {
        public string ContactNumber { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int employeeId, string name, string contactNumber, double salary)
        {
            ContactNumber = contactNumber;
            EmployeeId = employeeId;
            Name = name;
            Salary = salary;
        }

        public virtual double CalculateSalary()
        {
            return Salary;
        }

        public virtual string GetEmployeeInfo()
        {
            string info = EmployeeId + " " + Name + " " + ContactNumber;
            return info;
        }
    }
}
