using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaBasica
{
    class Funcionario : Pessoa
    {
        public string Cargo;

        public void DefinirFuncionario(string cargo)
        {
            Cargo = cargo;
        }
        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome} Idade: {Idade} Cargo: {Cargo}");
        }

    }
}
