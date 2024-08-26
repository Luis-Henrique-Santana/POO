using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro
{
    class Cilindro
    {
        // Atributos 
       
        private double lado2 = 0;
        private double lado3 = 0;

        // Metodos
        public void Limpa()
        {
            
            lado2 = 0;
            lado3 = 0;

        }

        public void Imprimir()
        {
            Console.WriteLine($"Raio = {lado2} | Altura = {lado3}"); ;
            Console.WriteLine($"Volume = {Volume()}");
        }


        public double Volume()
        {

            return 3.14 * (lado2*lado2) * lado3;
        }

        public bool Novo(double l2, double l3)
        {
           
            lado2 = l2;
            lado3 = l3;
            return true;
        }
    }
}
