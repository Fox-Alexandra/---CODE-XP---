using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");
            //Objetivo: Fazer programa que apresente a tabuada do número pedido pelo usuário.


            System.Console.WriteLine("--------------------------");
            Console.WriteLine("informe qual tabuada deseja saber");
            int tabuada = int.Parse(Console.ReadLine());

            int limite=0;
            while (limite*tabuada<=tabuada*10){
                int resposta = tabuada*limite;
                Console.WriteLine($"{tabuada}X{limite}={resposta}");
                limite = limite + 1;

            }
        }
    }
}
