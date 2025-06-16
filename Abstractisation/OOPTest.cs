using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog.Abstractisation
{
    public class OOPTest
    {
        [Test]
        public void TestOOP()
        {
            Employee employee = new Employee("Marius", "Popescu", 38, "IBM", 15620.0);
            employee.GoToWork();
            employee.TakeBreak();
            employee.AttendMeeting();

            EmployeeStudent employeeStudent = new EmployeeStudent("Ion", "Ionescu", 22, "Google", 12000.0, "University of Bucharest", "Computer Science");
            employeeStudent.GoToWork();
            employeeStudent.TakeBreak();
            employeeStudent.AttendMeeting();
            employeeStudent.Study();
            employeeStudent.AttendClass();
            employeeStudent.TakeExam();
        }
    }
}
