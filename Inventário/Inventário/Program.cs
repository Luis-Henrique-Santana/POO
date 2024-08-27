using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventário
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("digite 1 para entrar e 0 para sair");
                int opcao;
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("opção invalida");
                    continue;

                }
                if (opcao == 0)
                {
                    Console.WriteLine("ok 😎👍");
                    break;

                }
                else if (opcao == 1)
                {
                    Console.WriteLine("ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Preco: ");
                    double preco = double.Parse(Console.ReadLine());

                    int valor = 0;
                    Inventario obj1 = new Inventario(id, nome, preco, valor);

                    // seleciona opção

                    while (true)
                    {
                        Console.WriteLine("digite 1 para Adicionar, 2 para Retirar, 3 para exibir e 0 para sair");
                        int opcao1;
                        if (!int.TryParse(Console.ReadLine(), out opcao1))
                        {
                            Console.WriteLine("opção invalida");
                            continue;

                        }
                        if (opcao1 == 0)
                        {
                            Console.WriteLine("ok 😎👍");
                            break;

                        }

                        else if (opcao1 == 2)
                        {
                            Console.WriteLine("Retirar: ");
                            valor = int.Parse(Console.ReadLine());
                            obj1.Sacar(valor);
                        }
                        else if (opcao1 == 1)
                        {
                            Console.WriteLine("Adicionar: ");
                            valor = int.Parse(Console.ReadLine());
                            obj1.Depositar(valor);
                        }
                        else if (opcao1 == 3)
                        {
                            obj1.Exibir();
                            /*
                            Console.WriteLine($"ID = {obj1.Id}");
                            Console.WriteLine($"Nome = {obj1.Nome}");
                            Console.WriteLine($"Quantidade = {obj1.Quantidade}");
                            Console.WriteLine($"Preco = {obj1.Preco}");*/
                        }




                    }



                }



            }
        }
    }
}
