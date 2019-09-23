using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }

        public int Age { set; get; }

        public void SayHello()
        {
            Console.WriteLine($"hello I am {FirstName} {LastName}");
        }
        public void SetAge(int n)
        {
            Age = n;
        }
    }
    public class Student : Person
    {
        public void GoToClass()
        {
            Console.WriteLine("I am going to class");
        }

        public void ShowAge()
        {
            Console.WriteLine($"I am {Age} year old");
        }
    }

    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("Explaination begins");
        }
    }
}
