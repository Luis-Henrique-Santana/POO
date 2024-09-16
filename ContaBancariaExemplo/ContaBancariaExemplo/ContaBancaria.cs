using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaExemplo
{
    class ContaBancaria
    {
        private decimal saldo;

        public decimal Saldo { get { return saldo; } }


        private decimal limiteSaqueDiario;


        private List<string> historicoTransacoes = new List<string>();

        public void DefinirLimiteSaque(decimal limite)
        {
            limiteSaqueDiario = limite;
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
            historicoTransacoes.Add($" Deposito de {valor} realizado");
        }
        public void Sacar(decimal valor)
        {
            if (valor <= limiteSaqueDiario)
            {
                saldo -= valor;

                historicoTransacoes.Add($" Deposito de {valor} realizado");
            }
            else
                Console.WriteLine("valor de saque ultrapassado");
        }

        public void ExibirHistorico()
        {
            foreach (string h in historicoTransacoes)
            {
                Console.WriteLine(" " + h + " ");
            }
        }
    }
}
