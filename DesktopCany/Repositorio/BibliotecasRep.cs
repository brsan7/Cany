using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopCany.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DesktopCany.Repositorio
{
    class BibliotecasRep
    {
        public static List<string> Consultar()
        {
            List<string> resultado = new();
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    resultado = db.TB_Bibliotecas.Select(T => T.Biblioteca).ToList();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class BibliotecasRep]" + Environment.NewLine
                                    + "[public static List<string> Consultar()]" + Environment.NewLine
                                    + "[Linha 20]" + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static List<string> SelecionarBibliotecas(string linguagem)
        {
            List<string> resultado = new() { "Bibliotecas" };
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    resultado.AddRange((from bibliotecas in db.TB_Bibliotecas
                                        where bibliotecas.ID_Linguagem.Equals(linguagem)
                                        select bibliotecas.Biblioteca).ToList().Distinct());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class BibliotecasRep]"
                                    + Environment.NewLine
                                    + "[public static List<string> SelecionarBibliotecas(string linguagem)]" 
                                    + Environment.NewLine
                                    + "[Linha 41]" 
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static string BuscarDescricao(string linguagem)
        {
            string resultado = "";
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    resultado = (from bibliotecas in db.TB_Bibliotecas
                                 where bibliotecas.ID_Linguagem.Equals(linguagem)
                                 select bibliotecas.DescricaoLib).First().ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class BibliotecaRep]" 
                                    + Environment.NewLine
                                    + "[public static List<string> BuscarDescricao(string linguagem)]"
                                    + Environment.NewLine
                                    + "[Linha 57]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static List<BibliotecaEnt> SelecionarTB_Bibliotecas()
        {
            List<BibliotecaEnt> resultado = new();
            using (var db = new Cany_ContextSQLite())
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
                                    + "[Linha 91]"
                                    + Environment.NewLine
                                    + ex);
                }
                return resultado;
            }
        }

        public static bool Registrar(BibliotecaEnt RI)
        {
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    //db.Database.Migrate();
                    //db.SaveChanges();
                    db.TB_Bibliotecas.Add(RI);
                    db.SaveChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("[class BibliotecaRep]"
                                    + Environment.NewLine
                                    + "[public static bool Registrar(BibliotecaEnt RI)]"
                                    + Environment.NewLine
                                    + "[Linha 117]"
                                    + Environment.NewLine
                                    + ex);
                    return false;
                }
            }
        }
    }
}
