using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Abstractisation
{
    public class Student : Person, IStudent
    {
        private string University { get; set; }
        private string Profile { get; set; }
        private bool HasScholarship { get; set; }
        public Student(string firstName, string lastName, int age, string university, string profile, bool hasScholarship) 
            : base(firstName, lastName, age)
        {
            University = university;
            Profile = profile;
            HasScholarship = hasScholarship;
        }
        public void Study()
        {
            Console.WriteLine($"Student is studying at {University} in the {Profile} profile.");
        }
        public void AttendClass()
        {
            Console.WriteLine("Student is attending class.");
        }
        public void TakeExam()
        {
            Console.WriteLine("Student is taking an exam.");
        }
    }
}
