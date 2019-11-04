using System;
using System.Collections.Generic;
using POO___Vingadores.models;
using System.Text;

namespace POO___Vingadores.controllers
{
    public class VingadoresController
    {
        public void CapitaoAmerica(){

            CAModelcs CA = new CAModelcs();
            CA.Vida = 360;
            CA.Cor = "Blue";
            CA.Escudo = "Escudo";

            Console.Clear();
            Console.WriteLine("---Capitão América---");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Vida {CA.Vida} HP");
            Console.WriteLine($"Poderes: {CA.Escudo}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Deseja continuar com o Capitão América? S/N");
            string resposta = Console.ReadLine();

            if(resposta == "S" || resposta == "s"){
                Console.Clear();
                Console.WriteLine("Dê um nome a sua equipe:");
                string equipe = Console.ReadLine();

                int opcao = 0;

                do{
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("---Capitão America---");
                    Console.WriteLine("1.Lançar escudo");
                    Console.WriteLine("2.Defender-se com o escudo");
                    Console.WriteLine("0. Sair");
                    opcao = int.Parse(Console.ReadLine());
                    Console.Clear();

                        switch(opcao){
                            case 1:
                            CA.Atacar();
                            break;

                            case 2:                            
                            CA.Defender();
                            break;

                            default:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Escolha uma opção válida!");
                            break;

                        }
                }while(opcao != 0);
            } //Fim If

        }//Fim Capitão America

        public void HomemDeFerro(){

            HFModel HF = new HFModel();
            HF.Vida = 360;
            HF.Cor = "Red";
            HF.Armadura = "Armadura";

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---Homem de Ferro---");
            Console.WriteLine($"Vida: {HF.Vida}HP");
            Console.WriteLine($"Poderes: {HF.Armadura}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Deseja continuar com o Homem de Ferro? S/N");
            string resposta = Console.ReadLine();

            if(resposta == "S" || resposta == "s"){
                Console.WriteLine("Dê um nome a sua equipe:");
                string equipe = Console.ReadLine();

                int opcao =0;

                do{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("---Homem de Ferro---");
                    Console.WriteLine("1.Voar");
                    Console.WriteLine("2.Atirar");
                    Console.WriteLine("0.Sair");
                    opcao = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch(opcao){
                        case 1:     
                        HF.Voar();
                        break;

                        case 2:
                        HF.Atirar();
                        break;

                        default:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Escolha uma opcção válida");
                        break;
                    }
                }while(opcao != 0);
            } //Fim If

        } //Fim Homem de Ferro
    }
}