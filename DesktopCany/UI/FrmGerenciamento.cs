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
            setupDSourceDgvs(null);
        }

        private void txtBuscarLinguagem_TextChanged(object sender, EventArgs e)
        {
            dgvLinguagens.DataSource = LinguagensRep.Buscar_Linguagem(txtBuscaLinguagens.Text);
        }

        private void txtBuscarBiblioteca_TextChanged(object sender, EventArgs e)
        {
            dgvBibliotecas.DataSource = BibliotecasRep.Buscar_Biblioteca(txtBuscarBibliotecas.Text);
        }

        private void txtBuscarFuncoes_TextChanged(object sender, EventArgs e)
        {
            dgvFuncoes.DataSource = FuncoesRep.Buscar_Funcao(txtBuscarFuncoes.Text);
        }

        private void txtBuscarModData_TextChanged(object sender, EventArgs e)
        {
            dgvFuncoes.DataSource = FuncoesRep.Buscar_ModData(txtFcnModData.Text);
        }

        private void txtBuscarModProgramador_TextChanged(object sender, EventArgs e)
        {
            dgvFuncoes.DataSource = FuncoesRep.Buscar_ModProgramador(txtModProgramador.Text);
        }

        private void dgvLinguagens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id_Linguagem = dgvLinguagens.SelectedRows[0].Cells["ID_Linguagem"].Value.ToString();
            BibliotecaEnt bibliotecaEnt = new()
            {
                ID_Linguagem = id_Linguagem,
                FK_ID_Linguagem = new() { ID_Linguagem = id_Linguagem }
            };
            setupDSourceDgvs(bibliotecaEnt);
            if(dgvBibliotecas.RowCount == 0)
            {
                btnRemove.Enabled = true;
                btnRemove.Text = "Remover Linguagem";
            }
        }

        private void dgvBibliotecas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BibliotecaEnt bibliotecaEnt = new() 
            {
                ID_Linguagem = dgvBibliotecas.SelectedRows[0].Cells["ID_Linguagem"].Value.ToString(),
                Biblioteca = dgvBibliotecas.SelectedRows[0].Cells["Biblioteca"].Value.ToString(),
            };
            setupDSourceDgvs(bibliotecaEnt);
        }

        private void dgvFuncoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID_FcnModData = dgvFuncoes.SelectedRows[0].Cells["ID_FcnModData"].Value.ToString();
            BibliotecaEnt bibliotecaEnt = new()
            {
                ID_FcnModData = ID_FcnModData,
                FK_ID_FcnModData = new() { ID_FcnModData = ID_FcnModData }
            };
            setupDSourceDgvs(bibliotecaEnt);
            btnRemove.Enabled = true;
            btnRemove.Text = "Remover Modificação";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBuscaLinguagens.Clear();
            txtBuscarBibliotecas.Clear();
            txtBuscarFuncoes.Clear();
            txtFcnModData.Clear();
            txtModProgramador.Clear();
            setupDSourceDgvs(null);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (btnRemove.Text.Equals("Remover Modificação"))
            {
                var resposta = MessageBox.Show("Deseja Remover a Função?"
                            + Environment.NewLine
                            + "[" + dgvFuncoes.SelectedRows[0].Cells["ID_FcnModData"].Value.ToString() + "] - "
                            + dgvFuncoes.SelectedRows[0].Cells["Funcao"].Value.ToString(),
                                            "Confirmação",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    FuncaoEnt funcaoEnt = new()
                    {
                        ID_FcnModData = dgvFuncoes.SelectedRows[0].Cells["ID_FcnModData"].Value.ToString()
                    };
                    FuncoesRep.Remover(funcaoEnt);
                    MessageBox.Show("Função Removida");
                    setupDSourceDgvs(null);
                }
            }

            if (btnRemove.Text.Equals("Remover Linguagem"))
            {
                var resposta = MessageBox.Show("Deseja Remover a Linguagem?"
                                + Environment.NewLine
                                + "[" +
                                dgvLinguagens.SelectedRows[0].Cells["ID_Linguagem"].Value.ToString()
                                + "]",
                                            "Confirmação",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    LinguagemEnt linguagemEnt = new()
                    {
                        ID_Linguagem = dgvLinguagens.SelectedRows[0].Cells["ID_Linguagem"].Value.ToString()
                    };
                    LinguagensRep.Remover(linguagemEnt);
                    MessageBox.Show("Linguagem Removida");
                    setupDSourceDgvs(null);
                }
            }
        }

        private void setupDSourceDgvs(BibliotecaEnt? buscas)
        {
            btnRemove.Enabled = false;
            btnRemove.Text = "Remover";
            //Apresenta todos os registros
            if (buscas == null)
            {
                dgvLinguagens.DataSource = LinguagensRep.SelecionarTB_Linguagens();
                dgvBibliotecas.DataSource = BibliotecasRep.SelecionarTB_Bibliotecas();
                dgvFuncoes.DataSource = FuncoesRep.SelecionarTB_Funcoes();
            }

            //Apresenta todos os registros relacionado a linguagem selecionada
            if (buscas?.FK_ID_Linguagem != null)
            {
                dgvLinguagens.DataSource = LinguagensRep.Buscar_Linguagem(buscas.ID_Linguagem);
                dgvBibliotecas.DataSource = BibliotecasRep.Buscar_BibliotecasPorLinguagem(buscas.FK_ID_Linguagem);
                dgvFuncoes.DataSource = FuncoesRep.Buscar_FuncoesPorLinguagem(buscas);
            }

            //Apresenta todos os registros relacionado a biblioteca selecionada
            if (buscas?.Biblioteca.Length > 0 
                && buscas?.ID_Linguagem.Length > 0)
            {
                dgvLinguagens.DataSource = LinguagensRep.Buscar_Linguagem(buscas.ID_Linguagem);
                dgvBibliotecas.DataSource = BibliotecasRep.Buscar_Biblioteca(buscas.Biblioteca);
                dgvFuncoes.DataSource = FuncoesRep.Buscar_FuncoesPorLibLang(buscas);
            }

            //Apresenta um unico registro de função e suas relações
            if (buscas?.FK_ID_FcnModData != null)
            {
                List<BibliotecaEnt> selecao = BibliotecasRep.Buscar_BibliotecasPorFuncao(buscas);
                buscas.ID_Linguagem = selecao.First().ID_Linguagem;
                buscas.Biblioteca = selecao.First().Biblioteca;
                buscas.FK_ID_FcnModData = FuncoesRep.BuscarMod(buscas);

                dgvLinguagens.DataSource = LinguagensRep.Buscar_Linguagem(buscas.ID_Linguagem);
                dgvBibliotecas.DataSource = selecao;
                dgvFuncoes.DataSource = new List<FuncaoEnt>() { buscas.FK_ID_FcnModData };
            }
            dgvBibliotecas.Columns[5].Visible = false;
            dgvBibliotecas.Columns[6].Visible = false;
        }
    }
}
