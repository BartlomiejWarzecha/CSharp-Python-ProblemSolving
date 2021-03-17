using System;
using System.IO;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.FirstName = "Bartlomiej";
            employee1.LastName = "Warzecha";

            employee1.SetSalary();
            employee1.Save();

            employee1.SetFullName("ktos", "inny");

            Console.WriteLine($"Employee = " + employee1.GetFullName());

            employee2 = employee1;
            employee2 = DataStorage.Load("Bartlomiej", "Warzecha");

            Console.WriteLine($"Employee = " + employee2.GetFullName());
        }
    }
}
