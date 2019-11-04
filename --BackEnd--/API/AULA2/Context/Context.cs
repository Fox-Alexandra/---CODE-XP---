using AULA2.Context.Models;
using Microsoft.EntityFrameworkCore;


namespace AULA2.Context

{
    public class AULA2Context : DbContext
    {
        public AULA2Context(){}

        // Configurando o acesso ao banco
        public AULA2Context(DbContextOptions<AULA2Context> options):base(options){

        }
        public virtual DbSet<UsuarioModel> tbl_usuario {get; set;} //Linha de código onde pega a tabela do Banco de Dados que eu vou utilizar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; DataBase=aula_api; Integrated Security=true"); //Conexão com o Banco mostrando quando o local, Db e a integração que vou usar
            }
        }
    }
}