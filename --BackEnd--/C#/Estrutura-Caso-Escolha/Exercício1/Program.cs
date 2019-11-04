using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios 18.09");
            Console.WriteLine("Exercício 01");
            //Objetivo: Fazer um programa em que o usuário informe dois numeros e escolha dentre as opções uma operação.


            int n1, n2, soma, sub, mult, div;
            string resposta;

            Console.WriteLine("------------------------");

            Console.WriteLine("Infome 2 números");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------");
            Console.WriteLine("a. Soma de 2 números");
            Console.WriteLine("b. Subtração do primeiro pelo segundo");
            Console.WriteLine("c.Subtração do Segundo pelo Primeiro");
            Console.WriteLine("d.Multiplicação dos dois números");
            Console.WriteLine("e.Divisão do Primeiro pelo Segundo");
            Console.WriteLine("f.Divisão do Segundo pelo Primeiro");
            Console.WriteLine("------------------------");

            Console.WriteLine("Escolha uma das opções anteriores");
            resposta = Console.ReadLine();
            switch(resposta){
                case "a":
                soma = n1+n2;
                Console.WriteLine("O resultado da opção 'a' é "+soma);
                break;

                case "b":
                sub = n1-n2;
                Console.WriteLine("O resultado da opção 'b' é "+sub);
                break;

                case "c":
                sub = n2-n1;
                Console.WriteLine("O resultado da opção 'c' é "+sub);
                break;

                case "d":
                mult = n1*n2;
                Console.WriteLine("O resultado da opção 'd' é "+mult);
                break;

                case "e":
                div = n1/n2;
                Console.WriteLine("O resultado da opção 'e' é "+div);
                break;

                case "f":
                div = n2/n1;
                Console.WriteLine("O resultado da opção 'f' é "+div);
                break;

                default:
                Console.WriteLine("Por favor escolha uma das opções informadas anteriormente no MENU");
                break;

            }


        }
    }
}
