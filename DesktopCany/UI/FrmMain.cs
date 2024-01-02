using DesktopCany.Entidades;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopCany.UI
{
    public partial class FrmMain : Form
    {
        private bool conf = true;
        private string config = "Colaborador";
        private string propColaborador = Propriedades.Configuracoes.Default.Colaborador;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.Text = Propriedades.Configuracoes.Default.AppTitulo;
            this.BackColor = Propriedades.Configuracoes.Default.CorDasTelas;

            DisableStripMenu();

            if (!propColaborador.Equals(String.Empty))
            {
                config = "DataBase";
            }

            VerificaConfiguracao();

            if (config.Equals("Configurado"))
            {
                EnableStripMenu();
                lblUsuario.Text = "Colaborador: " + propColaborador;
            }
            else
            {
                FrmMain_MdiChildActivate(null, null);
            }
        }

        /*
         * ######################################################################
         * INICIO FUNÇÕES 
         * ######################################################################
         */
        private void DisableStripMenu()
        {
            consultaModificacaoToolStripMenuItem.Enabled = false;
            registroToolStripMenuItem.Enabled = false;
            backupToolStripMenuItem.Enabled = false;
            gerenciamentoToolStripMenuItem.Enabled = false;
            janelasAbertasToolStripMenuItem.Enabled = false;
            configuraçõesToolStripMenuItem.Enabled = false;
        }
        private void EnableStripMenu()
        {
            consultaModificacaoToolStripMenuItem.Enabled = true;
            registroToolStripMenuItem.Enabled = true;
            backupToolStripMenuItem.Enabled = true;
            gerenciamentoToolStripMenuItem.Enabled = true;
            janelasAbertasToolStripMenuItem.Enabled = true;
            configuraçõesToolStripMenuItem.Enabled = true;
        }

        private void ConfigColaborador()
        {
            MessageBox.Show("O Colaborador não está configurado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            LoginToolStripMenuItem_Hide();
            conf = true;
        }

        private void ConfigDataBase()
        {
            conf = true;
            if (CanyContext.genesis)
            {
                string msg = "O Banco de dados (Desenvolvimento) não está configurado.\n\n*Configure a conexão em CanyContext.cs*";
                MessageBox.Show(msg, "Alerta - Conexão não estabelecida", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                this.Close();
            }
            else
            {
                string msg = "O Banco de dados não está configurado.";
                MessageBox.Show(msg, "Alerta - Conexão não estabelecida", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                ConfiguracoesToolStripMenuItem_Click(this, null);
            }
        }

        private void VerificaConfiguracao()
        {
            propColaborador = Propriedades.Configuracoes.Default.Colaborador;

            if (propColaborador.Length>0
                && Repositorio.Conexao.TestarConexao() == true)
            {
                config = "Configurado";
                conf = false;
            }
        }

        private void AbrirJanelaNormal(Form tela)
        {
            FecharJanelasUnicas();
            tela.MdiParent = this;
            tela.WindowState = FormWindowState.Normal;
            tela.Show();
        }

        private void AbrirJanelaMaximizada(Form tela)
        {
            FecharJanelasUnicas();
            tela.MdiParent = this;
            tela.WindowState = FormWindowState.Maximized;
            tela.Show();
        }

        private void FecharJanelasUnicas()
        {
            foreach (var janela in this.MdiChildren)
            {
                if (!janela.Text.Contains("lang:"))
                {
                    janela.Close();
                }
            }
        }
        /*
         * ######################################################################
         * FINAL FUNÇÕES
         * ######################################################################
         */

        /*
         * ######################################################################
         * INICIO EVENTOS 
         * ######################################################################
         */
        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        
        private void ConsultaModificacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //desabilitado
            AbrirJanelaNormal(new FrmConsulta());
        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirJanelaMaximizada(new FrmRegistro());
        }

        private void GerenciamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirJanelaMaximizada(new FrmGerenciamento());
        }

        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirJanelaMaximizada(new FrmBackup());
        }

        private void ConfiguracoesToolStripMenuItem_Click(object? sender, EventArgs? e)
        {
            AbrirJanelaNormal(new FrmConfiguracao());
        }

        private void LoginToolStripMenuItem_Hide()
        {
            //configuração inicial
            AbrirJanelaNormal(new FrmLogin());
        }

        private void loginLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu_Load(null, null);
        }

        private void FrmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (conf && FrmMain.ActiveForm?.ActiveMdiChild?.ToString()==null)
            {
                VerificaConfiguracao();

                switch (config)
                {
                    case "Colaborador":
                        if (Repositorio.Conexao.TestarConexao() == false)
                        {
                            config = "DataBase";
                        }
                        conf = false;
                        ConfigColaborador();
                        break;

                    case "DataBase":
                        if (propColaborador.Equals(String.Empty))
                        {
                            config = "Colaborador";
                        }
                        conf = false;
                        ConfigDataBase();
                        break;

                    case "Configurado":
                        FrmMenu_Load(null, null);
                        break;
                    default:
                        
                        break;
                }
            }
        }
        /*
         * ######################################################################
         * FINAL EVENTOS 
         * ######################################################################
         */
    }
}
