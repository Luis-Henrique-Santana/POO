using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public abstract class Veiculo
    {

        public string Placa { get; set; }
        // Método abstrato
        public abstract void Mover();

    }
}
