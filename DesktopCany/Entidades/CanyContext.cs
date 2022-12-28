using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
// add a reference to System.ComponentModel.DataAnnotations DLL
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;


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
        public const bool genesis = true;//Seletor Desenvolvimento|Produção
        public const string switch_on = "USE_SQLITE";
        //const string switch_on = "USE_SQLSERVER";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            switch (switch_on)//Seletor Base de Dados
            {
                case "USE_SQLITE":
                    if (genesis)
                    {
                        //Uso em Desenvolvimento
                        optionsBuilder.UseSqlite($"Data Source=Cany.db");
                    }
                    else
                    {
                        //Uso em Produção
                        optionsBuilder.UseSqlite($@"Data Source={Propriedades.Configuracoes.Default.EnderecoServidorSQL}");
                    }
                    break;

                case "USE_SQLSERVER":
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
                                                Server={Propriedades.Configuracoes.Default.EnderecoServidorSQL};
                                                Database={Propriedades.Configuracoes.Default.NomeBaseDeDados};
                                                Integrated Security=true;
                                                Trust Server Certificate=true");
                    }
                    break;

                default:
            }

        }

        public DbSet<LinguagemEnt> TB_Linguagens { get; set; } = null!;
        public DbSet<FuncaoEnt> TB_Funcoes { get; set; } = null!;
        public DbSet<BibliotecaEnt> TB_Bibliotecas { get; set; } = null!;
    }
}
