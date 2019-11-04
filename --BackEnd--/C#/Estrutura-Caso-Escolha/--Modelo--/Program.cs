using System;

namespace CargosComSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Modelo--");
            //Objetivo: Fazer um programa que informe o salário do cargo escolhido.


            string resposta;

            Console.WriteLine("Digite o cód do cargo para descobrir o salario");
            Console.WriteLine("----------------------------");
            Console.WriteLine("(1) - Diretor");
            Console.WriteLine("(2) - Gerente");
            Console.WriteLine("(3) - Professor");
            Console.WriteLine("(4) - Coordenador");
            Console.WriteLine("(5) - Atendente");
            Console.WriteLine("----------------------------");

            resposta = Console.ReadLine();

            switch(resposta){
                case "1":
                Console.WriteLine("O salário de diretor é de R$ 18.000,00");
                break;

                case "2":
                Console.WriteLine("O salário de gerente é de R$ 14.000,00");
                break;

                case "3":
                Console.WriteLine("O salário de professor é de R$ 7.000,00");
                break;

                case "4":
                Console.WriteLine("O salário de coordenador é de R$ 9.000,00 ");
                break;

                case "5":
                Console.WriteLine("O salário de atendente é de R$ 1.800,00");
                break;

                default: //caso nenhum dos valores acima sejam informados
                Console.WriteLine("Por favor, informe um dos valores citados anteriormente!");
                break;


            }
        }
    }
}
