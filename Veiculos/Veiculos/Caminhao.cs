using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    class Caminhao : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine($"O caminhão {Placa} está Movendo.");
        }
    }
}
