using System;

namespace CadastroMVC.Models
{
    public class BaseModel
    {
        public int Id { get; set; } //classe ID
        public string Nome { get; set; } //classe Nome
        public DateTime DataCriacao { get; set; } //classe DataCriacao
    }
}