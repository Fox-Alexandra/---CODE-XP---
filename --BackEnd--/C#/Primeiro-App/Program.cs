using System;

namespace PrimeiroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui é onde iremos inserir o cod.
            Console.WriteLine("soma de dois numeros");
            int n1;
            int n2;
            int resp;

            Console.WriteLine("Digte o primeiro número:");
            n1=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            n2 = int.Parse(Console.ReadLine());

            resp=n1+n2;

            // Console.WriteLine("A soma das duas váriaveis é: "+resp); ou
            Console.WriteLine($"O resultado é: {resp}");

        }

    }
}
