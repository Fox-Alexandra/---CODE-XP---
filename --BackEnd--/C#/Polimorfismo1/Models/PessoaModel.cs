using System;

namespace Polimorfismo1.Models
{
    public class PessoaModel : BaseModel
    {
        public DateTime DataNascimento { get; set; }
        public double Altura { get; set; }

        public PessoaModel (int Id, string Nome, string Nascimento, double Altura){

        }
        public PessoaModel (string Nome, double Altura){
            
        }

        public void ExibirNome(string nome){//paremetos diferentes/ o que esta em parentezes 
         Console.WriteLine($"Só tenho o nome {nome}");
        }
        public void ExibirNome(string nome, string sobreNome){
         Console.WriteLine($"Meu nome completo é {nome} {sobreNome}");
        }
    }
}