using System;
using Polimorfismo1.Models;

namespace Polimorfismo1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Carlos Eduardo Tsukamoto";
            double altura = 1.78;
            PessoaModel pessoaModel = new PessoaModel(nome, altura); //tem que ser na ordem que foi passada no model

           
        }
    }
}
