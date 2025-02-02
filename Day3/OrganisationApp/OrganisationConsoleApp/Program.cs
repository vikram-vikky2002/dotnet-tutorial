using OrganisationBusinessLayer;

namespace OrganisationConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(43000, new DateTime(2024, 10, 10), new Department(1, true, 3000));
            double salary = employee.GetTotalSalary(2.0f);
            Console.WriteLine("Total Salary : " + salary);
        }
    }
}
