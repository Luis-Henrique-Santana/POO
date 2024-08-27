using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventário
{
    class Inventario
    {
        //atri
        
        //propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        //metodos

        //depositar ------------------
        public void Depositar(int Valor)
        {    
            if(Valor > 0)
            {
                Quantidade = Quantidade + Valor;
                Console.WriteLine("Valor " + Valor + " Quantidade " + Quantidade);
            }
            else
            {
                Console.WriteLine("Adicionar negativo não funfa");
               
            }

            
        }
        //Sacar ------------
        public void Sacar(int Valor)
        {
            
            if (Valor <= Quantidade)
            {
                Quantidade = Quantidade - Valor;
                
            }
            else
            {
                Console.WriteLine("quantidade menor que retirada");
                
            }
            Console.WriteLine("Valor " + Valor + " Quantidade " + Quantidade);
        }

        //exibir -----------
        public void  Exibir()
        {
            Console.Write(" ID: " + Id);
            Console.Write(" Nome: " + Nome);
            Console.Write(" Quantidade: " + Quantidade);
            
        }


        //construtor
        public Inventario(int id, string nome, double preco, int valor )
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }


    }
}
