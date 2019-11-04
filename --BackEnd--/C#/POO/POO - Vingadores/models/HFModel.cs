using System;
using System.Text;

namespace POO___Vingadores.models
{
    public class HFModel : BaseModel
    {
        public string Armadura {get; set;}
        public void Atirar (){
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("<---------------------------------------->");
            Console.WriteLine(@"
            _/﹋\_
            (҂`_´)
            <,︻╦╤─ ҉ - -
            _/﹋\_");
            Console.WriteLine("<---------------------------------------->");
        }
        public void Voar (){
            Console.OutputEncoding = System.Text.Encoding.UTF8; // pra ler os caracteres especiais              
            Console.WriteLine("<---------------------------------------->");
            Console.WriteLine(@"              (づ￣ ³￣)づ");
            Console.WriteLine("<---------------------------------------->");
        }
    }
}