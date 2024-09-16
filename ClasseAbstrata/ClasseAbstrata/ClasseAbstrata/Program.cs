using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Animal meuGato = new Gato();
            Animal elefante = new Elefante();
            Animal leao = new Leao();
            Animal meuCachorro = new Cachorro();

            meuCachorro.Nome = "Rex";
            meuGato.Nome = "Mimi";
            elefante.Nome = "Brutus";
            leao.Nome = "Sangan";

            List<Animal> animais = new List<Animal>();

            animais.Add(meuGato);
            animais.Add(meuCachorro);
            animais.Add(elefante);
            animais.Add(leao);

            foreach(Animal animal in animais)
            {
                animal.FazerSom();
            }
 
            Console.ReadLine();
        }
    }
}
