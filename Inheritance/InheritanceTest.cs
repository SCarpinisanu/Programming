using Prog.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Inheritance
{
    public class InheritanceTest
    {
        //Inheritance is the concept that a class can inherit properties and methods from another class.
        //In C# only one class can be inherited, but a class can implement multiple interfaces.
        //A child class can extend or override the functionality of a parent class.
        [Test]
        public void InheritanceTestMethod()
        {
            var person = new Person("Ionescu Maria", 35, "Female");
            person.InfoPerson();
            var employee = new Employee("Sorin Carpinisanu", 58, "Male", "Endava Romania SRL", "Senior Tester", 6500.0);
            employee.InfoEmployee();
            var student = new Student("Andrei Popescu", 22, "Male", "UBB Cluj", "Computer Science", true);
            student.InfoStudent();
        }
    }
}
