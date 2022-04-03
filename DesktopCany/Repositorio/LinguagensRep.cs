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
                                    + "[Linha 12]" + Environment.NewLine
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
                                    + "[Linha 32]" + Environment.NewLine
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
                                    + "[Linha 54]" + Environment.NewLine
                                    + ex);
                    return new List<LinguagemEnt>();
                }
            }
        }

        public static List<LinguagemEnt> Buscar_Linguagem(string busca)
        {
            using (var db = new Cany_ContextSQLite())
            {
                List<LinguagemEnt> resultado = new();
                try
                {
                    resultado = (from linguagem in db.TB_Linguagens
                                 where linguagem.ID_Linguagem.Contains(busca)
                                 select linguagem).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class LinguagensRep]"
                                    + Environment.NewLine
                                    + "[public static List<LinguagemEnt> Buscar_Linguagem(string busca)]"
                                    + Environment.NewLine
                                    + "[Linha 75]"
                                    + Environment.NewLine
                                    + ex);
                }
                return resultado;
            }
        }

        public static void Remover(LinguagemEnt linguagemEnt)
        {
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    db.TB_Linguagens.Remove(linguagemEnt);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class LinguagemRep]"
                                    + Environment.NewLine
                                    + "[public static void Remover(LinguagemEnt linguagemEnt)]"
                                    + Environment.NewLine
                                    + "[Linha 100]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
        }
    }
}
