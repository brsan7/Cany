using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using DesktopCany.Entidades;

namespace DesktopCany.Repositorio
{
    class BackupRep
    {
        Conexao con = new Conexao();

        public static List<BibliotecaEnt> SelecionarTB_Bibliotecas()
        {
            List<BibliotecaEnt> resultado = new();
            using (var db = new CanyContext())
            {
                try
                {
                    resultado = (from bibliotecas in db.TB_Bibliotecas
                                 select bibliotecas).ToList();
                }
                catch (Exception ex)
                {

                    Console.WriteLine("[class BibliotecaRep]"
                                    + Environment.NewLine
                                    + "[public static List<BibliotecaEnt> SelecionarTB_Bibliotecas()]"
                                    + Environment.NewLine
                                    + "[Linha 17]"
                                    + Environment.NewLine
                                    + ex);
                }
                return resultado;
            }
        }
        public void GerarBackup(string caminho)
        {
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con.Conectar();
            //cmd.CommandText = "BACKUP DATABASE [" +
            //                   Propriedades.Configuracoes.Default.NomeBaseDeDados + "]" +
            //                   " TO DISK = '" + caminho + "' WITH COPY_ONLY";
            //cmd.ExecuteNonQuery();
            //con.Desconectar();
        }

        public void RestaurarBackup(string caminho)
        {
            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con.Conectar();
            //cmd.CommandText = "Use Master; RESTORE DATABASE [" +
            //                   Propriedades.Configuracoes.Default.NomeBaseDeDados + "]" +
            //                   " FROM DISK = '" + caminho + "' ";
            //cmd.ExecuteNonQuery();
            //con.Desconectar();
        }
    }
}
