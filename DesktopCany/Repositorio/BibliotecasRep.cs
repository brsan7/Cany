using DesktopCany.Entidades;

namespace DesktopCany.Repositorio
{
    class BibliotecasRep
    {
        public static List<string> SelecionarBibliotecas(string linguagem)
        {
            List<string> resultado = new() { "**Bibliotecas**" };
            using (var db = new CanyContext())
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
                                    + "[Linha 7]" 
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

        public static string BuscarDescricao(string linguagem, string biblioteca)
        {
            string resultado = "";
            using (var db = new CanyContext())
            {
                try
                {
                    resultado = (from bibliotecas in db.TB_Bibliotecas
                                 where bibliotecas.ID_Linguagem.Equals(linguagem)
                                 where bibliotecas.Biblioteca.Equals(biblioteca)
                                 select bibliotecas.DescricaoLib).First().ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class BibliotecaRep]" 
                                    + Environment.NewLine
                                    + "[public static List<string> BuscarDescricao(string linguagem)]"
                                    + Environment.NewLine
                                    + "[Linha 32]"
                                    + Environment.NewLine
                                    + ex);
                }
            }
            return resultado;
        }

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
                                    + "[Linha 57]"
                                    + Environment.NewLine
                                    + ex);
                }
                return resultado;
            }
        }

        public static List<BibliotecaEnt> Buscar_Biblioteca(string busca)
        {
            using (var db = new CanyContext())
            {
                List<BibliotecaEnt> resultado = new();
                try
                {
                    resultado = (from biblioteca in db.TB_Bibliotecas
                                 where biblioteca.Biblioteca.Contains(busca)
                                 select biblioteca).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class BibliotecasRep]"
                                    + Environment.NewLine
                                    + "[public static List<BibliotecaEnt> Buscar_Bibliotecas(string busca)]"
                                    + Environment.NewLine
                                    + "[Linha 82]"
                                    + Environment.NewLine
                                    + ex);
                }
                return resultado;
            }
        }

        public static List<BibliotecaEnt> Buscar_BibliotecasPorLinguagem(LinguagemEnt busca)
        {
            using (var db = new CanyContext())
            {
                List<BibliotecaEnt> resultado = new();
                try
                {
                    resultado = (from biblioteca in db.TB_Bibliotecas
                                 where biblioteca.ID_Linguagem.Equals(busca.ID_Linguagem)
                                 select biblioteca).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class BibliotecasRep]"
                                    + Environment.NewLine
                                    + "[public static BibliotecaEnt Buscar_BibliotecasPorLinguagem(BibliotecaEnt busca)]"
                                    + Environment.NewLine
                                    + "[Linha 107]"
                                    + Environment.NewLine
                                    + ex);
                }
                return resultado;
            }
        }

        public static List<BibliotecaEnt> Buscar_BibliotecasPorFuncao(BibliotecaEnt busca)
        {
            using (var db = new CanyContext())
            {
                List<BibliotecaEnt> resultado = new();
                try
                {
                    resultado = (from biblioteca in db.TB_Bibliotecas
                                 where biblioteca.ID_FcnModData.Equals(busca.ID_FcnModData)
                                 select biblioteca).ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("[class BibliotecasRep]"
                                    + Environment.NewLine
                                    + "[public static BibliotecaEnt Buscar_BibliotecasPorFuncao(BibliotecaEnt busca)]"
                                    + Environment.NewLine
                                    + "[Linha 132]"
                                    + Environment.NewLine
                                    + ex);
                }
                return resultado;
            }
        }

        public static bool Registrar(BibliotecaEnt RI)
        {
            using (var db = new CanyContext())
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
                                    + "[Linha 157]"
                                    + Environment.NewLine
                                    + ex);
                    return false;
                }
            }
        }
    }
}
