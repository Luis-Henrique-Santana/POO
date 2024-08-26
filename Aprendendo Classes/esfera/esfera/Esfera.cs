using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esfera
{
    class Esfera
    {
        // Atributos 

        private double raio = 0;
        

        // Metodos
        public void Limpa()
        {

            raio = 0;

        }

        public void Imprimir()
        {
            Console.WriteLine($"Raio = {raio}"); ;
            Console.WriteLine($"Volume = {Volume()}");
        }


        public double Volume()
        {

            return (4 * Math.PI * Math.Pow(raio, 3))/3; 
        }

        public bool Novo(double l2)
        {

            raio = l2;
           
            return true;
        }
    }
}
