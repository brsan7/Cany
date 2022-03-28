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
    internal class Cany_ContextSQLite : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //USO COM SQLITE
            //optionsBuilder.UseSqlite($@"Data Source={Propriedades.Configuracoes.Default.EnderecoServidorSQL}");

            //USO NAS OPERACOES DO ENTITYFRAMEWORK
            optionsBuilder.UseSqlite($"Data Source=Cany.db");

            //USO COM SQLSERVER
            //optionsBuilder.UseSqlServer($@"
            //                        Server={Propriedades.Configuracoes.Default.EnderecoServidorSQL};
            //                        Database={Propriedades.Configuracoes.Default.NomeBaseDeDados};
            //                        Integrated Security=true");
        }

        /*############################ OPERACOES DO ENTITYFRAMEWORK ############################
         * >Console do Gerenciador de Pacotes
         * 
         * Add-Migration InitialCreate //Cria o modelo de um banco de dados
         * 
         * Update-Database  //Cria um banco de dados a partir do modelo
         * 
         * Remove-Migration //Exclui um Banco de dados
         * 
         * ############################ OPERACOES DO ENTITYFRAMEWORK ############################*/


        public DbSet<LinguagemEnt> TB_Linguagens { get; set; } = null!;
        public DbSet<FuncaoEnt> TB_Funcoes { get; set; } = null!;
        public DbSet<BibliotecaEnt> TB_Bibliotecas { get; set; } = null!;
    }
}
