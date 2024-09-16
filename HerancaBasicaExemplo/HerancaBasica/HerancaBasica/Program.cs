using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro meuCachorro = new Cachorro();
            meuCachorro.Nome = "Rex";
            meuCachorro.Comer(); // metodo herdado do animal
            meuCachorro.Latir(); // metodo original da classe
            Console.ReadLine();
        }
    }
}
