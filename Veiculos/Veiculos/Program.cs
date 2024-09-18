using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> veiculos = new List<Veiculo>
            {
                new VeiculoCombustao {NivelCombustivel = 15.2},
                new VeiculoEletrico{NivelBateria = 12.3}
            };

            foreach(var veiculo in veiculos)
            {
                veiculo.CalcularAutonomia();
            }
            Console.ReadLine();
        }
    }
}
