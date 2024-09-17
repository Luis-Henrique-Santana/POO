using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento
{
    public class PagamentoDinheiro : Pagamento
    {
        public override void RealizarPagamento()
        {

            Console.WriteLine($"Pagamento de {Valor} realizado em dinheiro.");
        }
    }
}
