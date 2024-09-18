using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public class VeiculoCombustao : Veiculo
    {
        public double NivelCombustivel { get; set; }
        public override void CalcularAutonomia()
        {
            Console.WriteLine($"Com {NivelCombustivel}L de Gasolina, a autonomia do Veiculo a combustão é: " + NivelCombustivel / 0.1 + "KM (considerando 10km por litro)");
        }
    }
}
