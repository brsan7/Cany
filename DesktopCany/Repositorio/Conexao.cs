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
        //Declarar uma variavel de conexao com o SQL.
        SqlConnection con;

        //Metodo construtor (que é execultado sempre que um objeto desta classe é instanciado).
        public Conexao()
        {
            //Instanciar o objeto sqlconection.
            con = new SqlConnection();
            con.ConnectionString = "Data Source = ";
            con.ConnectionString += Propriedades.Configuracoes.Default.EnderecoServidorSQL;
            
        }

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public static bool TestarConexao()
        {
            bool configurado;
            string servidor = Propriedades.Configuracoes.Default.EnderecoServidorSQL;

            if (CanyContext.genesis || servidor != "*Nome ou endereço do servidor*")
            {
                using (var db = new CanyContext())
                {
                    try
                    {
                        servidor = db.TB_Linguagens?.Find("TestarConexao()")?.ID_Linguagem ?? String.Empty;
                        configurado = true;
                    }
                    catch (Exception ex)
                    {
                        configurado = false;
                    }
                }
                return configurado;
            }
            else return false;
        }
    }
}
