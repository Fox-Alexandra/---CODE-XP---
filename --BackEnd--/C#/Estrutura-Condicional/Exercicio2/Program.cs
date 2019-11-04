using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 2 \n");
            //Objetivo: Fazer um programa que informe o maior e o menor número e se ele é par ou impar.


            int v1, v2; 
            string resposta1, resposta2;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Informe 2 números");
            Console.WriteLine("--------------------------------- \n");
            v1 = int.Parse(Console.ReadLine());
            v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------- \n");

            if (v1 % 2==0){ //resto 0 então é par
                resposta1 = "par";
            }else{                
                resposta1 = "impar";
                Console.WriteLine("--------------------------------- \n");
            }

            if (v2 % 2==0){                
                resposta2 = "par";
            }else{         
                resposta2 = "impar";
                Console.WriteLine("--------------------------------- \n");
            }

            if(v2>v1){
                
                Console.WriteLine($"O maior número é {v2} {resposta2} e o menor  é {v1} {resposta1}.\n");
                Console.WriteLine("---------------------------------");
            }else if(v1==v2){
                Console.WriteLine($"Os dois valores são iguais e são {resposta1}es\n");
                Console.WriteLine("--------------------------------- ");
            }else{
                Console.WriteLine($"O maior número é {v1} {resposta1} e o menor é {v2} {resposta2}.\n");
                Console.WriteLine("--------------------------------- ");
            }

        }
    }
}
