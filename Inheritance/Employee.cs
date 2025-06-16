using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Inheritance
{
    public class Employee : Person //Employee is the derived class
    {
        public string Company;
        public string Position;
        public double Salary;
        public Employee(string name, int age, string gender, string company, string position, double salary)
            : base(name, age, gender) //Calling the base class constructor
        {
            Company = company;
            Position = position;
            Salary = salary;
        }
        public void InfoEmployee()
        {
            InfoPerson(); //Calling the base class method
            Console.WriteLine($"I work at {Company} as {Position}\n and I earn {Salary} per month.");
        }
    }
}
