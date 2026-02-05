using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcelonaManager.Models
{
    public class Forward : PlayerBase, ITransferable
    {
        public int Goals { get; set; }

        public Forward(string name, int age, decimal value)
            : base(name, age, value)
        {
            Position = "Forward";
        }

        public override decimal CalculateSalary()
        {
            return Value * 0.05m + Goals * 100_000;
        }

        public bool CanBeTransferred()
        {
            return Age < 33;
        }

        public void Transfer(decimal amount)
        {
            Value += amount;
        }
    }
}

