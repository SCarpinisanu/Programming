using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog.Inheritance
{
    public class Person //Person is the base class
    {
        public string Name;
        public int Age;
        public string Gender;
        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public void InfoPerson()
        {
            Console.WriteLine($"My name is {Name}, I am a {Gender}\n and I am {Age} years old.");
        }
    }
}
