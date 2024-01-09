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
                catch
                {
                    configurado = false;
                }
            }
            return configurado;
        }
    }
}
