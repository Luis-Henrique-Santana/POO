using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pagamento> pagamentos = new List<Pagamento>
            {
                new PagamentoCartao{ Valor = "200"},
                new PagamentoDinheiro{ Valor = "350" }
            };

            foreach(var pagamento in pagamentos)
            {
                pagamento.RealizarPagamento();
            }
            Console.ReadLine();
        }
    }
}
