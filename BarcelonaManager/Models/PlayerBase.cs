using System;

namespace BarcelonaManager.Models
{
    public abstract class PlayerBase : Entity
    {
        public string Name { get; set; }
        public string Position { get; protected set; }
        public int Age { get; set; }
        public decimal Value { get; set; }

        // ===== KARIERNE STATISTIKE =====
        // Skupaj goli skozi vso kariero v klubu
        public int CareerGoals { get; set; }
        // Skupaj asistence skozi vso kariero v klubu
        public int CareerAssists { get; set; }
        // Koliko sezon je že v klubu
        public int SeasonsAtClub { get; set; }

        protected PlayerBase(string name, int age, decimal value)
        {
            Name = name;
            Age = age;
            Value = value;
            CareerGoals = 0;
            CareerAssists = 0;
            SeasonsAtClub = 0;
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