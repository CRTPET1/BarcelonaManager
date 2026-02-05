using System;

namespace BarcelonaManager.Models
{
    public abstract class PlayerBase : Entity
    {
        public string Name { get; set; }
        public string Position { get; protected set; }
        public int Age { get; set; }
        public decimal Value { get; set; }

        protected PlayerBase(string name, int age, decimal value)
        {
            Name = name;
            Age = age;
            Value = value;
        }

        // abstraktna metoda → MORA biti implementirana v podrazredih
        public abstract decimal CalculateSalary();

        // polimorfizem
        public override string ToString()
        {
            return $"{Name} ({Position}) | {Age} let | {Value}M €";
        }
    }
}
