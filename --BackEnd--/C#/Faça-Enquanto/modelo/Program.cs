using System;

namespace modelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Modelo--");
            //Objetivo: Fazer um programa que leia uma senha de 6 digitos, caso ela não possua os 6 digitos deve pedir novamente para que digite a senha.

            string senha, nome;
            
            do{ 
                Console.WriteLine("Digite seu nome");
                nome = Console.ReadLine();
            }while (nome.Length <= 1);  //DoWhile verifica a condição depois


            do{
                Console.WriteLine("Digite a senha");
                senha = Console.ReadLine();
            }while (senha.Length < 6);      
        }   
    }
}
