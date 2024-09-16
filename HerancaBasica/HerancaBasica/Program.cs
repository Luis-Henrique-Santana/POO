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
            /*Uma empresa deseja criar um sistema simples para gerenciar 
             * informações básicas dos funcionários. Para isso, 
             * você deve utilizar o conceito de herança para organizar as informações de forma eficiente.

            Crie uma classe base Pessoa com as propriedades 
            Nome e Idade. Em seguida, crie uma classe Funcionario 
            que herde de Pessoa e adicione uma propriedade Cargo.
            Na classe Program, no método Main, crie uma instância de Funcionario, 
            defina os valores de Nome, Idade e Cargo, e exiba essas informações no console.*/

            Funcionario funcionario = new Funcionario();
            string nome, cargo;
            int idade;
            Console.WriteLine("INSIRA UM NOME: ");
            nome = Console.ReadLine();

            Console.WriteLine("INSIRA UMA IDADE: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("INSIRA UM CARGO: ");
            cargo = Console.ReadLine();

            funcionario.DefinirPessoa(nome,idade);
            funcionario.DefinirFuncionario(cargo);
            funcionario.Exibir();
            Console.ReadLine();

            
        }
    }
}
