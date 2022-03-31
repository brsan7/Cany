using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DesktopCany.Entidades;

namespace DesktopCany.Repositorio
{
    class FuncoesRep
    {
        public static FuncaoEnt Consultar()
        {
            FuncaoEnt resultado = new FuncaoEnt();
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    resultado = db.TB_Funcoes.OrderBy(s => s.Funcao).First();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static FuncaoEnt Consultar()]"
                                    + Environment.NewLine
                                    + "[Linha 20]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static List<FuncaoEnt> Consultar(string busca)
        {
            List<FuncaoEnt> resultado = new List<FuncaoEnt>();
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    //resultado = db.Snippets.OrderBy(s => s.Linguagem).First();
                    resultado = (from ferramentas in db.TB_Funcoes
                                 where ferramentas.Funcao.Contains(busca)
                                 select ferramentas).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static List<FuncaoEnt> Consultar(string busca)]"
                                    + Environment.NewLine
                                    + "[Linha 7]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static List<FuncaoEnt> SelecionarModsFuncao(BibliotecaEnt busca)
        {
            List<FuncaoEnt> resultado = new() { new() { ID_FcnModData = "Data_Mod_Id" } };
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    resultado.AddRange((from bibliotecas in db.TB_Bibliotecas
                                        join funcoes in db.TB_Funcoes
                                        on bibliotecas.ID_Linguagem equals busca.ID_Linguagem
                                        where funcoes.ID_FcnModData == bibliotecas.ID_FcnModData
                                        //where bibliotecas.Biblioteca == busca.Biblioteca
                                        where funcoes.Funcao == busca.FK_ID_FcnModData.Funcao
                                        select funcoes).ToList());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static List<FuncaoEnt> SelecionarModsFuncao(BibliotecaEnt busca)]"
                                    + Environment.NewLine
                                    + "[Linha 7]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static List<string> SelecionarFuncoes(BibliotecaEnt busca)
        {
            List<string> resultado = new() { "Funções" };
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    resultado.AddRange((from bibliotecas in db.TB_Bibliotecas
                                        join funcoes in db.TB_Funcoes
                                        on bibliotecas.ID_Linguagem equals busca.ID_Linguagem
                                        where funcoes.ID_FcnModData == bibliotecas.ID_FcnModData
                                        select funcoes.Funcao).ToList().Distinct());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static List<string> SelecionarFuncoes(BibliotecaEnt busca)]"
                                    + Environment.NewLine
                                    + "[Linha 7]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static List<string> SelecionarModDatas(BibliotecaEnt busca)
        {
            List<string> resultado = new() { "Data_Mod_Id" };
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    resultado.AddRange((from bibliotecas in db.TB_Bibliotecas
                                        join funcoes in db.TB_Funcoes
                                        on bibliotecas.ID_Linguagem equals busca.ID_Linguagem
                                        where funcoes.Funcao == busca.FK_ID_FcnModData.Funcao
                                        select funcoes.ID_FcnModData).ToList().Distinct());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static List<string> SelecionarModDatas(BibliotecaEnt busca)]"
                                    + Environment.NewLine
                                    + "[Linha 7]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static List<string> SelecionarModProgramadores(BibliotecaEnt busca)
        {
            List<string> resultado = new() { "Programador Responsável" };
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    resultado.AddRange((from bibliotecas in db.TB_Bibliotecas
                                        join funcoes in db.TB_Funcoes
                                        on bibliotecas.ID_Linguagem equals busca.ID_Linguagem
                                        where funcoes.Funcao == busca.FK_ID_FcnModData.Funcao
                                        select funcoes.ModProgramador).ToList().Distinct());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static List<string> SelecionarModProgramadores(BibliotecaEnt busca)]"
                                    + Environment.NewLine
                                    + "[Linha 7]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static FuncaoEnt BuscarMod(BibliotecaEnt busca)
        {
            FuncaoEnt resultado = new();
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    resultado = (from bibliotecas in db.TB_Bibliotecas
                                 join funcoes in db.TB_Funcoes
                                 on bibliotecas.ID_Linguagem equals busca.ID_Linguagem
                                 where bibliotecas.Biblioteca == busca.Biblioteca
                                 //where funcoes.Funcao == busca.FK_ID_FcnModData.Funcao
                                 where funcoes.ID_FcnModData == busca.FK_ID_FcnModData.ID_FcnModData
                                 //where funcoes.ModProgramador == busca.FK_ID_FcnModData.ModProgramador
                                 select funcoes).OrderBy(tb=> tb.ID_FcnModData).Last();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static FuncaoEnt BuscarMod(BibliotecaEnt busca)]"
                                    + Environment.NewLine
                                    + "[Linha 7]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static List<FuncaoEnt> SelecionarTB_Funcoes()
        {
            using (var db = new Cany_ContextSQLite())
            {
                List<FuncaoEnt> resultado = new();
                try
                {
                    resultado = (from funcoes in db.TB_Funcoes
                                 select funcoes).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static List<FuncaoEnt> SelecionarTB_Funcoes()]"
                                    + Environment.NewLine
                                    + "[Linha 7]"
                                    + Environment.NewLine
                                    + ex);
                }
                return resultado;
            }
        }
        public static void Registrar(FuncaoEnt funcaoEnt)
        {
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    db.TB_Funcoes.Add(funcaoEnt);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static void Registrar(FuncaoEnt funcaoEnt)]"
                                    + Environment.NewLine
                                    + "[Linha 7]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
        }
    }
}
