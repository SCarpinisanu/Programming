using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog.Abstractisation
{
    public class Employee : Person, IEmployee
    {
        private string Company { get; set; }
        private double Salary { get; set; }
        public Employee(string firstName, string lastName, int age, string company, double salary)
            : base(firstName, lastName, age)
        {
            Company = company;
            Salary = salary;
        }
        public void DisplayEmployeeInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Company: {Company}, Salary: {Salary}");
        }

        public void GoToWork()
        {
            Console.WriteLine($"Employee is going to work at {Company}.");
        }
        public void TakeBreak()
        {
            Console.WriteLine("Employee is taking a break.");
        }
        public void AttendMeeting()
        {
            Console.WriteLine("Employee is attending a meeting.");
        }
    }
}
