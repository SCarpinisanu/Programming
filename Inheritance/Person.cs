using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Inheritance
{
    public class Person //Person is the base class
    {
        public string Name;
        public int Age;
        public string Gender;
        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public void InfoPerson()
        {
            Console.WriteLine($"My name is {Name}, I am a {Gender}\n and I am {Age} years old.");
        }
    }
}
