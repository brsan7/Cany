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
    public partial class FrmRegistro : Form
    {
        private BibliotecaEnt biblitotecaEnt = new();
        private List<string> lstLinguagens = new();
        private List<string> lstBibliotecas = new();
        private List<string> lstFuncoes = new();
        private List<string> lstFcnModDatas = new();
        private List<string> lstModProgramadores = new();
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistroOnLoad(object sender, EventArgs e)
        {
            biblitotecaEnt.FK_ID_FcnModData = new FuncaoEnt();
            lstLinguagens = new(LinguagensRep.SelecionarLinguagens());
            cmbLinguagens.Items.Clear();
            //int index = 0;
            //foreach (var linguagem in lstLinguagens)
            //{
            //    cmbLinguagens.Items.Insert(index, linguagem);
            //    index++;
            //}
            lstLinguagens.ForEach(linguagenslst => cmbLinguagens.Items.Add(linguagenslst));
            cmbLinguagens.SelectedIndex = 0;
            /*
            cmbLinguagens.DataSource = lstLinguagens;
            cmbBibliotecas.DataSource = lstBibliotecas;
            cmbFuncoes.DataSource = lstFuncoes;
            cmbFcnModDatas.DataSource = lstFcnModData;
            cmbModProgramadores.DataSource = lstModProgramador;
            */
        }

        private void CmbLinguagens_TextChanged(object sender, EventArgs e)
        {
            if (cmbLinguagens.SelectedIndex == -1
                && !cmbLinguagens.Text.Equals("Linguagens")
                && btnRegMod.Text.Equals("RegMod"))
            {
                btnRegMod.Text = "RegNewLang";
                btnRegMod.Enabled = true;
                rtbDescricaoLang.Enabled = true;
                setup_RegNew();
            }
        }

        private void CmbBibliotecas_TextChanged(object sender, EventArgs e)
        {
            if (cmbBibliotecas.SelectedIndex == -1
                && !cmbLinguagens.Text.Equals("Linguagens")
                && !cmbBibliotecas.Text.Equals("Bibliotecas")
                && btnRegMod.Text.Equals("RegMod"))
            {
                //cmbLinguagens.DropDownStyle = ComboBoxStyle.DropDownList;
                btnRegMod.Text = "RegNewLib";
                btnRegMod.Enabled = true;
                rtbDescricaoLib.Enabled = true;
                setup_RegNew();
            }
        }

        private void CmbFuncoes_TextChanged(object sender, EventArgs e)
        {
            if (cmbFuncoes.SelectedIndex == -1
                && !cmbLinguagens.Text.Equals("Linguagens")
                && !cmbBibliotecas.Text.Equals("Bibliotecas")
                && !cmbFuncoes.Text.Equals("Funcoes")
                && btnRegMod.Text.Equals("RegMod"))
            {
                //cmbLinguagens.DropDownStyle = ComboBoxStyle.DropDownList;
                //cmbBibliotecas.DropDownStyle = ComboBoxStyle.DropDownList;
                btnRegMod.Text = "RegNewFcn";
                btnRegMod.Enabled = true;
                rtbDescricaoFcn.Enabled = true;
                setup_RegNew();
            }
        }

        private void CmbLinguagens_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetFrmRegistro();
            if (cmbLinguagens.SelectedIndex > 0)
            {
                biblitotecaEnt.ID_Linguagem = cmbLinguagens.Text;
                lstBibliotecas = new(BibliotecasRep.SelecionarBibliotecas(cmbLinguagens.Text));
                //cmbBibliotecas.DataSource = lstBibliotecas;
                cmbBibliotecas.Items.Clear();
                //int index = 0;
                //foreach (var biblioteca in lstBibliotecas)
                //{
                //    cmbBibliotecas.Items.Insert(index, biblioteca);
                //    index++;
                //}
                lstBibliotecas.ForEach(biblitotecaslst => cmbBibliotecas.Items.Add(biblitotecaslst));
                cmbBibliotecas.SelectedIndex = 0;
                rtbDescricaoLang.Enabled = true;
                cmbBibliotecas.Enabled = true;
                rtbDescricaoLang.Text = LinguagensRep.BuscarDescricao(cmbLinguagens.Text);
            }
        }

        private void CmbBibliotecas_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetFrmRegistro();
            if (cmbBibliotecas.SelectedIndex > 0)
            {
                biblitotecaEnt.Biblioteca = cmbBibliotecas.Text;

                lstFuncoes = new(FuncoesRep.SelecionarFuncoes(biblitotecaEnt));
                ////cmbFuncoes.DataSource = lstFuncoes;
                cmbFuncoes.Items.Clear();
                //int index = 0;
                //foreach (var funcao in lstFuncoes)
                //{
                //    cmbFuncoes.Items.Insert(index, funcao);
                //    index++;
                //}
                lstFuncoes.ForEach(funcoeslst => cmbFuncoes.Items.Add(funcoeslst)) ;
                cmbFuncoes.Items.Insert(0, lstFuncoes);
                cmbFuncoes.SelectedIndex = 0;

                cmbFuncoes.Enabled = true;
                rtbDescricaoLib.Enabled = true;
                rtbDescricaoLib.Text = BibliotecasRep.BuscarDescricao(cmbLinguagens.Text);
            }
        }

        private void CmbFuncoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetFrmRegistro();
            if (cmbFuncoes.SelectedIndex > 0
                && cmbLinguagens.SelectedIndex > 0
                && cmbBibliotecas.SelectedIndex > 0)
            {
                biblitotecaEnt.FK_ID_FcnModData = new();
                biblitotecaEnt.FK_ID_FcnModData.Funcao = cmbFuncoes.Text;

                cmbFcnModDatas.Enabled = true;
                cmbModProgramadores.Enabled = true;

                lstFcnModDatas = new(FuncoesRep.SelecionarModDatas(biblitotecaEnt));
                ////cmbFcnModDatas.DataSource = lstModData;
                cmbFcnModDatas.Items.Clear();
                //int index = 0;
                //foreach (var fcnModData in lstFcnModDatas)
                //{
                //    cmbFcnModDatas.Items.Insert(index, fcnModData);
                //    index++;
                //}
                lstFcnModDatas.ForEach(fcnModDatalst => cmbFcnModDatas.Items.Add(fcnModDatalst));
                //cmbFcnModDatas.SelectedIndex = 0;

                lstModProgramadores = new(FuncoesRep.SelecionarModProgramadores(biblitotecaEnt));
                ////cmbModProgramadores.DataSource = lstModProgramador;
                cmbModProgramadores.Items.Clear();
                //index = 0;
                //foreach (var modProgramador in lstModProgramadores)
                //{
                //    cmbModProgramadores.Items.Insert(index, modProgramador);
                //    index++;
                //}
                lstModProgramadores.ForEach(modProgramadorlst => cmbModProgramadores.Items.Add(modProgramadorlst));


                List<FuncaoEnt> modsFuncao = new();
                modsFuncao.AddRange(FuncoesRep.SelecionarModsFuncao(biblitotecaEnt).Distinct());
                biblitotecaEnt.FK_ID_FcnModData = modsFuncao.Last();

                cmbFcnModDatas.SelectedIndex = cmbFcnModDatas.Items.Count - 1;
                cmbModProgramadores.SelectedIndex = 0;

                /*observar o comportamento*//*
                cmbLinguagens.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbBibliotecas.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbFuncoes.DropDownStyle = ComboBoxStyle.DropDownList;
                /*observar o comportamento*/

                rtbDescricaoFcn.Enabled = true;
                rtbSnippet.Enabled = true;
                rtbDescricaoFcn.Text = biblitotecaEnt.FK_ID_FcnModData.DescricaoFcn;
                rtbSnippet.Text = biblitotecaEnt.FK_ID_FcnModData.Snippet;



                btnRegMod.Enabled = true;
            }
        }

        private void CmbFcnModDatas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFcnModDatas.SelectedIndex != 0)
            {
                biblitotecaEnt.FK_ID_FcnModData.ID_FcnModData = cmbFcnModDatas.Text;
                biblitotecaEnt.FK_ID_FcnModData = FuncoesRep.BuscarMod(biblitotecaEnt);
                rtbDescricaoFcn.Text = biblitotecaEnt.FK_ID_FcnModData.DescricaoFcn;
                rtbSnippet.Text = biblitotecaEnt.FK_ID_FcnModData.Snippet;
            }
        }

        private void CmbModProgramadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModProgramadores.SelectedIndex != 0)
            {
                //
            }
        }

        private void ChkBoxModEstavel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
        private void BtnRegMod_OnClick(object sender, EventArgs e)
        {
            BibliotecaEnt inAgrupamentoEnt = ComporRegistro();
            if (!BibliotecasRep.Registrar(inAgrupamentoEnt))
            {
                //MessageBox.Show("Inserido");
                FuncoesRep.Registrar(inAgrupamentoEnt.FK_ID_FcnModData);
                BibliotecaEnt agrupamentoEnt = new()
                {
                    Biblioteca = inAgrupamentoEnt.Biblioteca,
                    DescricaoLib = inAgrupamentoEnt.DescricaoLib,
                    ID_Linguagem = inAgrupamentoEnt.ID_Linguagem,
                    ID_FcnModData = FuncoesRep.Consultar("").Last().ID_FcnModData,
                    FK_ID_Linguagem = null,
                    FK_ID_FcnModData = null
                };
                BibliotecasRep.Registrar(agrupamentoEnt);
            }
            MessageBox.Show("Registrado");
        }
        private BibliotecaEnt ComporRegistro()
        {
            LinguagemEnt inLinguagemEnt = new()
            {
                ID_Linguagem = cmbLinguagens.Text,
                DescricaoLang = rtbDescricaoLang.Text,
            };
            FuncaoEnt inFuncaoEnt = new()
            {
                ID_FcnModData = DateTime.Now.ToString(),
                Funcao = cmbFuncoes.Text,
                DescricaoFcn = rtbDescricaoFcn.Text,
                ModProgramador = cmbModProgramadores.Text,
                Snippet = rtbSnippet.Text,
            };
            BibliotecaEnt inBibliotecaEnt = new()
            {
                Biblioteca = cmbBibliotecas.Text,
                DescricaoLib = rtbDescricaoLib.Text,
                FK_ID_Linguagem = inLinguagemEnt,
                FK_ID_FcnModData = inFuncaoEnt
            };
            return inBibliotecaEnt;
        }

        private void setup_RegNew()
        {
            if (btnRegMod.Text.Equals("RegNewLang"))
            {
                rtbDescricaoLang.Text = "Descrição da Linguagem";

                //cmbBibliotecas.DropDownStyle = ComboBoxStyle.DropDown;
                cmbBibliotecas.Enabled = true;
                cmbBibliotecas.Text = "Biblioteca";
            }

            if (btnRegMod.Text.Equals("RegNewLib")
                || btnRegMod.Text.Equals("RegNewLang"))
            {
                rtbDescricaoLib.Text = "Descrição da Biblioteca";

                //cmbFuncoes.DropDownStyle = ComboBoxStyle.DropDown;
                cmbFuncoes.Enabled = true;
                cmbFuncoes.Text = "Função";
            }

            if (btnRegMod.Text.Equals("RegNewFcn")
                || btnRegMod.Text.Equals("RegNewLib")
                || btnRegMod.Text.Equals("RegNewLang"))
            {
                rtbDescricaoFcn.Text = "Descrição da Função";
                rtbSnippet.Text = "Snippet da Função";

                //cmbModProgramadores.DropDownStyle = ComboBoxStyle.DropDown;
                cmbModProgramadores.Enabled = true;
                cmbModProgramadores.Text = "Programador";
            }
        }

        private void resetFrmRegistro()
        {
            if (cmbLinguagens.SelectedIndex == 0)
            {
                //cmbLinguagens.DropDownStyle = ComboBoxStyle.DropDown;

                lstLinguagens = new(LinguagensRep.SelecionarLinguagens());
                ////cmbLinguagens.DataSource = lstLinguagens;
                cmbLinguagens.Items.Clear();
                //int index = 0;
                //foreach (var linguagem in lstLinguagens)
                //{
                //    cmbLinguagens.Items.Insert(index, linguagem);
                //    index++;
                //}
                lstLinguagens.ForEach(linguagenslst => cmbLinguagens.Items.Add(linguagenslst));

                cmbBibliotecas.Enabled = false;
                cmbFuncoes.Enabled = false;
                cmbBibliotecas.Text = String.Empty;
                rtbDescricaoLang.Text = String.Empty;
                rtbDescricaoLang.Enabled = false;
            }

            if (cmbBibliotecas.SelectedIndex == 0
                || cmbLinguagens.SelectedIndex == 0)
            {
                //cmbLinguagens.DropDownStyle = ComboBoxStyle.DropDown;
                //cmbBibliotecas.DropDownStyle = ComboBoxStyle.DropDown;

                cmbFuncoes.Enabled = false;
                cmbFuncoes.Text = String.Empty;
                rtbDescricaoLib.Text = String.Empty;
                rtbDescricaoLib.Enabled = false;


            }

            if (cmbFuncoes.SelectedIndex == 0
                || cmbBibliotecas.SelectedIndex == 0
                || cmbLinguagens.SelectedIndex == 0)
            {
                //cmbFuncoes.DropDownStyle = ComboBoxStyle.DropDown;

                cmbFcnModDatas.Enabled = false;
                cmbModProgramadores.Enabled = false;
                cmbFcnModDatas.Text = String.Empty;
                cmbModProgramadores.Text = String.Empty;
                rtbDescricaoFcn.Text = String.Empty;
                rtbSnippet.Text = String.Empty;
                rtbDescricaoFcn.Enabled = false;
                rtbSnippet.Enabled = false;
                btnRegMod.Text = "RegMod";
                btnRegMod.Enabled = false;


            }
        }
    }
}
