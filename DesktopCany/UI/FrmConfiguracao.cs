using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCany.UI
{
    public partial class FrmConfiguracao : Form
    {
        public FrmConfiguracao()
        {
            InitializeComponent();
        }

        private void frmConfiguracao_Load(object? sender, EventArgs? e)
        {
            txtTitulo.Text = Propriedades.Configuracoes.Default.AppTitulo;
            txtNomeBase.Text = Propriedades.Configuracoes.Default.NomeBaseDeDados;
            txtEndereco.Text = Propriedades.Configuracoes.Default.EnderecoServidorSQL;
            txtCor.Text = Propriedades.Configuracoes.Default.CorDasTelas.ToString();
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            DialogResult resposta = colorDialog1.ShowDialog();
            if(resposta != DialogResult.Cancel)
            {
                Propriedades.Configuracoes.Default.CorDasTelas = colorDialog1.Color;
                txtCor.Text = colorDialog1.Color.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Propriedades.Configuracoes.Default.AppTitulo = txtTitulo.Text;
            Propriedades.Configuracoes.Default.EnderecoServidorSQL = txtEndereco.Text;
            Propriedades.Configuracoes.Default.NomeBaseDeDados = txtNomeBase.Text;

            Propriedades.Configuracoes.Default.Save();

            MessageBox.Show("Configurações salvas! \n\n Para que as alterações sejam aplicadas reinicie o programa.");
            this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            frmConfiguracao_Load(null, null);
        }
    }
}
