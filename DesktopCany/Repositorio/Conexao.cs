using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //Trabalhar com dados.
using System.Data.SqlClient; //Cliente do servidor SQLServer.
using Microsoft.IdentityModel.Tokens;
using static System.Net.Mime.MediaTypeNames;
using DesktopCany.Entidades;

namespace DesktopCany.Repositorio
{
    class Conexao
    {
        public static bool TestarConexao()
        {
            bool configurado;
            string respostaDB = String.Empty;

            using (var db = new CanyContext())
            {
                try
                {
                    respostaDB = db.TB_Linguagens?.Find("TestarConexao()")?.ID_Linguagem ?? String.Empty;
                    configurado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    configurado = false;
                }
            }
            return configurado;
        }
    }
}
