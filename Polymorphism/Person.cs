using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Polymorphism
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
        }

        public virtual void IsEating()
        {
            Console.WriteLine($"Person is eating lunch at restaurant.");
        }
    }
}
