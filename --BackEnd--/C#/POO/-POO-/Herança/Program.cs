using System;
using System.Collections.Generic;
using Herança.Model;

namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma lista vazia de funcionarios
            List<FuncionarioModel> ListaDeFuncionarios = new List<FuncionarioModel>(); 
            
            Console.WriteLine("Aprendendo Herança");

            FuncionarioModel funcionario = new FuncionarioModel();
            ProfessorModel professor = new ProfessorModel();
            int opcao;

            do{
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Cadastrar Funcionário");
                Console.WriteLine("2. Executar ações");
                Console.WriteLine("0. Sair");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                    //cadastrar                    
                    FuncionarioModel FuncionariosCadastrados = funcionario.CadastrarFuncionario();
                    ListaDeFuncionarios.Add(FuncionariosCadastrados);

                    //Vamos Listar
                    foreach(var item in ListaDeFuncionarios)
                    {
                        Console.WriteLine(@"------------------------------------------------");
                        Console.WriteLine($@"   Funcionário: {item.Nome} - Cargo: {item.Cargo}");
                        Console.WriteLine(@"------------------------------------------------");
                    }
                    break;

                    case 2:
                    //Executar
                        int acao = 0;
                        do{
                            Console.WriteLine($"Selecione uma ação para {funcionario.Nome}");
                            Console.WriteLine("1 - Andar");
                            Console.WriteLine("2 - Correr");
                            Console.WriteLine("3 - Trabalhar");
                            Console.WriteLine("0 - Sair");
                            acao = int.Parse(Console.ReadLine());

                            switch (acao){
                                case 1:
                                    funcionario.Andar();
                                break;

                                case 2:
                                    funcionario.Correr();
                                break;

                                case 3:
                                    funcionario.Trabalhar();
                                break;

                                case 0:
                                    Console.WriteLine("Tchau!!!");
                                break;

                                default:
                                    Console.WriteLine("Opção inválida");
                                break;
                            }
                        }while(acao != 0);

                    break;

                    case 0:
                    //Sair
                    break;

                    default:
                    //diferente de 1, 2 e 0
                    break;
                }

            }while(opcao != 0);

            professor.Nome = "Alexandra";
            professor.Idade = 22;
            professor.Turma = "CodeXP";
            professor.AreaDeAtuacao = "Desenvolvimento";
            
        }
    }
}
