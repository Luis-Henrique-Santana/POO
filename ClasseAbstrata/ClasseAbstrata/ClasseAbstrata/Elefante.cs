﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    class Elefante : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine($"{Nome} está Bramindo");
        }
    }
}
