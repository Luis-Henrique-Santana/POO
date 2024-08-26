using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esfera
{
    class Program
    {
        static void Main(string[] args)
        {

            Esfera esf = new Esfera();
            while (true)
            {
                Console.WriteLine("0 - Encerrar");
                Console.WriteLine("1 - Imprimir (*)");
                Console.WriteLine("2 - Definir uma nova Esfera");
                Console.WriteLine(" ---------------------------------------------");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 0)
                {
                    break;
                }
                else if (opcao == 1)
                {
                    esf.Imprimir();
                }

                else if (opcao == 2)
                {
                    Console.WriteLine("Raio: ");
                    double l2 = double.Parse(Console.ReadLine());

                    if (esf.Novo(l2))
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
