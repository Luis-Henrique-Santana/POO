using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    class Program
    {
        static void Main(string[] args)
        {

            Veiculo carro = new Carro();
            Veiculo moto = new Moto();
            Veiculo onibus = new Onibus();
            Veiculo caminhao = new Caminhao();

            carro.Placa = "abc1232";
            moto.Placa = "cdg3219";
            onibus.Placa = "XJG9273";
            caminhao.Placa  = "bcs2211";

            List<Veiculo> animais = new List<Veiculo>();

            animais.Add(carro);
            animais.Add(moto);
            animais.Add(caminhao);
            animais.Add(onibus);

            foreach (Veiculo veiculo in animais)
            {
                veiculo.Mover();
            }

            Console.ReadLine();

        }
    }
}
