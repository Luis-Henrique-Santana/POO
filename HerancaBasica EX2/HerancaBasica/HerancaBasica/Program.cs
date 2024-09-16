using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O sistema de gestão de funcionários precisa agora representar diferentes tipos 
              de funcionários com responsabilidades específicas, como gerentes e desenvolvedores.


            Expanda o exercício anterior criando duas classes derivadas 
            de Funcionario: Gerente e Desenvolvedor. -
            A classe Gerente deve ter uma propriedade adicional Departamento, 
            e a classe Desenvolvedor deve ter uma propriedade LinguagemDeProgramacao. 
            Na classe Program, no método Main, crie instâncias de Gerente e Desenvolvedor, 
            defina seus atributos e exiba as informações no console..
            */
            while (true)
            {
                Desenvolvedor desenvolvedor = new Desenvolvedor();
                Gerente gerente = new Gerente();

                string nome, lp, departamento;
                int idade;
                Console.WriteLine("INSIRA UM NOME: ");
                nome = Console.ReadLine();

                Console.WriteLine("INSIRA UMA IDADE: ");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("INSIRA UMA Cargo (1) para gerente e (2) para desenvolvedor: ");
                int cargo = int.Parse(Console.ReadLine());
                if (cargo == 1)
                {
                    Console.WriteLine("INSIRA UM DEPARTAMENTO: ");
                    departamento = Console.ReadLine();

                    gerente.DefinirPessoa(nome, idade);
                    gerente.DefinirDepartamento(departamento);
                    gerente.Exibir();
                }
                else if (cargo == 2)
                {
                    Console.WriteLine("INSIRA UMA LINGUAGEM DE PROGRAMAÇÃO: ");
                    lp = Console.ReadLine();

                    desenvolvedor.DefinirPessoa(nome, idade);
                    desenvolvedor.DefinirLP(lp);
                    desenvolvedor.Exibir();
                }

                else
                {
                    Console.WriteLine("Tenta de novo");
                }
                Console.ReadLine();
            }
        }
    }
}
