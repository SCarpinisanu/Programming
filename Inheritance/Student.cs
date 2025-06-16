using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Inheritance
{
    public class Student : Person // Student is the derived class
    {
        public string University;
        public string Profile;
        public bool HasScholarsip;
        public Student(string name, int age, string gender, string university, string profile, bool hasScholarship)
            : base(name, age, gender) // Calling the base class constructor
        {
            University = university;
            Profile = profile;
            HasScholarsip = hasScholarship;
        }
        public void InfoStudent()
        {
            InfoPerson(); // Calling the base class method
            Console.WriteLine($"I study at {University} - {Profile} profile.\n Scholarship status: {(HasScholarsip ? "Yes" : "No")}.");
        }
    }
}
