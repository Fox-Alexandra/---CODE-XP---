using System;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vetor");
            string [] nomes = new string [3];
            string [] telefones = new string [3];
            string [] emails = new string [3];


            int contador = 0;
            while (contador <= 2){
                Console.WriteLine("Digite seu nome");
                nomes [contador] = Console.ReadLine();

                Console.WriteLine("Digite seu telefone");
                telefones [contador] = Console.ReadLine();

                Console.WriteLine("Digite seu E-mail");
                emails [contador] = Console.ReadLine();
                contador++;
            }

            int contadorB = 0;
            while (contadorB <= 2){
                Console.WriteLine($"O cliente número {contadorB + 1} - Nome: {nomes[contadorB]}, tel {telefones [contadorB]}, E-mail: {emails[contadorB]}");
                contadorB++;
            }
        }
    }
}
