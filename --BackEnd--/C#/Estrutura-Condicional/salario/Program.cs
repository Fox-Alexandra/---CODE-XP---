using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ajuste Salarial");
            //Objetivo: Fazer um programa que calcule o ajuste salarial.


            decimal salario;
            decimal ajuste;

            Console.WriteLine("Digite o valor do teu salário atual:");
            salario = decimal.Parse(Console.ReadLine());

            if (salario<990){
                ajuste = (salario*30/100)+salario;
                Console.WriteLine("O valor ajustado de seu salário é: "+ajuste);
            }else{
                Console.WriteLine("OPS! Você não tem direito ao reasjute salarial");
            }
        }
    }
}
