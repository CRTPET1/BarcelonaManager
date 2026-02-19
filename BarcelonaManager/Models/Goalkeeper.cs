using System;

namespace BarcelonaManager.Models
{
    // //dedovanje - Goalkeeper deduje od abstraktnega razreda PlayerBase
    // //vmesnik - implementira vmesnik ITransferable
    public class Goalkeeper : PlayerBase, ITransferable
    {
        // //lastnost - goli vratar v celi sezoni (zelo redki!)
        public int Goals { get; set; }

        // //konstruktor
        public Goalkeeper(string name, int age, decimal value)
            : base(name, age, value)
        {
            Position = "Goalkeeper";
            Goals = 0;
        }

        // //abstraktni razred - implementacija abstraktne metode iz PlayerBase
        public override decimal CalculateSalary()
        {
            return Value * 0.03m;
        }

        // //vmesnik - implementacija vmesnika ITransferable
        public bool CanBeTransferred()
        {
            return Age < 38;
        }

        // //vmesnik - implementacija vmesnika ITransferable
        public void Transfer(decimal amount)
        {
            Value += amount * 0.85m;
        }

        // //polimorfizem - prepisujemo ToString() iz PlayerBase
        public override string ToString()
        {
            return $"{Name} ({Position}) | {Age} let | {Value}M € | Goli: {Goals}";
        }
    }
}