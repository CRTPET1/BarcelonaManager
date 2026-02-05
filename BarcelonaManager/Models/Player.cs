using System;

namespace BarcelonaManager.Models
{
    public class Player : PlayerBase
    {
        public Player(string name, int age, decimal value)
            : base(name, age, value)
        {
            Position = "Generic";
        }

        public override decimal CalculateSalary()
        {
            return Value * 0.02m;
        }
    }
}
