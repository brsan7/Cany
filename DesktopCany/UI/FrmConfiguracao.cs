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
            txtNomeBase.Text = Propriedades.Configuracoes.Default.NomeBaseDeDados;
            txtEndereco.Text = Propriedades.Configuracoes.Default.EnderecoServidorSQL;
            txtCorFundo.Text = Propriedades.Configuracoes.Default.BackColor.ToString();
            txtCorTexto.Text = Propriedades.Configuracoes.Default.ForeColor.ToString();
            this.BackColor = Propriedades.Configuracoes.Default.BackColor;
            this.ForeColor = Propriedades.Configuracoes.Default.ForeColor;
            btnCorFundo.ForeColor = Color.Black;
            btnCorText.ForeColor = Color.Black;
            btnRestaurar.ForeColor = Color.Black;
            btnSalvar.ForeColor = Color.Black;
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
            Propriedades.Configuracoes.Default.EnderecoServidorSQL = txtEndereco.Text;
            Propriedades.Configuracoes.Default.NomeBaseDeDados = txtNomeBase.Text;
            Propriedades.Configuracoes.Default.Save();

            string msg = "Configurações salvas!";
            msg = $"{msg}{Environment.NewLine}";
            msg = $"{msg}As configurações serão aplicadas após o reinicio.";
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
    }
}
