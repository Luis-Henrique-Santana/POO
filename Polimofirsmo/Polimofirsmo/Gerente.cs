using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimofirsmo
{
    public class Gerente : Funcionário
    {
        public override void CalcularSalario()
        {
            Console.WriteLine($"{Nome} (Gerente) Recebeu o salário de R$5.000,00");
        }
    }
}
