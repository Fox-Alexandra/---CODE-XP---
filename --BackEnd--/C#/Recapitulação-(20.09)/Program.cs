using System;

namespace Exercicio_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recapitulação");
            //Objetivo: Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino, e Data do voo de 5 passageiros.             O sistema deve exibir um menu com as seguintes opções:                                                              1. Cadastrar passagem                                                                                     2. Listar passagens                                                                                       3. Sair                                                                                         Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrario voltar ao menu anterior.

            string [] nome = new string [5];
            string [] origem = new string [5];
            string [] destino = new string [5];
            DateTime [] data = new DateTime [5];

            int contador = 0;
            int opcao= 0;
            string resposta = "";

            do{
               Console.WriteLine("------------------------");
               Console.WriteLine("Selecione uma opção:");
               Console.WriteLine("1. Cadastrar Passagem"); 
               Console.WriteLine("2. Listar Passagens"); 
               Console.WriteLine("0. Sair"); 
               Console.WriteLine("------------------------"); 
               opcao = int.Parse(Console.ReadLine());          

                switch(opcao){
                    case 1:
                        Console.WriteLine("Vamos cadastrar agora");

                        do{
                            if(contador < 2){
                                Console.WriteLine("Informe o nome do passageiro:");
                                nome [contador] = Console.ReadLine();

                                Console.WriteLine("Informe a origem:");
                                origem [contador] = Console.ReadLine();

                                Console.WriteLine("Informe o destino:");
                                destino [contador] = Console.ReadLine(); 

                                Console.WriteLine("Informe a data da viagem:");
                                data [contador] = DateTime.Parse(Console.ReadLine());

                                Console.WriteLine("Deseja cadastrar uma nova passagem? S/N");
                                resposta = Console.ReadLine();
                                contador ++;
                            }else{
                                Console.WriteLine("Numero de passagens excedido!");
                            break; // para nao entrar em luping infinito
                            }

                        }while(resposta != "N");
                    break;

                    case 2:
                        Console.WriteLine("Listando as Passagens");
                        int contadorB = 0;
                        while(contadorB <2){
                            Console.WriteLine($"Passageiro nome: {nome[contadorB]}, Origem - {origem[contadorB]}, Destino - {destino[contadorB]} - {data[contadorB]}.");
                            contadorB++;
                        }
                    break;

                    case 0:
                        Console.WriteLine("Obrigada por usar nosso sistema!");
                    break;

                    default:
                        Console.WriteLine("Opção inválida! Selecione uma das seguintes opções:");
                    break;
                }   

            }while (opcao !=0); //   "!=" siginifica "diferente"

            
        }
    }
}
