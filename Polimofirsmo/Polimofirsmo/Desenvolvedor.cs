using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimofirsmo
{
    public class Desenvolvedor : Funcionário
    {
        public override void CalcularSalario()
        {
            Console.WriteLine($"{Nome} (Desenvolvedor) Recebeu o salário de R$18.000,00");
        }
    }
}
