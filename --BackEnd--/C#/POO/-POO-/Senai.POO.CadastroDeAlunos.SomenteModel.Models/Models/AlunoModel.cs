using System;

namespace Senai.POO.CadastroDeAlunos.SomenteModel.Models
{
    /// <summary>
    /// Modelo de aluno
    /// </summary>
    public class AlunoModel
    {
        /// <summary>
        /// Nome do aluno
        /// </summary>
        /// <value>string</value>
        public string Nome { get; set; }
        
        /// <summary>
        /// Nome do curso
        /// </summary>
        /// <value>string</value>
        public string Curso { get; set; }
        
        /// <summary>
        /// Rg do aluno
        /// </summary>
        /// <value>int</value>
        public int Rg { get; set; }
        
        /// <summary>
        /// Idade do aluno
        /// </summary>
        /// <value>int</value>
        /// 
    
        public int Idade { get; set; }

        public void CadastrarAluno(){
            System.Console.WriteLine("Insira seu nome:");
            Nome = Console.ReadLine();

            System.Console.WriteLine("Insira o nome de seu curso: ");
            Curso = Console.ReadLine();

            System.Console.WriteLine("Insira seu RG: ");
            Rg = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Insira sua idade: ");
            Idade = int.Parse(Console.ReadLine());
        }

          public void ListarAluno(){
            System.Console.WriteLine("Nome: " +Nome);
            System.Console.WriteLine("Curso: " +Curso);
            System.Console.WriteLine("RG: " +Rg);
            System.Console.WriteLine("Idade: " +Idade);
            }

            public void IrAoBanheiro(){
                Console.WriteLine(@"
                ==================================
                       QUERO IR AO BANHEIRO
                =================================="
                );
            }





    }
}