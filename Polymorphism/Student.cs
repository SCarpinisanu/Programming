using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog.Polymorphism
{
    public class Student : Person
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

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"University: {University}, Profile: {Profile}, Scholarship: {HasScholarship}");
        }

        public override void IsEating()
        {
            Console.WriteLine($"Student is eating in the university cafeteria.");
        }
    }
}
