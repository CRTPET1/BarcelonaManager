using System;

namespace BarcelonaManager.Models
{
    public class Player
    {
        // ===== PRIVATE polja =====
        private int goals;
        private int age;

        // ===== READONLY in CONST =====
        public const string Club = "FC Barcelona";       // const = enak za vse in nespremenljiv
        public readonly Guid PlayerId;                   // readonly = generiran v konstruktorju

        // ===== STATIC podatki =====
        public static int TotalPlayers { get; private set; }

        // ===== PROPERTY (lastnosti) =====
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Value { get; set; }               // vrednost igralca

        public int Goals
        {
            get => goals;
            set => goals = value >= 0 ? value : 0;       // enkapsulacija + validacija
        }

        public int Age
        {
            get => age;
            set => age = (value >= 16 && value <= 45) ? value : 18;
        }

        // ===== KONSTRUKTOR =====
        public Player(string name, string position, int age, decimal value)
        {
            Name = name;
            Position = position;
            Age = age;
            Value = value;
            Goals = 0;

            PlayerId = Guid.NewGuid();
            TotalPlayers++;
        }

        // ===== DESTRUKTOR =====
        ~Player()
        {
            TotalPlayers--;
        }

        // ===== PREOBLAGANJE OPERATORJEV =====
        public static bool operator >(Player a, Player b)
            => a.Value > b.Value;

        public static bool operator <(Player a, Player b)
            => a.Value < b.Value;

        public override string ToString()
        {
            return $"{Name} ({Position}) | {Age} let | {Value}M € | goli: {Goals}";
        }
    }
}
