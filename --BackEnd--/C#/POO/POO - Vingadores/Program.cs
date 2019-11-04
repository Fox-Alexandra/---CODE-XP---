using System;
using POO___Vingadores.controllers;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {

            VingadoresController herois = new VingadoresController();

            int opcao = 0;

            do{
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White; // atribuir cor a letra no terminal
                Console.WriteLine($@"
                        -------Vingadores--------
                <------------------------------------->
                           Escolha Seu Heroi
                          1. Capit�o Am�rica
                          2. Homem de Ferro
                <------------------------------------->
                ");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                    //Capit�o America
                       herois.CapitaoAmerica();
                    break;

                    case 2:
                    //Homem de Ferro
                        herois.HomemDeFerro();
                    break;

                    default:
                    Console.WriteLine("Por favor escolha uma das op��es anterioes!");
                    break;
                }

            }while(opcao != 0);
        }
    }

}
