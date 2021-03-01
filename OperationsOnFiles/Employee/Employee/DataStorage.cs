using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class DataStorage 
    {       
        public static void Store(Employee employee)
        {
            FileStream stream = new FileStream(employee.FirstName + employee.LastName + ".dot", FileMode.Create);

            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(employee.FirstName);
            writer.WriteLine(employee.LastName);
            writer.WriteLine(employee.Salary);

            writer.Dispose();
        }   
        
        public static Employee Load(string FirstName, string LastName)
        {
            Employee employee = new Employee();

            FileStream stream = new FileStream(FirstName + LastName + ".dot", FileMode.Open);
    
            StreamReader reader = new StreamReader(stream);

            employee.FirstName = reader.ReadLine();
            employee.LastName = reader.ReadLine();
            employee.Salary = reader.ReadLine();

            reader.Dispose();
            return employee;
        }

    }
}
