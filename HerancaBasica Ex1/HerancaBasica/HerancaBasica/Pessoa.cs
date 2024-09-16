using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaBasica
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public void DefinirPessoa(string nome, int idade)
        {
            Idade = idade;
            Nome = nome;
        }

    }
}
