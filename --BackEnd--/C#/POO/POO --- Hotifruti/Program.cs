using System;
using Hotifruti___POO.Controller;

namespace poo
{
    /// <summary>
    ///Atividade para treinar o MCV
    ///</summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HortiFruti");

            hortifrutiController hortifruti = new hortifrutiController();
            int opcao = 0;

            do{
                Console.WriteLine(@"
                ----------------------------------------
                   Escolha uma das seguintes opções:
                ----------------------------------------
                        1. Cadastrar um produto
                        2. Listar produtos
                        3. Somar o valor dos produtos
                        0. Sair
                <--------------------------------------->
                ");

                opcao = int.Parse(Console.ReadLine());

                switch(opcao){
                    case 1:
                    //cadastrar
                        hortifruti.CadastroProdutos();
                    break;

                    case 2:
                    //Listar
                        hortifruti.ListarProdutos();
                    break;

                    case 3:
                    //somar
                        hortifruti.SomarProdutos();
                    break;

                    case 0:
                    //sair
                        Console.WriteLine("Obrigada por utilizar nosso sistema!");
                    break;

                    default:
                        Console.WriteLine("Opção inválida");
                    break;
                }

            }while(opcao != 0);
        }
    }
}
