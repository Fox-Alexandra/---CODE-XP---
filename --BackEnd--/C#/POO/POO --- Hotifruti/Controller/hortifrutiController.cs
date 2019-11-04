using System;
using System.Collections.Generic;
using Hotifruti___POO.Model;


namespace Hotifruti___POO.Controller
{
    public class hortifrutiController
    {
        List<hortifrutiModel> listaDeProdutos = new List<hortifrutiModel>();
        ///<summary>
        ///Cadastro de Produtos
        ///</summary>
        public void CadastroProdutos()
        {
            Console.WriteLine("Digite o produto que deseja cadastrar");
            string produto = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto:");
            double preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a Categoria do produto");
            string categoria = Console.ReadLine();

            Console.WriteLine("Informe a quantidade de itens");
            int estoque = int.Parse(Console.ReadLine());

            hortifrutiModel Produto = new hortifrutiModel();
            Produto.Nome = produto;
            Produto.Id = listaDeProdutos.Count+1;
            Produto.Preco = preco;
            Produto.Categoria = categoria;
            Produto.DataCadastro = DateTime.Now;
            Produto.Estoque = estoque;

            listaDeProdutos.Add(Produto);            
        } //Fim Cadastro Produto

        public void ListarProdutos()
        {
            foreach(var item in listaDeProdutos)
            {
                Console.WriteLine($@"
                ----------------------------------------------
                Produto: {item.Nome}
                ID: {item.Id}
                Categoria: {item.Categoria}
                Preço: R${item.Preco}
                Data do Cadastro: {item.DataCadastro}
                Estoque: {item.Estoque}
                ");
            } //fim foreach
        }

        public void SomarProdutos()
        {
            double soma = 0;
            foreach(var item in listaDeProdutos){
                soma = soma + (item.Preco * item.Estoque);
            }

            Console.WriteLine($"Valor total: R${soma}");
        } //fim Soma
    }
}