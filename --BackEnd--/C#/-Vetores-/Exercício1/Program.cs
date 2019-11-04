using System;

namespace Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 01");

            string [] produtos = new string [6]; // Aqui fica o meu vetor
             
            int contador=0;
            while(contador<6){
            Console.WriteLine("Informe um item que deseja comprar:");
            produtos [contador] = Console.ReadLine();
            contador++; // Precisa ser assim para que o contador nao fique no 0 infinitamente
            }
            
            Console.WriteLine("----------Lista de compras-------------");

            contador = 0;
            while(contador <6){
            Console.WriteLine($"item {contador+1}: {produtos[contador]}");
            contador++;
            }
        }
    }
}
