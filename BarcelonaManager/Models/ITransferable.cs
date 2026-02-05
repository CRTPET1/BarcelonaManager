using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcelonaManager.Models
{
    public interface ITransferable
    {
        bool CanBeTransferred();
        void Transfer(decimal amount);
    }
}
