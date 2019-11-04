using System;

namespace Polimorfismo1.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public void ExibirNome(){
            Console.WriteLine("Metodo sem parametro");// não se pode criar um objeto apartir dela, so usar como base 
        } //se usa classe abstrata quando se que usar ela como base para outras, não como instancia
    }
}