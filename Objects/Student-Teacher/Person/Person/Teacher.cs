using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Teacher : Person
    {
        private string subject;
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
