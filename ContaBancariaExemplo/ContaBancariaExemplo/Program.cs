using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaExemplo
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria contaBancaria = new ContaBancaria();

            contaBancaria.DefinirLimiteSaque(400);
            contaBancaria.Depositar(10560);
            contaBancaria.Depositar(1030);
            contaBancaria.Depositar(1002);
            contaBancaria.Sacar(200);
            contaBancaria.Sacar(250);
            contaBancaria.Sacar(300);
            contaBancaria.Sacar(3000);
            contaBancaria.ExibirHistorico();

            Console.WriteLine($"O saldo total é: {contaBancaria.Saldo}");
            Console.ReadLine();            
        }
    }
}
