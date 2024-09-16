using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaBasica
{

    //Derivada herdando da animal
    class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine($"{Nome} está latindo");
        }
    }
}
