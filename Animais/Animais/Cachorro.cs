using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    public class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"O cachorro {Nome} latiu!");
        }
    }
}
