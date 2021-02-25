using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Teacher : Person
    {
        public string name;
        public int age;
        public string subject;
        Teacher(string name, int age, string subject)
        {
            this.name = name;
            this.age = age;
            this.subject = subject;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSubject(string subject)
        {
            this.subject = subject;
        }
        public void Explain()
        {
            Console.WriteLine($"Explanation of {subject} begins");
        }
    }
}
