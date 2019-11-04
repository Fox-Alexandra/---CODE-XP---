using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("23.09");
            //Objetivo: Escreva um programa que receba a idade de 10 pessoas, calcule e imprima a quatidade de pessoas maiores de idade e menores de idade.

            int[] idade = new int[10];
            int contA=0, contB=0, contC=0;

            do{
            Console.WriteLine("Informe sua idade");
            idade [contA] = int.Parse(Console.ReadLine());

                if (idade[contA]<=17){
                    contB = contB+1;
                }else{
                    contC = contC+1;
                }
            contA++;

            }while (contA < 10);
            Console.WriteLine($"menor de idade = {contB}");
            Console.WriteLine($"maior de idade = {contC}");


            Console.WriteLine("23.09");
            //Objetivo: Faça um programa que receba duas notas de 10 alunos e armazene essas notas em 2 vetores. calcule e imprima.
            double[] n1 = new double[10];
            double[] n2 = new double[10];
            double[] media = new double[10];
            double somaMedia = 0;
            int contadorA = 0;
            int contadorB = 0;
            int contador = 0;

            do{
                Console.WriteLine("Informe sua nota1 e nota2 respectivamente: ");
                n1[contador]=double.Parse(Console.ReadLine());
                n2[contador]=double.Parse(Console.ReadLine());

                media[contador] = (n1[contador]+n2[contador])/2;

                if(media[contador]>=7){
                    contadorA=contadorA+1;
                }else{
                    contadorB=contadorB+1;
                }   
                contador++;
            }while(contador<10);

            contador = 0;
            while(contador<10){
                somaMedia = somaMedia + media[contador];
                contador++;
            }
            Console.WriteLine($"A média da turma foi: {somaMedia/contador}.");
            Console.WriteLine($"Aprovados {contadorA} \n Reprovados {contadorB}");

        }
    }
}
