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

        LoginDAL loginDAL = new LoginDAL();
        Login login = new Login();

        internal Login RetornaLogin()
        {
            return login;
        }

        private void btnAutenticar_Click(object sender, EventArgs e)
        {
            login.Usuario = txtUsuario.Text;
            login.Senha = txtSenha.Text;

            login = loginDAL.Autenticar(login);

            if (login.Autenticado == false)
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
            else
            {
                MessageBox.Show("Logado");
                this.Close();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                btnAutenticar.PerformClick();
            }
        }
    }
}