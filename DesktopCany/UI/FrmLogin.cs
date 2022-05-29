using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopCany.Entidades;
using DesktopCany.Repositorio;

namespace DesktopCany.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        LoginREP loginREP = new LoginREP();
        Login login = new Login();
        List<string> colaboradorList = new List<string>();

        internal Login RetornaLogin()
        {
            login.Usuario = "Bruno";
            return login;
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            login.Usuario = txtUsuario.Text;
            
            var colaborador = Propriedades.Configuracoes.Default.Colaborador;
            if (txtUsuario.Text.Equals(String.Empty))
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
            else
            {
                
                Propriedades.Configuracoes.Default.Colaborador = txtUsuario.Text;
                Propriedades.Configuracoes.Default.Save();
                MessageBox.Show("Configurações salvas! \n\n Para que as alterações sejam aplicadas reinicie o software.");
                this.Close();
            }
            /*
            else
            {
                login.Usuario = txtUsuario.Text;
                MessageBox.Show("Configurações salvas! \n\n Para que as alterações sejam aplicadas reinicie o programa.");
                //this.Close();
            }
            */
            //login.Senha = txtSenha.Text;
            //login.Autenticado = true;
            /*
            if (login.Autenticado == false)
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
            else
            {
                MessageBox.Show("Logado");
                this.Close();
            }
            */
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                btnAutenticar.PerformClick();
            }
        }

        private void FrmLoginOnLoad(object sender, EventArgs e)
        {
            
        }
    }
}