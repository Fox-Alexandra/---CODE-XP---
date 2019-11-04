using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicios");


            Console.WriteLine("Exercicio 01");
            //Objetivo: Fazer um programa que leia um valor e informe o seu triplo.

            int n1;
            int triplo;
            Console.WriteLine("Digite um número:");
            n1 = int.Parse(Console.ReadLine());
            triplo = n1*3;
            Console.WriteLine($"O triplo de {n1} é {triplo}");
            



            Console.WriteLine("Exercicio 02");
            //Objetivo: Fazer um programa que leia o valor de uma mercadoria e seu % de acrescimo e informe seu valor ajustado com acréscimo.
            
            double valor;
            double acres;
            double total;
            Console.WriteLine("Digite o valor do custo da mercadoria:");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o % de acréscimo:");
            acres = double.Parse(Console.ReadLine());
            total = (valor * (acres/100)) + valor;
            Console.WriteLine("O valor total da mercadoria com acréscimo é de: "+total);



            Console.WriteLine("Exercicio 03");
            //Objetivo: Fazer um programa que leia o salário, quantidade de vendas e informe o total que o usuário recebera de pagamento.

            double salario;
            double vendas;
            double totaal;
            Console.WriteLine("Digite seu salário fixo:");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu total de vendas:");
            vendas = double.Parse(Console.ReadLine());
            totaal = salario + (vendas*5/100);
            Console.WriteLine("Você receberá no total: "+totaal);

            Console.WriteLine("Exercicio 04");
            //Objetivo: Fazedr um pograma que converta reais em dólares.

            double reais;
            double dolar;
            double cotação;

            Console.WriteLine("Digite o valor em R$: ");
            reais = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cotação: ");
            cotação = double.Parse(Console.ReadLine());
            dolar = reais*cotação;
            Console.WriteLine("A conversão de reais em dólares é de: $"+dolar);
               
        }
    }
}
