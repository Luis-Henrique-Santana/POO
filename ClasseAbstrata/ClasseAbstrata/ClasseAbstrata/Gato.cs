using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"{Nome} está miando.");
        }
    }
}
