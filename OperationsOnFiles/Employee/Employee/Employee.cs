using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    class Employee 
    {
        public string Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return $"{ FirstName } {LastName}";
        }

        public void SetFullName(string newName, string newSurame)
        {
            FirstName = newName;
            LastName = newSurame;

            Console.WriteLine("New personal data = " + GetFullName());
        }

        public void SetSalary() 
        {
            Salary = "Starting amount";
        }

        public void Save()
        {
            DataStorage.Store(this);
        }

    }
}
