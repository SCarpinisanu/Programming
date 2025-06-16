using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Abstractisation
{
    public class Person(string firstName, string lastName, int age)
    {
        public string FirstName { get; private set; } = firstName;
        public string LastName { get; private set; } = lastName;
        public int Age { get; private set; } = age;

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
        }
    }
}
