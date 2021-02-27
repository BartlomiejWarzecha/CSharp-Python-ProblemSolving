using System;

namespace Person
{
    class Person
    {
        protected int age;
        protected string name = " ";
        public void SetAge(int n)
        {
            age = n;
        }
        public void SetName(string n)
        { 
            name = n;
        }
        public void greetings() => Console.WriteLine($"Hello my name is {name}");

    }
}
