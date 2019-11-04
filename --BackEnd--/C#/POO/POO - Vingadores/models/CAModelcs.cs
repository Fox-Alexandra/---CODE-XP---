using System;
using System.Text;

namespace POO___Vingadores.models
{
    public class CAModelcs : BaseModel
    {
        public string Escudo {get; set;}
        public void Atacar(){
            Console.WriteLine("<---------------------------------------->");
            Console.WriteLine("Capitão América ataca com seu escudo!");
            Console.WriteLine("<---------------------------------------->");
        }
        public void Defender(){
            Console.WriteLine("<---------------------------------------->");
            Console.WriteLine("Capitão América se defende");
            Console.WriteLine("<---------------------------------------->");
        }

    }
}