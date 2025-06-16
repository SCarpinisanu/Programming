using System;

namespace Programming.Polymorphism
{
    public class Manager : Person
    {
        private int teamSize;
        private decimal bonus;

        public Manager(string firstName, string lastName, int age, int teamSize, decimal bonus)
            : base(firstName, lastName, age)
        {
            this.teamSize = teamSize;
            this.bonus = bonus;
        }

        public void SetTeamSize(int size)
        {
            teamSize = size;
        }

        public int GetTeamSize()
        {
            return teamSize;
        }

        public void SetBonus(decimal amount)
        {
            bonus = amount;
        }

        public decimal GetBonus()
        {
            return bonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {FirstName} {LastName}, Leads a team of {teamSize} people, Bonus: {bonus}");
        }
    }
}