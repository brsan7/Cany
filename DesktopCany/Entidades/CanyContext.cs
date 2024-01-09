using Microsoft.EntityFrameworkCore;

namespace DesktopCany.Entidades
{
    /*############################ OPERACOES DO ENTITYFRAMEWORK ############################
    * >Console do Gerenciador de Pacotes
    * PM>
    * 
    * Add-Migration InitialCreate //Cria o modelo de um banco de dados.
    * 
    * Update-Database  //Cria um banco de dados a partir do modelo. OBS: O SQLITE é criado na raiz da solução(necessário alocar manualmente Debug~Release)
    * 
    * Remove-Migration InitialCreate //Exclui o modelo de migração.
    * 
    * ############################ OPERACOES DO ENTITYFRAMEWORK ############################*/

    internal class CanyContext : DbContext
    {
        public const bool genesis = false;//Seletor Desenvolvimento|Produção
        public string switchDb = Propriedades.Configuracoes.Default.TipoServidor;//Produção
        //const string switchDb = "SQLITE";
        //const string switchDb = "SQLSERVER";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            switch (switchDb)//Seletor Base de Dados
            {
                case "SQLITE":
                    if (genesis)
                    {
                        //Uso em Desenvolvimento
                        optionsBuilder.UseSqlite($"Data Source=Cany.db");
                    }
                    else
                    {
                        //Uso em Produção
                        string urlDataBaseLocal = Propriedades.Configuracoes.Default.PastaLocal;
                        urlDataBaseLocal = $@"{urlDataBaseLocal}\{Propriedades.Configuracoes.Default.DataBaseLocal}";
                        optionsBuilder.UseSqlite($@"Data Source={urlDataBaseLocal}");
                    }
                    break;

                case "SQLSERVER":
                    if (genesis)
                    {
                        //Uso em Desenvolvimento
                        optionsBuilder.UseSqlServer($@"
                                                Server=*Nome do Servidor*;
                                                Database=Cany;
                                                Integrated Security=true;
                                                Trust Server Certificate=true");
                    }
                    else
                    {
                        //Uso em Produção
                        optionsBuilder.UseSqlServer($@"
                                                Server={Propriedades.Configuracoes.Default.StringConexao};
                                                Database=Cany;
                                                Integrated Security=true;
                                                Trust Server Certificate=true");
                    }
                    break;

                //default:
            }

        }

        public DbSet<LinguagemEnt> TB_Linguagens { get; set; } = null!;
        public DbSet<FuncaoEnt> TB_Funcoes { get; set; } = null!;
        public DbSet<BibliotecaEnt> TB_Bibliotecas { get; set; } = null!;
    }
}
