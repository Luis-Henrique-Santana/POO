using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    public class VeiculoEletrico : Veiculo
    {
        public double NivelBateria { get; set; }
        public override void CalcularAutonomia()
        {
            Console.WriteLine($"Com {NivelBateria}kWh de bateria, a autonomia do Veiculo elétrico é: " + NivelBateria/0.15 + "KM (Considerando 0,15kWh por KM)" );
        }
    }
}
