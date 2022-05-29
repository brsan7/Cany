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
        private bool firstScan = true;
        private string operacao = "Modificação";

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistroOnLoad(object sender, EventArgs e)
        {
            biblitotecaEnt.FK_ID_FcnModData = new FuncaoEnt();

            cmbLinguagens.Items.Clear();
            lstLinguagens = new(LinguagensRep.SelecionarLinguagens());
            lstLinguagens.ForEach(linguagenslst => cmbLinguagens.Items.Add(linguagenslst));
            cmbLinguagens.SelectedIndex = 0;

            rtbDescricaoLib.Enabled=false;
            rtbDescricaoFcn.Enabled=false;
        }

        private void CmbLinguagens_TextChanged(object sender, EventArgs e)
        {
            if (cmbLinguagens.SelectedIndex == -1
                && !cmbLinguagens.Text.Equals("Linguagens")
                && btnRegMod.Text.Equals("RegMod"))
            {
                btnRegMod.Text = "RegNewLang";
                operacao = "Linguagem";
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
                btnRegMod.Text = "RegNewLib";
                operacao = "Biblioteca";
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
                btnRegMod.Text = "RegNewFcn";
                operacao = "Função";
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

                cmbBibliotecas.Items.Clear();
                lstBibliotecas = new(BibliotecasRep.SelecionarBibliotecas(cmbLinguagens.Text));
                lstBibliotecas.ForEach(biblitotecaslst => cmbBibliotecas.Items.Add(biblitotecaslst));
                cmbBibliotecas.SelectedIndex = 0;
                cmbBibliotecas.Enabled = true;

                rtbDescricaoLang.Enabled = true;
                rtbDescricaoLang.Text = LinguagensRep.BuscarDescricao(cmbLinguagens.Text);
            }
        }

        private void CmbBibliotecas_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetFrmRegistro();
            if (cmbBibliotecas.SelectedIndex > 0)
            {
                biblitotecaEnt.Biblioteca = cmbBibliotecas.Text;

                cmbFuncoes.Items.Clear();
                lstFuncoes = new(FuncoesRep.SelecionarFuncoes(biblitotecaEnt));
                lstFuncoes.ForEach(funcoeslst => cmbFuncoes.Items.Add(funcoeslst)) ;
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

                cmbFcnModDatas.Items.Clear();
                lstFcnModDatas = new(FuncoesRep.SelecionarModDatas(biblitotecaEnt));
                lstFcnModDatas.ForEach(fcnModDatalst => cmbFcnModDatas.Items.Add(fcnModDatalst));
                
                cmbModProgramador.Items.Clear();
                lstModProgramadores = new(FuncoesRep.SelecionarModProgramador(biblitotecaEnt));
                lstModProgramadores.ForEach(modProgramadorlst => cmbModProgramador.Items.Add(modProgramadorlst));
                
                List<FuncaoEnt> modsFuncao = new();
                modsFuncao.AddRange(FuncoesRep.SelecionarModsFuncao(biblitotecaEnt).Distinct());
                biblitotecaEnt.FK_ID_FcnModData = modsFuncao.Last();

                cmbFcnModDatas.SelectedIndex = cmbFcnModDatas.Items.Count - 1;
                cmbModProgramador.SelectedIndex = cmbModProgramador.Items.Count-1;

                /*observar o comportamento*//*
                cmbLinguagens.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbBibliotecas.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbFuncoes.DropDownStyle = ComboBoxStyle.DropDownList;
                /*observar o comportamento*/

                cmbFcnModDatas.Enabled = true;
                cmbModProgramador.Enabled = true;
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
                cmbModProgramador.Text = biblitotecaEnt.FK_ID_FcnModData.ModProgramador;
                rtbDescricaoFcn.Text = biblitotecaEnt.FK_ID_FcnModData.DescricaoFcn;
                rtbSnippet.Text = biblitotecaEnt.FK_ID_FcnModData.Snippet;
            }
        }

        private void CmbModProgramadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbModProgramador.SelectedIndex != 0 && !firstScan)
            {
                biblitotecaEnt.FK_ID_FcnModData.ModProgramador = cmbModProgramador.Text;
                biblitotecaEnt.FK_ID_FcnModData.Funcao = cmbFuncoes.Text;
                List<FuncaoEnt> ModsProgramador = new(FuncoesRep.BuscarModProgramador(biblitotecaEnt));
                biblitotecaEnt.FK_ID_FcnModData = ModsProgramador.Last();
                
                cmbFcnModDatas.Items.Clear();
                ModsProgramador.ForEach(modificacoesProgramador => cmbFcnModDatas.Items.Add(modificacoesProgramador.ID_FcnModData));
                
                rtbDescricaoFcn.Text = biblitotecaEnt.FK_ID_FcnModData.DescricaoFcn;
                rtbSnippet.Text = biblitotecaEnt.FK_ID_FcnModData.Snippet;

                cmbFcnModDatas.SelectedIndex = cmbFcnModDatas.Items.Count - 1;
            }

            if(cmbModProgramador.Text.Equals("**Colaboradores**"))
            {
                biblitotecaEnt.FK_ID_FcnModData = new();
                biblitotecaEnt.FK_ID_FcnModData.Funcao = cmbFuncoes.Text;
                resetFrmRegistro();
                cmbFcnModDatas.Items.Clear();
                lstFcnModDatas = new(FuncoesRep.SelecionarModDatas(biblitotecaEnt));
                lstFcnModDatas.ForEach(fcnModDatalst => cmbFcnModDatas.Items.Add(fcnModDatalst));
                cmbFcnModDatas.SelectedIndex = 0;
            }
            firstScan = false;
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
                FuncoesRep.Registrar(inAgrupamentoEnt.FK_ID_FcnModData);
                BibliotecaEnt agrupamentoEnt = new()
                {
                    Biblioteca = inAgrupamentoEnt.Biblioteca,
                    DescricaoLib = inAgrupamentoEnt.DescricaoLib,
                    ID_Linguagem = inAgrupamentoEnt.ID_Linguagem,
                    ID_FcnModData = FuncoesRep.SelecionarTB_Funcoes().Last().ID_FcnModData,
                    FK_ID_Linguagem = null,
                    FK_ID_FcnModData = null
                };
                BibliotecasRep.Registrar(agrupamentoEnt);
            }
            MessageBox.Show(operacao+" Registrada!");
            cmbLinguagens.SelectedIndex = 0;
            if (cmbBibliotecas.Items.Count > 0) cmbBibliotecas.SelectedIndex = 0;
            if (cmbFuncoes.Items.Count > 0) cmbFuncoes.SelectedIndex = 0;
            
            lstLinguagens = new(LinguagensRep.SelecionarLinguagens());
            foreach (var item in lstLinguagens)
            {
                if (!cmbLinguagens.Items.Contains(item))
                {
                    cmbLinguagens.Items.Add(item);
                }
            }
            
            cmbLinguagens.SelectedIndex = 0;
            resetFrmRegistro();
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
                ModProgramador = Propriedades.Configuracoes.Default.Colaborador,
                Snippet = rtbSnippet.Text
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

                cmbBibliotecas.Enabled = true;
                cmbBibliotecas.Text = "Biblioteca";
            }

            if (btnRegMod.Text.Equals("RegNewLib")
                || btnRegMod.Text.Equals("RegNewLang"))
            {
                rtbDescricaoLib.Text = "Descrição da Biblioteca";

                cmbFuncoes.Enabled = true;
                cmbFuncoes.Text = "Função";
            }
            
            if (btnRegMod.Text.Equals("RegNewFcn")
                || btnRegMod.Text.Equals("RegNewLib")
                || btnRegMod.Text.Equals("RegNewLang"))
            {
                rtbDescricaoFcn.Text = "Descrição da Função";
                rtbSnippet.Text = "Snippet da Função";
            }
            rtbDescricaoLang.Enabled = true;
            rtbDescricaoLib.Enabled = true;
            rtbDescricaoFcn.Enabled = true;
        }

        private void resetFrmRegistro()
        {
            if (cmbLinguagens.SelectedIndex == 0)
            {
                rtbDescricaoLang.Text = String.Empty;
                rtbDescricaoLib.Text = String.Empty;
                cmbBibliotecas.Text = String.Empty;
                cmbFuncoes.Text = String.Empty;
                
                cmbBibliotecas.Enabled = false;
                cmbFuncoes.Enabled = false;
                rtbDescricaoLang.Enabled = false;
                rtbDescricaoLib.Enabled = false;
                rtbDescricaoFcn.Enabled = false;
            }            
            
            if (cmbBibliotecas.SelectedIndex == 0)
            {
                cmbFuncoes.Enabled = false;
                cmbFuncoes.Text = String.Empty;
                rtbDescricaoLib.Text = String.Empty;
                rtbDescricaoLib.Enabled = false;
            }

            if (cmbFuncoes.SelectedIndex == 0
                || cmbBibliotecas.SelectedIndex == 0
                || cmbLinguagens.SelectedIndex == 0)
            {
                rtbDescricaoFcn.Enabled = false;
                rtbSnippet.Enabled = false;
                btnRegMod.Text = "RegMod";
                operacao = "Modificação";
                btnRegMod.Enabled = false;
            }
            
            if (cmbFcnModDatas.Items.Count > 0
                && !cmbModProgramador.Text.Equals("**Colaboradores**"))
            {
                cmbFcnModDatas.Items.Clear();
                cmbModProgramador.Items.Clear();
                cmbFcnModDatas.Enabled = false;
                cmbModProgramador.Enabled = false;
            }
            rtbDescricaoFcn.Text = String.Empty;
            rtbSnippet.Text = String.Empty;
            firstScan = true;
        }
    }
}
