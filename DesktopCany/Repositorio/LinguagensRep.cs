using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopCany.Entidades;

namespace DesktopCany.Repositorio
{
    class LinguagensRep
    {
        public static List<string> SelecionarLinguagens()
        {
            List<string> resultado = new() { "Linguagens" };
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    resultado.AddRange(db.TB_Linguagens.Select(T => T.ID_Linguagem).ToList());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class LinguagensRep]" + Environment.NewLine
                                    + "[public static List<string> SelecionarLinguagens()]" + Environment.NewLine
                                    + "[Linha 19]" + Environment.NewLine
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
                    resultado = (from linguagens in db.TB_Linguagens
                                 where linguagens.ID_Linguagem.Equals(linguagem)
                                 select linguagens.DescricaoLang).First().ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class LinguagensRep]" + Environment.NewLine
                                    + "[public static string BuscarDescricao(string linguagem)]" + Environment.NewLine
                                    + "[Linha 19]" + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static List<LinguagemEnt> SelecionarTB_Linguagens()
        {
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    return (from linguagens in db.TB_Linguagens
                            select linguagens).ToList();
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine("[class LinguagensRep]" + Environment.NewLine
                                    + "[public static List<LinguagemEnt> SelecionarTB_Linguagens()]" + Environment.NewLine
                                    + "[Linha 19]" + Environment.NewLine
                                    + ex);
                    return new List<LinguagemEnt>();
                }
            }
        }
    }
}
