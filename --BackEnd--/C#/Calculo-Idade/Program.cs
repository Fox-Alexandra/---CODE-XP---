using System;

namespace CalculoIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de Idade");
            //Objetivo: Fazer um programa que informe a idade em dias, meses, horas, semanas e minutos.

            int nascimento;
            int anoAtual;
            double idade;
            double meses;
            double dias;
            double horas;
            double minutos;
            double semanas;

            Console.WriteLine("Informe o  ano de nascimento:");
            nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o ano atual:");
            anoAtual = int.Parse(Console.ReadLine());

            idade = anoAtual - nascimento;
            meses = idade*12;
            dias = idade*365;
            horas = idade*8760;
            minutos = idade*525600;
            semanas = idade*52.1429;

            Console.WriteLine("Sua idade é em");
            Console.WriteLine("anos = " +idade);
            Console.WriteLine("meses = " +meses);
            Console.WriteLine("semanas = " +semanas); 
            Console.WriteLine("dias = "+dias);
            Console.WriteLine("Horas = "+horas);
            Console.WriteLine("minutos = " +minutos); 

        }
    }
}
