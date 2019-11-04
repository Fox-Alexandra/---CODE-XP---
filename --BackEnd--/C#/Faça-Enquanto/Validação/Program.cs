using System;

namespace Validação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação de Email");
            //Objetivo: O valor (email) inserido deve ser analisado e se ele tiver @ encerro meu programa, caso não tenha deve ser pedido novamente que o usuário informe um email correto. 

            string email;
                        
            do{
                Console.WriteLine("Digite seu email:");
                email = Console.ReadLine();
                
            }while (!((email.Contains("@")) && (email.Contains(".com")))); // Contains é um bool (retorna verdadeiro ou falso). Eu quero que meu email só seja validado se nele houver um "@" e um ".com" para isso vou usar o ".Contains" e usa-se o "false" porque se ele for verdadeiro ele vai manter o luping, ao atribuir o valor como falso eu encerro o luping no "Do While".
        }
    }
}
