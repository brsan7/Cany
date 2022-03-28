using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DesktopCany.Repositorio
{
    class BackupRep
    {
        Conexao con = new Conexao();

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
