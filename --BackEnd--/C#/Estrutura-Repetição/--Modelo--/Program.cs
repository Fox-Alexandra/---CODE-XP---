using System;

namespace EstruturaDeRepetição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Modelo--");
            //Objetivo: Definit uma número para inicio da contagem e um para o fim da contagem.

            int contador, limite;

            Console.WriteLine("Digite o número inicial:");
            contador = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor limite:");
            limite = int.Parse(Console.ReadLine());
            

            while (contador <= limite){
                Console.WriteLine(contador);
                contador = contador + 1;
            }
        }
    }
}
