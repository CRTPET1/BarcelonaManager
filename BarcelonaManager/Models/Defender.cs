using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcelonaManager.Models
{
    public class Defender : PlayerBase, ITransferable
    {
        public Defender(string name, int age, decimal value)
            : base(name, age, value)
        {
            Position = "Defender";
        }

        public override decimal CalculateSalary()
        {
            return Value * 0.03m;
        }

        public bool CanBeTransferred()
        {
            return Age < 35;
        }

        public void Transfer(decimal amount)
        {
            Value += amount * 0.9m;
        }
    }
}

