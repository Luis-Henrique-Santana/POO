using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos 
{
    class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine($"O carro{Placa} está Movendo.");
        }
    }
}
