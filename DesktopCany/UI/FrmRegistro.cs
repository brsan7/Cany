using System.Net.NetworkInformation;
using DesktopCany.Entidades;
using DesktopCany.Propriedades;
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
        public string operacao = "Modificação";
        public List<string> editar = new();

        public FrmRegistro()
        {
            InitializeComponent();
        }
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void FrmRegistroOnLoad(object sender, EventArgs e)
        {
            this.BackColor = Configuracoes.Default.BackColor;
            this.ForeColor = Configuracoes.Default.ForeColor;
            rtbDescricaoLang.ForeColor = Configuracoes.Default.ForeColor;
            rtbDescricaoLang.BackColor = Configuracoes.Default.BackColor;
            rtbDescricaoLib.ForeColor = Configuracoes.Default.ForeColor;
            rtbDescricaoLib.BackColor = Configuracoes.Default.BackColor;
            rtbDescricaoFcn.ForeColor = Configuracoes.Default.ForeColor;
            rtbDescricaoFcn.BackColor = Configuracoes.Default.BackColor;
            rtbSnippet.ForeColor = Configuracoes.Default.ForeColor;
            rtbSnippet.BackColor = Configuracoes.Default.BackColor;
            chkBoxModEstavel.ForeColor = Configuracoes.Default.BackColor;
            chkBoxModEstavel.BackColor = Configuracoes.Default.ForeColor;

            biblitotecaEnt.FK_ID_FcnModData = new FuncaoEnt();

            cmbLinguagens.Items.Clear();
            lstLinguagens = new(LinguagensRep.SelecionarLinguagens());
            lstLinguagens.ForEach(linguagenslst => cmbLinguagens.Items.Add(linguagenslst));
            cmbLinguagens.SelectedIndex = 0;

            rtbDescricaoLib.ReadOnly = true;
            rtbDescricaoFcn.ReadOnly = true;
            rtbSnippet.ReadOnly = true;

            if (editar.Count == 4)
            {
                cmbLinguagens.SelectedIndex = cmbLinguagens.FindString(editar[0].ToString());
                rtbDescricaoLang.ReadOnly = true;
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void CmbLinguagens_TextChanged(object sender, EventArgs e)
        {
            if (cmbLinguagens.SelectedIndex == -1
                && !cmbLinguagens.Text.Equals("Linguagens")
                && btnRegMod.Text.Equals("RegMod"))
            {
                btnRegMod.Text = "RegNewLang";
                operacao = "Linguagem";
                btnRegMod.Enabled = true;
                rtbDescricaoLang.ReadOnly = false;
                setup_RegNew();
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
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
                rtbDescricaoLib.ReadOnly = false;
                setup_RegNew();
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
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
                rtbDescricaoFcn.ReadOnly = false;
                setup_RegNew();
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
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

                rtbDescricaoLang.ReadOnly = false;

                rtbDescricaoLang.Text = LinguagensRep.BuscarDescricao(cmbLinguagens.Text);

                if (editar.Count == 4)
                {
                    cmbBibliotecas.SelectedIndex = cmbBibliotecas.FindString(editar[1].ToString());
                    cmbBibliotecas.Enabled = false;
                }
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
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

                rtbDescricaoLib.ReadOnly = false;
                rtbDescricaoLib.Text = BibliotecasRep.BuscarDescricao(cmbLinguagens.Text, cmbBibliotecas.Text);

                if (editar.Count == 4)
                {
                    cmbFuncoes.SelectedIndex = cmbFuncoes.FindString(editar[2].ToString());
                    cmbFuncoes.Enabled = false;
                }
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
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

                if (editar.Count == 4)
                {
                    cmbFcnModDatas.SelectedIndex = cmbFcnModDatas.FindString(editar[3].ToString());
                    cmbFcnModDatas.Enabled = false;
                    cmbModProgramador.Enabled = false;
                    if (biblitotecaEnt.FK_ID_FcnModData.ModEstavel == false)
                    {
                        chkBoxModEstavel.Enabled = true;
                    }
                    else
                    {
                        editar.Add("HOMOLOGADO");
                    }
                }
                else
                {
                    cmbFcnModDatas.Enabled = true;
                    cmbModProgramador.Enabled = true;
                    cmbFcnModDatas.SelectedIndex = cmbFcnModDatas.Items.Count - 1;
                    cmbModProgramador.SelectedIndex = cmbModProgramador.Items.Count - 1;
                }


                rtbDescricaoFcn.ReadOnly = false;
                rtbSnippet.ReadOnly = false;
                rtbDescricaoFcn.Text = biblitotecaEnt.FK_ID_FcnModData.DescricaoFcn;
                chkBoxModEstavel.Checked = biblitotecaEnt.FK_ID_FcnModData.ModEstavel;
                rtbSnippet.Text = biblitotecaEnt.FK_ID_FcnModData.Snippet;
                this.Text = "lang:" + cmbLinguagens.Text + "_lib:" + cmbBibliotecas.Text + "_fcn:" + cmbFuncoes.Text;

                btnRegMod.Enabled = true;
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void CmbFcnModDatas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFcnModDatas.SelectedIndex != 0)
            {
                biblitotecaEnt.FK_ID_FcnModData.ID_FcnModData = cmbFcnModDatas.Text;
                biblitotecaEnt.FK_ID_FcnModData = FuncoesRep.BuscarMod(biblitotecaEnt);
                cmbModProgramador.Text = biblitotecaEnt.FK_ID_FcnModData.ModProgramador;
                rtbDescricaoFcn.Text = biblitotecaEnt.FK_ID_FcnModData.DescricaoFcn;
                chkBoxModEstavel.Checked = biblitotecaEnt.FK_ID_FcnModData.ModEstavel;
                rtbSnippet.Text = biblitotecaEnt.FK_ID_FcnModData.Snippet;
                this.Text = "lang:" + cmbLinguagens.Text + "_lib:" + cmbBibliotecas.Text + "_fcn:" + cmbFuncoes.Text;
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
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
                this.Text = "lang:" + cmbLinguagens.Text + "_lib:" + cmbBibliotecas.Text + "_fcn:" + cmbFuncoes.Text;

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
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void ChkBoxModEstavel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkBoxModEstavel.Enabled && chkBoxModEstavel.Checked)
            {
                DialogResult resposta = MessageBox.Show("Deseja realmente Homologar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    FuncoesRep.Homologar(ComporHomologacao());
                    MessageBox.Show("Homologado!");
                    this.Close();
                }
            }
        }
        private FuncaoEnt ComporHomologacao()
        {
            FuncaoEnt funcao = new()
            {

                ID_FcnModData = cmbFcnModDatas.Text,
                Funcao = cmbFuncoes.Text,
                DescricaoFcn = rtbDescricaoFcn.Text,
                ModProgramador = cmbModProgramador.Text,
                ModEstavel = chkBoxModEstavel.Checked,
                Snippet = rtbSnippet.Text
            };
            return funcao;
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
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
            MessageBox.Show(operacao+" Registrada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            if(editar.Count == 4)
            {
                this.Close();
            }
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
        private String ComporIdMod()
        {
            string fmtID_FcnModData = DateTime.Now.ToString();
            string milissegundos = $@"{DateTime.Now.Millisecond}";
            switch (milissegundos.Length)
            {
                case (1):
                    milissegundos = $@"00{milissegundos}";
                    break;
                case (2):
                    milissegundos = $@"0{milissegundos}";
                    break;
            }
            fmtID_FcnModData = $@"{fmtID_FcnModData}_{milissegundos}";
            fmtID_FcnModData = $@"{fmtID_FcnModData}_{Propriedades.Configuracoes.Default.Colaborador}";
            fmtID_FcnModData = $@"{fmtID_FcnModData}".Replace(' ', '_');
            var mcAddr = NetworkInterface.GetAllNetworkInterfaces()
                .FirstOrDefault
                (
                    nic => nic.OperationalStatus == OperationalStatus.Up
                    && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback
                )?.GetPhysicalAddress();
            fmtID_FcnModData = $@"{fmtID_FcnModData}_{mcAddr}";
            return fmtID_FcnModData;
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

                ID_FcnModData = ComporIdMod(),
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
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /******************************[INICIO_FUNÇOES_GERAIS]******************************/
        /***********************************************************************************/

        private void setup_RegNew()
        {
            if (btnRegMod.Enabled == true)
            {
                cmbBibliotecas.Enabled = true;
                cmbFuncoes.Enabled = true;

                rtbDescricaoLang.ReadOnly = false;
                rtbDescricaoLib.ReadOnly = false;
                rtbDescricaoFcn.ReadOnly = false;
                rtbSnippet.ReadOnly = false;
            }
            switch (btnRegMod.Text)
            {
                case "RegNewLang":
                    rtbDescricaoLang.Text = "Descrição da Linguagem";
                    cmbBibliotecas.Text = "Biblioteca";
                    rtbDescricaoLib.Text = "Descrição da Biblioteca";
                    cmbFuncoes.Text = "Função";
                    rtbDescricaoFcn.Text = "Descrição da Função";
                    rtbSnippet.Text = "Snippet da Função";
                    break;
                case "RegNewLib":
                    rtbDescricaoLib.Text = "Descrição da Biblioteca";
                    cmbFuncoes.Text = "Função";
                    rtbDescricaoFcn.Text = "Descrição da Função";
                    rtbSnippet.Text = "Snippet da Função";
                    break;
                case "RegNewFcn":
                    rtbDescricaoFcn.Text = "Descrição da Função";
                    rtbSnippet.Text = "Snippet da Função";
                    break;
            }
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
                rtbDescricaoLang.ReadOnly = true;
                rtbDescricaoLib.ReadOnly = true;
                rtbDescricaoFcn.ReadOnly = true;
                rtbSnippet.ReadOnly = true;
            }

            if (cmbBibliotecas.SelectedIndex == 0)
            {
                cmbFuncoes.Enabled = false;
                cmbFuncoes.Text = String.Empty;
                rtbDescricaoLib.Text = String.Empty;
                rtbDescricaoLib.ReadOnly = true;
            }

            if (cmbFuncoes.SelectedIndex == 0
                || cmbBibliotecas.SelectedIndex == 0
                || cmbLinguagens.SelectedIndex == 0)
            {
                rtbDescricaoFcn.ReadOnly = true;
                rtbSnippet.ReadOnly = true;
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
            this.Text = "Home";
        }
        /***********************************************************************************/
        /********************************[FIM_FUNÇOES_GERAIS]*******************************/
        /***********************************************************************************/
    }
}
