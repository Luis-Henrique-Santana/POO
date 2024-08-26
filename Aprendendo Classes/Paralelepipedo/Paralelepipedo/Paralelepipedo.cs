using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralelepipedo
{
    class Paralelepipedo
    {
        // Atributos 
        private double lado1 = 0;
        private double lado2 = 0;
        private double lado3 = 0;

        // Metodos
        public void Limpa()
        {
            lado1 = 0;
            lado2 = 0;
            lado3 = 0;
           
        }

        public void Imprimir()
        {
            Console.WriteLine($"Comprimento = {lado1} | Diâmetro = {lado2} | Largura = {lado3}");;
            Console.WriteLine($"Volume = {Volume()}");
        }

   
        public double Volume()
        {
            
            return lado1 * lado2 * lado3 ;
        }

        public bool Novo(double l1, double l2, double l3)
        {
            lado1 = l1;
            lado2 = l2;
            lado3 = l3;
            return true;
        }
    }
}
