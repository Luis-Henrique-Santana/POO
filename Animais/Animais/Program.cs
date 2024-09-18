using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animais = new List<Animal>
            {
                new Gato{Nome = "Sangan"},
                new Cachorro{Nome = "Kuriboh"}
            };
            foreach (var animal in animais)
            {
                animal.EmitirSom();
            }
            Console.ReadLine();
        }
    }
}
