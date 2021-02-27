using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args) 
        {
            Teacher teacher = new Teacher();
            Student student = new Student();

            student.SetAge(22);
            student.SetName("Bartek");
            teacher.SetName("Mirosław");
            teacher.SetSubject("Data structures");

            student.ShowAge();
            student.greetings();
            teacher.greetings();

            student.GoToClasses();
            teacher.Explain();
          }
    }
}
