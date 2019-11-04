using System;
using Spire.Doc;
using Spire.Doc.Documents;
using System.Drawing;

namespace Repositorio_word_pdf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando um novo documento com o nome documento
            Document documento = new Document();

            //Criando uma seção dentro do documento
            //A cada seção criada uma nova página é add
            Section secaoCapa = documento.AddSection();

            //Insere um titulo na primeira pág
            Paragraph titulo = secaoCapa.AddParagraph();

            //Insiro na minha variavel titulo o valor da string Título muito bonito
            //No meu documento aparecerá "Titulo muito bonito"
            titulo.AppendText("Título muito bonito\n\n");

            //Alinha horizontalmente o titulo
            titulo.Format.HorizontalAlignment = HorizontalAlignment.Center;

            //Instanciando a classe ParagraphStyle dentro do nosso documento
            ParagraphStyle estilo01 = new ParagraphStyle(documento);

            //Define o nome da classe estilo01
            estilo01.Name="Cor do Titulo";

            //Transforma a propriedade TextColor em Azul escuro
            estilo01.CharacterFormat.TextColor = Color.DarkBlue;

            //Transforma a propriedade bold em True
            estilo01.CharacterFormat.Bold = true;

            //Adicionar o estilo e colocar como usavel nosso documento
            documento.Styles.Add(estilo01);

            titulo.ApplyStyle(estilo01.Name);   
         
            //Salva o documento na pasta destino com a extensao escolhida
            documento.SaveToFile(@"saida\exemploWord.docx", FileFormat.Docx);

        }
    }
}
