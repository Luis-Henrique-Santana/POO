using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        // Método abstrato
        public abstract void FazerSom();
    }
  
    
}
