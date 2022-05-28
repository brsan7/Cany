namespace DesktopCany.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ConsultaModificacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto da tela frmAluno
            FrmConsulta tela = new();

            //Prender dentro deste formulario (frmMenu)
            tela.MdiParent = this;

            //Exibir a tela
            tela.Show();
        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto da tela frmAluno
            FrmRegistro tela = new();

            //Prender dentro deste formulario (frmMenu)
            tela.MdiParent = this;
            tela.WindowState = FormWindowState.Maximized;

            //Exibir a tela
            tela.Show();
        }

        private void GerenciamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto da tela frmAluno
            FrmGerenciamento tela = new();

            //Prender dentro deste formulario (frmMenu)
            tela.MdiParent = this;
            tela.WindowState = FormWindowState.Maximized;

            //Exibir a tela
            tela.Show();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmMenu_Load(object? sender, EventArgs? e)
        {
            this.Text = Propriedades.Configuracoes.Default.AppTitulo;
            this.BackColor = Propriedades.Configuracoes.Default.CorDasTelas;

            Repositorio.Conexao status = new();

            consultaModificacaoToolStripMenuItem.Enabled = false;
            registroToolStripMenuItem.Enabled = false;
            backupToolStripMenuItem.Enabled = false;

            //if (Propriedades.Configuracoes.Default.EnderecoServidorSQL.ToString().Equals("urlDBSQLite.db"))
            //{
            //    lblUsuario.Text = "Status : Banco de Dados não configurado";
            //    MessageBox.Show("Configure a conexão com o Banco de Dados");
            //    ConfiguracoesToolStripMenuItem_Click(null, null);
            //}
            //else
            //{
            //    if (status.TestarConexao())
            //    {
            lblUsuario.Text = "Status : Conexão Estabelecida";
            consultaModificacaoToolStripMenuItem.Enabled = true;
            registroToolStripMenuItem.Enabled = true;
            backupToolStripMenuItem.Enabled = true;
            //    }
            //    else
            //    {
            //        lblUsuario.Text = "Status : Conexão não Estabelecida";
            //        MessageBox.Show("Verifique a configuração de conexão com o Banco de Dados");
            //        ConfiguracoesToolStripMenuItem_Click(null, null);
            //    }

            //}

            //FrmRegistro tela = new();
            FrmLogin tela = new();
            tela.MdiParent = this;
            //tela.WindowState = FormWindowState.Maximized;
            tela.Show();


            loginLogoutToolStripMenuItem.Text = "Login";

            //UI.frmLogin tela = new UI.frmLogin();
            //tela.ShowDialog();

            if (tela.RetornaLogin().Autenticado)
            {
                lblUsuario.Text = "Usuário logado: " + tela.RetornaLogin().Usuario;
                backupToolStripMenuItem.Enabled = true;

                loginLogoutToolStripMenuItem.Text = "Logout";
            }
        }

        private void ConfiguracoesToolStripMenuItem_Click(object? sender, EventArgs? e)
        {
            FrmConfiguracao tela = new();
            tela.MdiParent = this;
            tela.Show();
        }

        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackup tela = new();
            tela.MdiParent = this;
            tela.Show();
        }

        private void loginLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu_Load(null, null);
        }
    }
}
