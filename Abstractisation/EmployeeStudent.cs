using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog.Abstractisation
{
    public class EmployeeStudent : Person, IStudent, IEmployee
    {
        private string Company { get; set; }
        private double Salary { get; set; }
        private string University { get; set; }
        private string Profile { get; set; }

        public EmployeeStudent(string firstName, string lastName, int age, string company, double salary, string university, string profile)
            : base(firstName, lastName, age)
        {
            Company = company;
            Salary = salary;
            University = university;
            Profile = profile;
        }
        public void Study()
        {
            Console.WriteLine($"EmployeeStudent is studying at {University} in the {Profile} profile.");
        }
        public void AttendClass()
        {
            Console.WriteLine("EmployeeStudent is attending class.");
        }
        public void TakeExam()
        {
            Console.WriteLine("EmployeeStudent is taking an exam.");
        }
        public void GoToWork()
        {
            Console.WriteLine($"EmployeeStudent is going to work at {Company} with a salary of {Salary}.");
        }
        public void TakeBreak()
        {
            Console.WriteLine("EmployeeStudent is taking a break at work.");
        }
        public void AttendMeeting()
        {
            Console.WriteLine("EmployeeStudent is attending a meeting at work.");
        }
    }
}
