using System;

namespace Encadeamento_de_Funções
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Modelo--");
            //Objetivo: Fazer um programa que leia a idade e informe em qual categoria o usuário se enquadra.


            int idade;

            Console.WriteLine("Informe sua idade:");
            idade = int.Parse(Console.ReadLine());
            if(idade<=7){
            Console.WriteLine("Você se enquadra na categoria Infantil A");
            }else if(idade>=8 && idade<=10){
                Console.WriteLine("Você se enquadra na categoria Infantil B");
            }else if(idade >=11 && idade<=13){
                Console.WriteLine("Você se enquadra na categoria Juvenil A");
            }else if(idade>=14 && idade<=17){
                Console.WriteLine("Você se enquadra na categoria Juvenil B");
            }else{
                Console.WriteLine("Você se enquadra na categoria Adulto");
            }
                
        }
    }
}
