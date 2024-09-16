using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal meuCachorro = new Cachorro();
            meuCachorro.Nome = "Rex";
            meuCachorro.FazerSom(); // Método sobrescrito na classe Cachorro
            Animal meuGato = new Gato();
            meuGato.Nome = "Mimi";
            meuGato.FazerSom(); // Método sobrescrito na classe Gato
        }
    }
}
