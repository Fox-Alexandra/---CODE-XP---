using System;
using POO.Model;


namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 1 27.09");

            ModelCelular Celular1 = new ModelCelular();
            
            Console.WriteLine("Insira a marca do produto:");
            Celular1.marca = Console.ReadLine();

            Console.Write("Insira o modelo:");
            Celular1.modelo = Console.ReadLine();

            Console.WriteLine("Insira a cor:");
            Celular1.cor = Console.ReadLine();

            Console.WriteLine($@"
            Celular: {Celular1.marca}
            Modelo: {Celular1.modelo}
            Cor: {Celular1.cor}
            ");

            //------------------------------------------------------

            ModelPorta porta1 = new ModelPorta();

            Console.WriteLine("Insira o tamanho da porta:");
            porta1.tamanho = float.Parse(Console.ReadLine());

            Console.Write("Insira o modelo:");
            porta1.modelo = Console.ReadLine();

            Console.WriteLine("Insira a cor:");
            porta1.cor = Console.ReadLine();

            Console.WriteLine("Insira a largura da porta:");
            porta1.largura = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o material da porta:");
            porta1.material = Console.ReadLine();

            Console.WriteLine($@"
            Tamanho: {porta1.tamanho}
            Largura: {porta1.largura}
            Material: {porta1.material}
            Modelo: {porta1.modelo}
            Cor: {porta1.cor}
            ");

              //------------------------------------------------------

            ModelAviao aviao1 = new ModelAviao();

            Console.WriteLine("Insira a marca:");
            aviao1.marca = Console.ReadLine();

            Console.Write("Insira o modelo:");
            aviao1.modelo = Console.ReadLine();

            Console.WriteLine("Insira a companhia:");
            aviao1.companhia = Console.ReadLine();

            Console.WriteLine("Insira a capacidade do avião:");
            aviao1.capacidade = int.Parse(Console.ReadLine());

            Console.WriteLine($@"
            Marca: {aviao1.marca}
            Companhia: {aviao1.companhia}
            Capacidade: {aviao1.capacidade}
            Modelo: {aviao1.modelo}
            ");
            
              //------------------------------------------------------

            ModelMicroondas micro01 = new ModelMicroondas();

            Console.WriteLine("Insira a marca:");
            micro01.marca = Console.ReadLine();

            Console.Write("Insira o modelo:");
            micro01.modelo = Console.ReadLine();

            Console.WriteLine("Insira a voltagem:");
            micro01.voltagem = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a capacidade:");
            micro01.capacidade = float.Parse(Console.ReadLine());

            Console.WriteLine($@"
            Marca: {micro01.marca}
            Voltagem: {micro01.voltagem}
            Material: {micro01.capacidade}
            Modelo: {micro01.modelo}
            ");

              //------------------------------------------------------

            ModelOculos Oculos01 = new ModelOculos();

            Console.WriteLine("Insira a marca:");
            Oculos01.marca = Console.ReadLine();

            Console.Write("Insira o modelo:");
            Oculos01.modelo = Console.ReadLine();

            Console.WriteLine("Insira o Grau:");
            Oculos01.grau = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a lente:");
            Oculos01.lente = Console.ReadLine();

            Console.WriteLine($@"
            Marca: {Oculos01.marca}
            Grau: {Oculos01.grau}
            Lente: {Oculos01.lente}
            Modelo: {Oculos01.modelo}
            ");

        }
    }
}
