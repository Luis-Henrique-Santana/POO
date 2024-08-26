using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
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
                    Console.WriteLine("Numero de conta: ");
                    int numeroconta = int.Parse(Console.ReadLine());

                    Console.WriteLine("Titular: ");
                    string titular = Console.ReadLine();

                  
                    double SaldoInicial = 0;
                    double deposito = 0;
                    double saque = 0;

                    ContaCorrente obj1 = new ContaCorrente(numeroconta, titular, SaldoInicial,deposito ,saque);

                    // seleciona opção

                    while (true)
                    {
                        Console.WriteLine("digite 1 para sacar, 2 para depositar, 3 para exibir e 0 para sair");
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

                        else if (opcao1 == 1)
                        {
                            Console.WriteLine("Sacar: ");
                            saque = double.Parse(Console.ReadLine());
                            obj1.Sacar(saque);
                        }
                        else if (opcao1 == 2)
                        {
                            Console.WriteLine("Depositar: ");
                            deposito = double.Parse(Console.ReadLine());
                            obj1.Depositar(deposito);
                        }
                        else if (opcao1 == 3)
                        {
                            Console.WriteLine($"numero da conta = {obj1.NumeroConta}");
                            Console.WriteLine($"Titular = {obj1.Titular}");
                            Console.WriteLine($"Saldo = {obj1.Saldo}");
                        }




                    }



                }
            }
            

        }
    }
}
