using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimofirsmo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerente gerente = new Gerente();
            //Desenvolvedor desenvolvedor = new Desenvolvedor();

            List<Funcionário> funcionarios = new List<Funcionário>
            {
                new Gerente{ Nome = "Ana" },
                new Desenvolvedor {Nome = "Roberto"},
                new Desenvolvedor {Nome = "João"},
                new Gerente{ Nome = "betão" }
            };

            foreach (var funcionario in funcionarios)
            {
                funcionario.CalcularSalario(); // Polimorfismo
            }
            Console.ReadLine();

        }
    }
}
