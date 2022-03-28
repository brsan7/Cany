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
    public partial class FrmGerenciamento : Form
    {
        public FrmGerenciamento()
        {
            InitializeComponent();
        }

        private void FrmGerenciamentoDb_OnLoad(object sender, EventArgs e)
        {
            //Configurar DataGridView
            //Evitar Edição
            dgvLinguagens.ReadOnly = true;
            //Evitar adicionar linhas (Cadastro direto na grid)
            dgvLinguagens.AllowUserToAddRows = false;
            //Evitar excluir linha
            dgvLinguagens.AllowUserToDeleteRows = false;
            //Evitar selecionar mais de uma linha
            dgvLinguagens.MultiSelect = false;
            //Ajustar colunas para ocupar o espaço disponivel
            dgvLinguagens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Remover cabeçalho da linha (seta lateral)
            dgvLinguagens.RowHeadersVisible = false;
            //Evitar resize de linha
            dgvLinguagens.AllowUserToResizeRows = false;
            //Selecionar a linha inteira independente de qual selula clicar
            dgvLinguagens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvBibliotecas.ReadOnly = true;
            dgvBibliotecas.AllowUserToAddRows = false;
            dgvBibliotecas.AllowUserToDeleteRows = false;
            dgvBibliotecas.MultiSelect = false;
            dgvBibliotecas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBibliotecas.RowHeadersVisible = false;
            dgvBibliotecas.AllowUserToResizeRows = false;
            dgvBibliotecas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvFuncoes.ReadOnly = true;
            dgvFuncoes.AllowUserToAddRows = false;
            dgvFuncoes.AllowUserToDeleteRows = false;
            dgvFuncoes.MultiSelect = false;
            dgvFuncoes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFuncoes.RowHeadersVisible = false;
            dgvFuncoes.AllowUserToResizeRows = false;
            dgvFuncoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



            //Configura a fonte de dados
            dgvLinguagens.DataSource = LinguagensRep.SelecionarTB_Linguagens();
            dgvBibliotecas.DataSource = BibliotecasRep.SelecionarTB_Bibliotecas();
            dgvFuncoes.DataSource = FuncoesRep.SelecionarTB_Funcoes();
        }
    }
}
