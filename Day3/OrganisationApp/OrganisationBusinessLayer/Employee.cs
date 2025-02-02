namespace OrganisationBusinessLayer
{
    public class Employee
    {
        public int fixedSalary;
        public DateTime workingFrom;
        public Department department;

        public Employee(int fixedSalary, DateTime workingFrom, Department department)
        {
            this.fixedSalary = fixedSalary;
            this.workingFrom = workingFrom;
            this.department = department;
        }

        double GetAllowance()
        {
            double WorkExperience = (new DateTime(2014, 03, 31) - workingFrom).TotalDays / 365;

            if (WorkExperience < 5)
            {
                double allowance = fixedSalary * 0.05;
                return allowance;
            }
            else if (WorkExperience < 10 && WorkExperience >= 5)
            {
                double allowance = fixedSalary * 0.10;
                return allowance;
            }
            else if (WorkExperience < 15 && WorkExperience >= 10)
            {
                double allowance = fixedSalary * 0.15;
                return allowance;
            }
            else
            {
                double allowance = fixedSalary * 0.20;
                return allowance;
            }
        }

        double GetAllowance(DateTime cutOffDate)
        {
            double WorkExperience = (cutOffDate - workingFrom).TotalDays / 365;

            if (WorkExperience < 5)
            {
                double allowance = fixedSalary * 0.05;
                return allowance;
            }
            else if (WorkExperience < 10 && WorkExperience >= 5)
            {
                double allowance = fixedSalary * 0.10;
                return allowance;
            }
            else if (WorkExperience < 15 && WorkExperience >= 10)
            {
                double allowance = fixedSalary * 0.15;
                return allowance;
            }
            else
            {
                double allowance = fixedSalary * 0.20;
                return allowance;
            }

        }
        
        public double GetTotalSalary(DateTime cutOffDate, float multipleFactor)
        {
            double totalSalary = 0;
            totalSalary = fixedSalary + GetAllowance(cutOffDate) + department.GetIncentive(multipleFactor);

            return totalSalary;
        }

        public double GetTotalSalary(float multipleFactor)
        {
            double totalSalary = 0;
            totalSalary = fixedSalary + GetAllowance() + department.GetIncentive(multipleFactor);

            return totalSalary;
        }
    }
}
