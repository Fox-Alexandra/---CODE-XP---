using System;

namespace CalculoDeMédia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de média");
            //Objetivo: Fazer um programa que calcule a media de um aluno.

            int n1;
            int n2;
            int n3;
            float media;
            float soma;

            Console.WriteLine("Digite a nota 1:"); //Saída = Mostra a informação na tela
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2:");
            n2 = int.Parse(Console.ReadLine()); // entrada = A informação é inserida na máquina

            Console.WriteLine("Digite a nota 3:");
            n3 = int.Parse(Console.ReadLine()); //Int.Parse é o conversor de string em um inteiro

            soma = (n1+n2+n3);
            media = soma/3; //Processamento

            Console.WriteLine($"A média é: {media}"); // Saída
        }
    }
}
