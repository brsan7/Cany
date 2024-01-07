namespace DesktopCany.UI
{
    public partial class FrmConfiguracao : Form
    {
        public FrmConfiguracao()
        {
            InitializeComponent();
        }

        Color corFundo = Propriedades.Configuracoes.Default.BackColor;
        Color corTexto = Propriedades.Configuracoes.Default.ForeColor;

        private void frmConfiguracao_Load(object? sender, EventArgs? e)
        {
            chkBoxBorder.Checked = Propriedades.Configuracoes.Default.BorderStyle;
            txtConexao.Text = Propriedades.Configuracoes.Default.StringConexao;
            txtCorFundo.Text = Propriedades.Configuracoes.Default.BackColor.ToString();
            txtCorTexto.Text = Propriedades.Configuracoes.Default.ForeColor.ToString();
            this.BackColor = Propriedades.Configuracoes.Default.BackColor;
            this.ForeColor = Propriedades.Configuracoes.Default.ForeColor;
            groupBox1.ForeColor = Propriedades.Configuracoes.Default.ForeColor;
            groupBox2.ForeColor = Propriedades.Configuracoes.Default.ForeColor;
            btnCorFundo.ForeColor = Color.Black;
            btnCorText.ForeColor = Color.Black;
            btnRestaurar.ForeColor = Color.Black;
            btnSalvar.ForeColor = Color.Black;
            setupServer();
        }
        private void btnCorText_Click(object sender, EventArgs e)
        {
            DialogResult resposta = colorDialog1.ShowDialog();
            if (resposta != DialogResult.Cancel)
            {

                txtCorTexto.Text = colorDialog1.Color.ToString();
                corTexto = colorDialog1.Color;
            }
        }
        private void btnCor_Click(object sender, EventArgs e)
        {
            DialogResult resposta = colorDialog2.ShowDialog();
            if (resposta != DialogResult.Cancel)
            {

                txtCorFundo.Text = colorDialog2.Color.ToString();
                corFundo = colorDialog2.Color;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Propriedades.Configuracoes.Default.BorderStyle = chkBoxBorder.Checked;
            Propriedades.Configuracoes.Default.ForeColor = corTexto;
            Propriedades.Configuracoes.Default.BackColor = corFundo;
            Propriedades.Configuracoes.Default.DataBaseLocal = cBoxLite.Text;
            Propriedades.Configuracoes.Default.StringConexao = txtConexao.Text;
            Propriedades.Configuracoes.Default.Save();

            string msg = "Configurações salvas!";
            MessageBox.Show(
                msg,
                "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2
                );

            this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            frmConfiguracao_Load(null, null);
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            DialogResult resposta = folderBrowserDialog1.ShowDialog();
            if (resposta != DialogResult.Cancel)
            {

                Propriedades.Configuracoes.Default.PastaLocal = folderBrowserDialog1.SelectedPath;
                Propriedades.Configuracoes.Default.Save();
                cBoxLite.Text = String.Empty;
                rbtnLocal_CheckedChanged(null, null);
                setupServer();
            }
        }

        private void rbtnLocal_CheckedChanged(object? sender, EventArgs? e)
        {
            Propriedades.Configuracoes.Default.TipoServidor = "SQLITE";
            txtConexao.Enabled = false;
            cBoxLite.Enabled = true;
            cBoxLite.Items.Clear();
            List<string> sqliteBases = new();
            try
            {
                sqliteBases = new List<string>(
                    Directory.EnumerateFiles(
                    Propriedades.Configuracoes.Default.PastaLocal)
                    );
            }
            catch
            {
                MessageBox.Show("Pasta não encontrada.");
            }
            foreach (var item in sqliteBases)
            {
                if (item.Substring(item.Length - 3, 3).Equals(".db"))
                {
                    cBoxLite.Items.Add(item.Split("\\")[item.Split("\\").Length - 1]);
                }
            }
            cBoxLite.SelectedIndex = cBoxLite.Items.IndexOf(
                Propriedades.Configuracoes.Default.DataBaseLocal);
        }

        private void rbtnServidor_CheckedChanged(object sender, EventArgs e)
        {
            Propriedades.Configuracoes.Default.TipoServidor = "SQLSERVER";
            txtConexao.PlaceholderText = "digite a string de conexão";
            txtConexao.Enabled = true;
            cBoxLite.Enabled = false;
        }
        
        private void setupServer()
        {
            if (Propriedades.Configuracoes.Default.TipoServidor.Equals("SQLITE"))
            {
                rbtnLocal.Checked = true;
            }
            else
            {
                rbtnServidor.Checked = true;
            }
        }

        
    }
}
