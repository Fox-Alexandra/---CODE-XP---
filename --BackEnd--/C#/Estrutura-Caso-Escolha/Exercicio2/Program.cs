using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Case exercicio 2\n");
            //Objetivo: Fazer um programa que informe o nome, o salário e o ajuste salarial de acordo com o cargo escolhido.


            Console.WriteLine("---------------------------\n");
            string nome, resposta;
            decimal salario;
            decimal aumento;

            Console.WriteLine("Informe seu Nome completo:");
            nome = Console.ReadLine();
            
            Console.WriteLine("\nInforme seu salário atual:");
            salario = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEscolha uma das seguintes opções:");
            
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("(1) -- Escrituário -- 50%");
            Console.WriteLine("(2) --  Secretário -- 35%");
            Console.WriteLine("(3) --    Caixa    -- 20%");
            Console.WriteLine("(4) --    Gerente  -- 10%");
            Console.WriteLine("(5) --    Diretor  -- 0");
            Console.WriteLine("---------------------------\n");

            resposta = Console.ReadLine();
            switch(resposta){
                case "1":
                aumento = salario + (salario*50/100);
                Console.WriteLine($"{nome}, Seu salário será de R${aumento} para o seguinte: {resposta} -- Escrituário -- 50%.\n");
                break;

                case "2":
                aumento = salario + (salario*35/100);
                Console.WriteLine($"{nome}, Seu salário será de R${aumento} para o seguinte: {resposta} -- Secretário -- 35%.\n");
                break;

                case "3":
                aumento = salario + (salario*20/100);
                Console.WriteLine($"{nome}, Seu salário será de R${aumento} para o seguinte: {resposta} -- Caixa -- 20%.\n");
                break;

                case "4":
                aumento = salario + (salario*10/100);
                Console.WriteLine($"{nome}, Seu salário será de R${aumento} para o seguinte: {resposta} -- Gerente -- 10%.\n");
                break;

                case "5":
                Console.WriteLine($"{nome}, Seu salário permanecerá em R${salario}, pois você não tem direito ao aumento.\n");
                break;

            }


        }
    }
}
