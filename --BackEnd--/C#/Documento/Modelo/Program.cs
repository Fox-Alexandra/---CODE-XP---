using System;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Drawing;
using Spire.Doc.Fields;

namespace Modelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Modelo");
            // Crie uma aplicação que receba o nome,endereço, valor de compra e data do dia da compra. O programa deve gerr um arquivo Word com os dados inseridos no formato abaixo
            //Nota Fiscal
            //Nome:
            //Endereço:
            //Valor:
            //Data:

            decimal valor;
            DateTime data = DateTime.Now;
            string nome, endereco;

            Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Informe seu endereço:");
            endereco = Console.ReadLine();

            Console.WriteLine("Informe o valor da compra:");
            valor = decimal.Parse(Console.ReadLine());

            Document documento = new Document();

            Section NotaFiscal = documento.AddSection();

            //Titulo

            Paragraph titulo = NotaFiscal.AddParagraph();

            titulo.AppendText("Nota Fiscal\n");

            titulo.Format.HorizontalAlignment = HorizontalAlignment.Left;

            ParagraphStyle titulo01 = new ParagraphStyle(documento);

            titulo01.Name = "Cor do Titulo";

            titulo01.CharacterFormat.TextColor = Color.Black;

            titulo01.CharacterFormat.Bold = true;

            documento.Styles.Add(titulo01);

            titulo.ApplyStyle(titulo01.Name);

            //Nome

            Paragraph Nome = NotaFiscal.AddParagraph();

            Nome.AppendText("Nome: ");    

            TextRange tr = Nome.AppendText(nome);

            tr.CharacterFormat.Bold = false;
                 
            Nome.Format.HorizontalAlignment = HorizontalAlignment.Left;

            ParagraphStyle Nome01 = new ParagraphStyle(documento);

            Nome01.Name = "Cor do Nome";

            Nome01.CharacterFormat.TextColor = Color.Black;

            Nome01.CharacterFormat.Bold = true;

            documento.Styles.Add(Nome01);

            Nome.ApplyStyle(Nome01.Name);

            //Endereço

            Paragraph Endereço = NotaFiscal.AddParagraph();

            //CharactereFormat format = new CharactereFormat(documento);
            //format.Bold = true;   ((Serve tbm para nao dar quebra))

            // Endereço.AppendText("Endereço ").ApplyCharactereFormat(format);
            // Endereço.AppendText(endereco);

            Endereço.AppendText("Endereço: ");

            TextRange c = Endereço.AppendText(endereco); //Para ficar na msm linha sem dar quebra.

            c.CharacterFormat.Bold = false;

            Endereço.Format.HorizontalAlignment = HorizontalAlignment.Left;

            ParagraphStyle end01 = new ParagraphStyle(documento);

            end01.Name = "Cor do Endereço";

            end01.CharacterFormat.TextColor = Color.Black;

            end01.CharacterFormat.Bold = true;

            documento.Styles.Add(end01);

            Endereço.ApplyStyle(end01.Name);

            //Valor

            Paragraph Preço = NotaFiscal.AddParagraph();

            Preço.AppendText("Valor: ");
            
            TextRange b = Preço.AppendText($"R${valor}");

            b.CharacterFormat.Bold = false;

            Preço.Format.HorizontalAlignment = HorizontalAlignment.Left;

            ParagraphStyle Preço01 = new ParagraphStyle(documento);

            Preço01.Name = "Cor do Preço";

            Preço01.CharacterFormat.TextColor = Color.Black;

            Preço01.CharacterFormat.Bold = true;

            documento.Styles.Add(Preço01);

            Preço.ApplyStyle(Preço01.Name);

            //Data

            Paragraph Data = NotaFiscal.AddParagraph();

            Data.AppendText("Data: ");

            TextRange a = Data.AppendText(data.ToString("dd/MM/yyyy"));

            a.CharacterFormat.Bold = false;

            Data.Format.HorizontalAlignment = HorizontalAlignment.Left;

            ParagraphStyle Data01 = new ParagraphStyle(documento);

            Data01.Name = "Cor da Data";

            Data01.CharacterFormat.TextColor = Color.Black;

            Data01.CharacterFormat.Bold = true;

            documento.Styles.Add(Data01);

            Data.ApplyStyle(Data01.Name);

            documento.SaveToFile(@"saida01\Modelo.docx", FileFormat.Docx);
         
        }
    }
}
