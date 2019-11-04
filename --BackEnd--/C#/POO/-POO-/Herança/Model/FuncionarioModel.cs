using System;
using System.Collections.Generic;

namespace Herança.Model
{
    public class FuncionarioModel : PessoaModel //Herança (Funcionario herda de pessoa)
    {
        public string Cargo{get; set;}

        public void Trabalhar()
        {
            Console.WriteLine("Agora vamos trabalhar");
        }
        public FuncionarioModel CadastrarFuncionario()
        {
            FuncionarioModel funcionario = new FuncionarioModel();
           
            Console.WriteLine("Digite o Nome do funcionário:");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Idade do funcinário:");
            funcionario.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Cargo do funcionário:");
            funcionario.Cargo = Console.ReadLine();
     
            return funcionario;
        }
    }
}