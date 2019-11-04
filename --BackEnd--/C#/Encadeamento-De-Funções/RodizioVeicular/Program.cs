using System;

namespace RodizioVeicular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encadeamento de Funções");
            //Objetivo: Fazer um programa que leia a placa do carro, encontre o ultimo número e informe o dia de rodizio deste carro.

            string placa;
            int caracteres;
            int final;

            Console.WriteLine("Informe sua placa:");
            placa = (Console.ReadLine());

            caracteres = placa.Length; //Conta quantos caracteres tem a variavel
            final = int.Parse(placa.Substring(caracteres-1)); //removo 6 caracteres deixando apenas um na variavel que é o caractere que vou utiliza para definir minha categoria

            if(final<=1){
            Console.WriteLine("Seu rodízio é na segunda-feira");
            }else if(final==2 || final==3){
                Console.WriteLine("Seu rodízio é na terça-feira");
            }else if(final==4 || final==5){
                Console.WriteLine("Seu rodízio é na quarta-feira");
            }else if(final==6 || final==7){
                Console.WriteLine("Seu rodízio é na quinta-feira");
            }else{
                Console.WriteLine("Seu rodízio é na sexta-feira");
            }
        }
    }
}
