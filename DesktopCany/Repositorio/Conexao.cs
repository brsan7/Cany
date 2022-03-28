using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //Trabalhar com dados.
using System.Data.SqlClient; //Cliente do servidor SQLServer.

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

        public bool TestarConexao()
        {
            bool teste = true;
            try
            {
                con.Open();
                con.Close();
            }
            catch (Exception)
            {
                teste = false;
            }
            return teste;
        }
    }
}
