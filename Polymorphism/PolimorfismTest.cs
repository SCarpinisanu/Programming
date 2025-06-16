using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Polymorphism
{
    public class PolimorfismTest
    {
        [Test]
        public void PolimorfismTestMethod()
        {
            Student student = new Student("Maria", "Popescu", 25, "UBB Cluj", "Mathematic", true);
            student.IsEating();
            student.DisplayInfo();
        }

        public int Adding(int a, int b)
        {
            return a + b;
        }

        public int Adding(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Adding(double a, double b)
        {
            return a + b;
        }
    }
}
