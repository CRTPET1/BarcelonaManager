using System;

namespace BarcelonaManager.Models
{
    // //dedovanje - Midfielder deduje od abstraktnega razreda PlayerBase
    // //vmesnik - implementira vmesnik ITransferable
    public class Midfielder : PlayerBase, ITransferable
    {
        // //lastnost - število podaj v sezoni
        public int Assists { get; set; }

        // //lastnost - število golov (vezisti dajo manj golov kot napadalci)
        public int Goals { get; set; }

        // //konstruktor
        public Midfielder(string name, int age, decimal value)
            : base(name, age, value)
        {
            Position = "Midfielder";
            Assists = 0;
            Goals = 0;
        }

        // //abstraktni razred - implementacija abstraktne metode iz PlayerBase
        public override decimal CalculateSalary()
        {
            return Value * 0.04m + Assists * 50_000;
        }

        // //vmesnik - implementacija vmesnika ITransferable
        public bool CanBeTransferred()
        {
            return Age < 34;
        }

        // //vmesnik - implementacija vmesnika ITransferable
        public void Transfer(decimal amount)
        {
            Value += amount * 0.95m;
        }

        // //polimorfizem - prepisujemo metodo iz PlayerBase
        public override string ToString()
        {
            return $"{Name} ({Position}) | {Age} let | {Value}M € | Goli: {Goals} | Podaje: {Assists}";
        }
    }
}