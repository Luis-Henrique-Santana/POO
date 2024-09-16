using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaBasica
{
    class Desenvolvedor : Funcionario
    {
        public string LinguagemDeProgramacao;

        public void DefinirLP(string lp)
        {
            LinguagemDeProgramacao = lp;
            DefinirFuncionario("Desenvolvedor");
        }
        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome} Idade: {Idade} Cargo: {Cargo} Linguagem de programação: {LinguagemDeProgramacao}");
        }
    }
}
