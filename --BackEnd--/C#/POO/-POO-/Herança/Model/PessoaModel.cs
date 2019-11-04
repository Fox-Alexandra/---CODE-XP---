using System;

namespace Herança.Model
{
    public class PessoaModel
    {
        public string Nome{get; set;}
        public int Idade{get; set;}
        
        public void Comer() //Criar ações 
        {
            Console.WriteLine("----Bora comer!----");
        }
        public void Andar()
        {
            Console.WriteLine("----Bora andar!----");
        }
        public void Dormir()
        {
            Console.WriteLine("----Bora dormir!----");
        }
        public void Correr()
        {
            Console.WriteLine("----Vamos correr!----");
        }
    }
}
