using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Student : Person
    {
        public string name;
        public int age;
        Student(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
        public void SetAge(int age)
        { 
            this.age = age;
        }
        public void SetName(string name)
        { 
            this.name = name;
        }
        public void GoToClasses() 
        {
            Console.WriteLine("I'm going to class");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is {age} years old");
        }
    }
}
