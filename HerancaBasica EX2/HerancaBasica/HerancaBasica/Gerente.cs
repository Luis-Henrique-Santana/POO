using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaBasica
{
    class Gerente : Funcionario
    {
        public string Departamento;

        public void DefinirDepartamento(string departamento)
        {
            Departamento = departamento;
            DefinirFuncionario("Gerente");
        }
        public void Exibir()
        {
            Console.WriteLine($"Nome: {Nome} Idade: {Idade} Cargo: {Cargo} Departamento:{Departamento}");
        }
    }
}
