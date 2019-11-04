using System;

namespace Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Modelo--");
            //Objetivo: Fazer um programa que calcule a média do aluno.


            Console.WriteLine("APP de média escolar");
            string nome;
            double nota1;
            double nota2;
            double media;
            string resultado;

            Console.WriteLine("Digite seu Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite sua Nota 1: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua Nota 2: ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1+nota2)/2;

            if(media >= 7){
                resultado = "aprovado(a)";
            }else{
                resultado = "reprovado(a)";
            }

            Console.WriteLine($"Seu nome é {nome}, sua média foi de: {media} e você está {resultado}.");

        }
    }
}
