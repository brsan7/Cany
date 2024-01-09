using DesktopCany.Repositorio;
using DesktopCany.Entidades;
using DesktopCany.Propriedades;

namespace DesktopCany.UI
{
    public partial class FrmConsulta : Form
    {
        private BibliotecaEnt biblitotecaEnt = new();
        private List<string> lstLinguagens = new();
        private List<string> lstBibliotecas = new();
        private List<string> lstFuncoes = new();
        private List<string> lstFcnModDatas = new();
        public FrmConsulta()
        {
            InitializeComponent();
        }
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void FrmConsultaOnLoad(object sender, EventArgs e)
        {

            this.BackColor = Configuracoes.Default.BackColor;
            this.ForeColor = Configuracoes.Default.ForeColor;
            rtbViewSearch.BackColor = Configuracoes.Default.BackColor;
            rtbViewSearch.ForeColor = Configuracoes.Default.ForeColor;
            btnDockOrientation.ForeColor = Color.Black;
            btnStandBy.ForeColor = Color.Black;

            biblitotecaEnt.FK_ID_FcnModData = new FuncaoEnt();

            cBoxLinguagem.Items.Clear();
            lstLinguagens = new(LinguagensRep.SelecionarLinguagens());
            lstLinguagens.ForEach(linguagenslst => cBoxLinguagem.Items.Add(linguagenslst));
            cBoxLinguagem.SelectedIndex = 0;

            this.SetDesktopBounds(
                Convert.ToInt16(Configuracoes.Default.LastPosition.Split(";")[0]),
                Convert.ToInt16(Configuracoes.Default.LastPosition.Split(";")[1]),
                350, 600);

            btnDockOrientation.Text = Configuracoes.Default.DockOrientation;
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void cBoxLinguagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxBiblioteca.Items.Clear();
            cBoxFuncao.Items.Clear();
            cBoxModData.Items.Clear();

            if (cBoxLinguagem.SelectedIndex > 0)
            {
                biblitotecaEnt = new();
                biblitotecaEnt.FK_ID_FcnModData = new();
                biblitotecaEnt.FK_ID_Linguagem = new();
                biblitotecaEnt.ID_Linguagem = cBoxLinguagem.Text;
                biblitotecaEnt.FK_ID_Linguagem.DescricaoLang =
                    LinguagensRep.BuscarDescricao(cBoxLinguagem.Text);

                cBoxBiblioteca.Text = String.Empty;
                cBoxFuncao.Text = String.Empty;
                cBoxBiblioteca.Items.Clear();
                cBoxFuncao.Items.Clear();
                cBoxModData.Items.Clear();
                rtbViewSearch.Clear();
                lstBibliotecas = new(BibliotecasRep.SelecionarBibliotecas(cBoxLinguagem.Text));
                lstBibliotecas.ForEach(biblitotecaslst => cBoxBiblioteca.Items.Add(biblitotecaslst));
                cBoxBiblioteca.SelectedIndex = 0;

                setupViewSearch();
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void cBoxBiblioteca_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxFuncao.Items.Clear();
            cBoxModData.Items.Clear();

            if (cBoxBiblioteca.SelectedIndex > 0)
            {
                biblitotecaEnt.FK_ID_FcnModData = new();
                biblitotecaEnt.Biblioteca = cBoxBiblioteca.Text;
                biblitotecaEnt.DescricaoLib =
                    BibliotecasRep.BuscarDescricao(cBoxLinguagem.Text, cBoxBiblioteca.Text);

                cBoxFuncao.Text = String.Empty;
                cBoxFuncao.Items.Clear();
                lstFuncoes = new(FuncoesRep.SelecionarFuncoes(biblitotecaEnt));
                lstFuncoes.ForEach(biblitotecaslst => cBoxFuncao.Items.Add(biblitotecaslst));
                cBoxFuncao.SelectedIndex = 0;

                setupViewSearch();
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void cBoxFuncao_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxModData.Items.Clear();

            if (cBoxFuncao.SelectedIndex > 0)
            {
                biblitotecaEnt.FK_ID_FcnModData = new();
                biblitotecaEnt.FK_ID_FcnModData.Funcao = cBoxFuncao.Text;

                cBoxModData.Items.Clear();
                lstFcnModDatas = new(FuncoesRep.SelecionarModDatas(biblitotecaEnt));
                lstFcnModDatas.ForEach(fcnModDatalst => cBoxModData.Items.Add(fcnModDatalst));
                cBoxModData.SelectedIndex = cBoxModData.Items.Count - 1;

                List<FuncaoEnt> modsFuncao = new();
                modsFuncao.AddRange(FuncoesRep.SelecionarModsFuncao(biblitotecaEnt).Distinct());
                biblitotecaEnt.FK_ID_FcnModData = modsFuncao.Last();

                setupViewSearch();
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void cBoxModData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxModData.SelectedIndex != 0)
            {
                biblitotecaEnt.FK_ID_FcnModData = new();
                biblitotecaEnt.FK_ID_FcnModData.ID_FcnModData = cBoxModData.Text;
                biblitotecaEnt.FK_ID_FcnModData = FuncoesRep.BuscarMod(biblitotecaEnt);
                setupViewSearch();
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void cBoxLinguagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            cBoxLinguagem.Items.Clear();
            cBoxLinguagem.Items.Add("**Linguagens**");
            cBoxLinguagem.SelectionStart = cBoxLinguagem.Text.Length;
            foreach (var item in lstLinguagens)
            {
                if (item.ToUpper().Contains(cBoxLinguagem.Text.ToUpper()))
                {
                    if (!item.Equals("**Linguagens**"))
                    {
                        cBoxLinguagem.Items.Add(item);
                    }
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
        private void cBoxBiblioteca_KeyPress(object sender, KeyPressEventArgs e)
        {
            cBoxBiblioteca.Items.Clear();
            cBoxBiblioteca.Items.Add("**Bibliotecas**");
            cBoxBiblioteca.SelectionStart = cBoxBiblioteca.Text.Length;
            foreach (var item in lstBibliotecas)
            {
                if (item.ToUpper().Contains(cBoxBiblioteca.Text.ToUpper()))
                {
                    if (!item.Equals("**Bibliotecas**"))
                    {
                        cBoxBiblioteca.Items.Add(item);
                    }
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
        private void cBoxFuncao_KeyPress(object sender, KeyPressEventArgs e)
        {
            cBoxFuncao.Items.Clear();
            cBoxFuncao.Items.Add("**Funções**");
            cBoxFuncao.SelectionStart = cBoxFuncao.Text.Length;
            foreach (var item in lstFuncoes)
            {
                if (item.ToUpper().Contains(cBoxFuncao.Text.ToUpper()))
                {
                    if (!item.Equals("**Funções**"))
                    {
                        cBoxFuncao.Items.Add(item);
                    }
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
        private void cBoxModData_KeyPress(object sender, KeyPressEventArgs e)
        {
            cBoxModData.Items.Clear();
            cBoxModData.Items.Add("**Data_Mod_Id**");
            cBoxModData.SelectionStart = cBoxModData.Text.Length;
            foreach (var item in lstFcnModDatas)
            {
                if (item.ToUpper().Contains(cBoxModData.Text.ToUpper()))
                {
                    if (!item.Equals("**Data_Mod_Id**"))
                    {
                        cBoxModData.Items.Add(item);
                    }
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
        private void pboxStandBy_MouseEnter(object sender, EventArgs e)
        {
            rtbViewSearch.Visible = true;
            cBoxLinguagem.Visible = true;
            cBoxBiblioteca.Visible = true;
            cBoxFuncao.Visible = true;
            cBoxModData.Visible = true;
            btnStandBy.Visible = true;
            btnDockOrientation.Visible = true;
            btnDockOrientation.BackColor = Color.Green;

            pboxStandBy.Visible = false;

            this.SetDesktopBounds(
                Convert.ToInt16(Configuracoes.Default.LastPosition.Split(";")[0]),
                Convert.ToInt16(Configuracoes.Default.LastPosition.Split(";")[1]),
                350, 600);
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void btnStandBy_Click(object sender, EventArgs e)
        {
            rtbViewSearch.Visible = false;
            cBoxLinguagem.Visible = false;
            cBoxBiblioteca.Visible = false;
            cBoxFuncao.Visible = false;
            cBoxModData.Visible = false;
            btnStandBy.Visible = false;
            btnDockOrientation.Visible = false;

            pboxStandBy.Visible = true;
            pboxStandBy.Image = Propriedades.Recursos.ImgStandBy;

            switch (Configuracoes.Default.DockOrientation)
            {
                case "DockUp":
                    this.SetDesktopBounds(
                        Convert.ToInt16(Configuracoes.Default.LastPosition.Split(";")[0]),
                        Convert.ToInt16(Configuracoes.Default.LastPosition.Split(";")[1]),
                        150, 84);
                    break;
                case "DockDown":
                    this.SetDesktopBounds(
                        Convert.ToInt16(Configuracoes.Default.LastPosition.Split(";")[0]) + 182,
                        Convert.ToInt16(Configuracoes.Default.LastPosition.Split(";")[1]) + 468,
                        150, 84);
                    break;
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void btnDockOrientation_Click(object sender, EventArgs e)
        {
            if (Configuracoes.Default.DockOrientation.Equals("DockUp"))
            {
                Configuracoes.Default.DockOrientation = "DockDown";
                btnDockOrientation.Text = "DockDown";
            }
            else
            {
                Configuracoes.Default.DockOrientation = "DockUp";
                btnDockOrientation.Text = "DockUp";
            }
            btnDockOrientation.BackColor = Color.Green;
            Configuracoes.Default.LastPosition = $"{this.Location.X};{this.Location.Y}";
            Configuracoes.Default.Save();
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void FrmConsulta_LocationChanged(object sender, EventArgs e)
        {
            if (this.Location.X.ToString().Equals(Configuracoes.Default.LastPosition.Split(";")[0])
                && this.Location.Y.ToString().Equals(Configuracoes.Default.LastPosition.Split(";")[1]))
            {
                btnDockOrientation.BackColor = Color.Green;
            }
            else
            {
                btnDockOrientation.BackColor = Color.Silver;
            }
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /********************************[FUNÇÕES_GERAIS]***********************************/
        /***********************************************************************************/
        private void RtbAppendFormat(RichTextBox rtb, string text, Color color)
        {
            rtb.SelectionStart = rtb.TextLength;
            rtb.SelectionLength = 0;
            rtb.SelectionColor = color;
            rtb.SelectionFont = new Font("", 9, FontStyle.Bold);
            rtb.AppendText(text);
            rtb.SelectionColor = rtb.ForeColor;
        }

        private void setupViewSearch()
        {
            rtbViewSearch.Clear();

            RtbAppendFormat(rtbViewSearch, "[ Linguagem ]>>>", Color.Blue);
            RtbAppendFormat(rtbViewSearch, $"[ {biblitotecaEnt.ID_Linguagem} ]", Color.Yellow);
            rtbViewSearch.AppendText(Environment.NewLine);
            rtbViewSearch.AppendText(biblitotecaEnt.FK_ID_Linguagem?.DescricaoLang);
            rtbViewSearch.AppendText(Environment.NewLine);
            rtbViewSearch.AppendText(Environment.NewLine);

            RtbAppendFormat(rtbViewSearch, "[ Biblioteca ]>>>", Color.Blue);
            RtbAppendFormat(rtbViewSearch, $"[ {biblitotecaEnt.Biblioteca} ]", Color.Yellow);
            rtbViewSearch.AppendText(Environment.NewLine);
            rtbViewSearch.AppendText(biblitotecaEnt.DescricaoLib);
            rtbViewSearch.AppendText(Environment.NewLine);
            rtbViewSearch.AppendText(Environment.NewLine);

            RtbAppendFormat(rtbViewSearch, "[ Função ]>>>", Color.Blue);
            RtbAppendFormat(rtbViewSearch, $"[ {biblitotecaEnt.FK_ID_FcnModData?.Funcao} ]", Color.Yellow);
            rtbViewSearch.AppendText(Environment.NewLine);
            rtbViewSearch.AppendText(biblitotecaEnt.FK_ID_FcnModData?.Snippet);
        }
    }
}
