using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Cilindro cil = new Cilindro();
            while (true)
            {
                Console.WriteLine("0 - Encerrar");
                Console.WriteLine("1 - Imprimir (*)");
                Console.WriteLine("2 - Definir um novo paralelepípedo");
                Console.WriteLine(" ---------------------------------------------");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    break;
                }
                else if (opcao == 1)
                {
                    cil.Imprimir();
                }

                else if (opcao == 2)
                {
                    Console.WriteLine("Raio 2: ");
                    double l2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Altura 3: ");
                    double l3 = double.Parse(Console.ReadLine());

                    if (cil.Novo(l2, l3))
                    {
                        Console.WriteLine("Criado!!!");
                    }
                    else
                    {
                        Console.WriteLine("Erro");
                    }
                }
                else
                {
                    Console.WriteLine("Numero invalido");
                }
            }
        }
    }
}
