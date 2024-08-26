using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    class ContaCorrente
    {
        //atri
        
        //propriedades
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double Deposito { get; set; }
        public double Saque { get; set; }

        //metodos
        public void Depositar(double valor)
        {

            
            if(valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("depositar negativo não funfa");
               
            }

            
        }
        public void Sacar(double valor)
        {
            
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("ta pobre irmão");
                
            }
            
        }
        public void  Exibir()
        {
            Console.Write(Saldo);
        }


        //construtor
        public ContaCorrente(int numeroconta, string titular, double SaldoInicial, double deposito, double saque)
        {

            NumeroConta = numeroconta;
            Titular = titular;
            Saldo = SaldoInicial;
            Deposito = deposito;
            Saque = saque;

            

        }

        

    }
}