using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimofirsmo
{
    public abstract class Funcionário
    {
        public string Nome { get; set; }

        public abstract void CalcularSalario();

    }
}
