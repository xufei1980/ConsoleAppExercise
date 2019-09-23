using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            var aPerson = new Person
            {
                FirstName = "Alix",
                LastName = "Hill"
              };
            aPerson.SayHello();
            var aStudent = new Student
            {
                FirstName = "Bill",
                LastName = "Wang"
            };
            aStudent.SetAge(21);
            aStudent.SayHello();
            aStudent.ShowAge();
            var aTeacher = new Teacher
            {
                FirstName = "Mia",
                LastName = "Lynn"
            };
            aTeacher.SetAge(31);
            aTeacher.SayHello();
           
            Console.ReadLine();
        }
    }
}
