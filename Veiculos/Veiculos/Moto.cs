using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    class Moto : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine($"A moto {Placa} está Movendo.");
        }
    }
}
