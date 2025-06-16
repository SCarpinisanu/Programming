using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Polymorphism
{
    public class ManagerTest
    {
        [Test]
        public void ManagerTestMethod()
        {
            // Create a Manager object
            var manager = new Manager("Alice", "Johnson", 35, 10, 5000.00m);
            // Display manager information
            manager.DisplayInfo();
            // Set and get team size
            manager.SetTeamSize(12);
            Console.WriteLine($"Updated Team Size: {manager.GetTeamSize()}");
            // Set and get bonus
            manager.SetBonus(6000.00m);
            Console.WriteLine($"Updated Bonus: {manager.GetBonus()}");
            // Call the base class method
            manager.IsEating();
        }
    }
}
