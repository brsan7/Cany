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

        public static List<string> SelecionarFuncoes(BibliotecaEnt busca)
        {
            List<string> resultado = new() { "**Funções**" };
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    resultado.AddRange((from bibliotecas in db.TB_Bibliotecas
                                        join funcoes in db.TB_Funcoes
                                        on bibliotecas.ID_Linguagem equals busca.ID_Linguagem
                                        where bibliotecas.Biblioteca == busca.Biblioteca
                                        where funcoes.ID_FcnModData == bibliotecas.ID_FcnModData
                                        select funcoes.Funcao).ToList().Distinct());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static List<string> SelecionarFuncoes(BibliotecaEnt busca)]"
                                    + Environment.NewLine
                                    + "[Linha 14]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static List<FuncaoEnt> SelecionarModsFuncao(BibliotecaEnt busca)
        {
            List<FuncaoEnt> resultado = new() { new() { ID_FcnModData = "**Data_Mod_Id**" } };
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
                                    + "[Linha 42]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static List<string> SelecionarModDatas(BibliotecaEnt busca)
        {
            List<string> resultado = new() { "**Data_Mod_Id**" };
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
                                    + "[Linha 71]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static List<string> SelecionarModProgramador(BibliotecaEnt busca)
        {
            List<string> resultado = new() { "**Colaboradores**" };
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
                                    + "[Linha 98]"
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
                                    + "[Linha 125]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static List<FuncaoEnt> BuscarModProgramador(BibliotecaEnt busca)
        {
            List<FuncaoEnt> resultado = new();
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    resultado = (from bibliotecas in db.TB_Bibliotecas
                                 join funcoes in db.TB_Funcoes
                                 on bibliotecas.ID_Linguagem equals busca.ID_Linguagem
                                 where bibliotecas.Biblioteca == busca.Biblioteca
                                 //where funcoes.Funcao == busca.FK_ID_FcnModData.Funcao
                                 where funcoes.ModProgramador == busca.FK_ID_FcnModData.ModProgramador
                                 where funcoes.Funcao == busca.FK_ID_FcnModData.Funcao
                                 select funcoes).OrderBy(tb => tb.ID_FcnModData).Distinct().ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static FuncaoEnt BuscarModProgramador(BibliotecaEnt busca)]"
                                    + Environment.NewLine
                                    + "[Linha 125]"
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
                                    + "[Linha 155]"
                                    + Environment.NewLine
                                    + ex);
                }
                return resultado;
            }
        }

        public static List<FuncaoEnt> Buscar_Funcao(string busca)
        {
            using (var db = new Cany_ContextSQLite())
            {
                List<FuncaoEnt> resultado = new();
                try
                {
                    resultado = (from funcoes in db.TB_Funcoes
                                 where funcoes.Funcao.Contains(busca)
                                 select funcoes).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static List<FuncaoEnt> Buscar_Funcao(string busca)]"
                                    + Environment.NewLine
                                    + "[Linha 179]"
                                    + Environment.NewLine
                                    + ex);
                }
                return resultado;
            }
        }

        public static List<FuncaoEnt> Buscar_ModData(string busca)
        {
            using (var db = new Cany_ContextSQLite())
            {
                List<FuncaoEnt> resultado = new();
                try
                {
                    resultado = (from funcoes in db.TB_Funcoes
                                 where funcoes.ID_FcnModData.Contains(busca)
                                 select funcoes).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static List<FuncaoEnt> Buscar_ModData(string busca)]"
                                    + Environment.NewLine
                                    + "[Linha 204]"
                                    + Environment.NewLine
                                    + ex);
                }
                return resultado;
            }
        }

        public static List<FuncaoEnt> Buscar_ModProgramador(string busca)
        {
            using (var db = new Cany_ContextSQLite())
            {
                List<FuncaoEnt> resultado = new();
                try
                {
                    resultado = (from funcoes in db.TB_Funcoes
                                 where funcoes.ModProgramador.Contains(busca)
                                 select funcoes).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static List<FuncaoEnt> Buscar_ModProgramador(string busca)]"
                                    + Environment.NewLine
                                    + "[Linha 229]"
                                    + Environment.NewLine
                                    + ex);
                }
                return resultado;
            }
        }

        public static List<FuncaoEnt> Buscar_FuncoesPorLibLang(BibliotecaEnt busca)
        {
            using (var db = new Cany_ContextSQLite())
            {
                List<FuncaoEnt> resultado = new();
                try
                {
                    resultado = (from bibliotecas in db.TB_Bibliotecas
                                 join funcoes in db.TB_Funcoes
                                 on bibliotecas.ID_Linguagem equals busca.ID_Linguagem
                                 where bibliotecas.Biblioteca == busca.Biblioteca
                                 where funcoes.ID_FcnModData == bibliotecas.ID_FcnModData
                                 select funcoes).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static List<FuncaoEnt> Buscar_FuncoesPorLibLang(string busca)]"
                                    + Environment.NewLine
                                    + "[Linha 254]"
                                    + Environment.NewLine
                                    + ex);
                }
                return resultado;
            }
        }

        public static List<FuncaoEnt> Buscar_FuncoesPorLinguagem(BibliotecaEnt busca)
        {
            using (var db = new Cany_ContextSQLite())
            {
                List<FuncaoEnt> resultado = new();
                try
                {
                    resultado = (from bibliotecas in db.TB_Bibliotecas
                                 join funcoes in db.TB_Funcoes
                                 on bibliotecas.ID_Linguagem equals busca.ID_Linguagem
                                 //where bibliotecas.Biblioteca == busca.Biblioteca
                                 where funcoes.ID_FcnModData == bibliotecas.ID_FcnModData
                                 select funcoes).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static List<FuncaoEnt> Buscar_FuncoesPorLinguagem(string busca)]"
                                    + Environment.NewLine
                                    + "[Linha 282]"
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
                                    + "[Linha 310]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
        }

        public static void Remover(FuncaoEnt funcaoEnt)
        {
            using (var db = new Cany_ContextSQLite())
            {
                try
                {
                    db.TB_Funcoes.Remove(funcaoEnt);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class FuncoesRep]"
                                    + Environment.NewLine
                                    + "[public static void Remover(FuncaoEnt funcaoEnt)]"
                                    + Environment.NewLine
                                    + "[Linha 332]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
        }
    }
}
