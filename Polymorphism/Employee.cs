using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog.Polymorphism
{
    public class Employee : Person
    {
        private string Company;
        private double Salary;

        public Employee(string firstName, string lastName, int age, string company, double salary)
            : base(firstName, lastName, age)
        {
            Company = company;
            Salary = salary;
        }

        public override void DisplayInfo()
        {
            //Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
            base.DisplayInfo();
            Console.WriteLine($"  Company: {Company}, Salary: {Salary}");
        }
    }
}
