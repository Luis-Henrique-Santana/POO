using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    class Onibus : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine($"O onibus {Placa} está Movendo.");
        }
    }
}
