using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopCany.Repositorio;
using DesktopCany.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
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
            biblitotecaEnt.FK_ID_FcnModData = new FuncaoEnt();

            cBoxLinguagem.Items.Clear();
            lstLinguagens = new(LinguagensRep.SelecionarLinguagens());
            lstLinguagens.ForEach(linguagenslst => cBoxLinguagem.Items.Add(linguagenslst));
            cBoxLinguagem.SelectedIndex = 0;
            cBoxLinguagem.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxBiblioteca.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxFuncao.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxModData.DropDownStyle = ComboBoxStyle.DropDownList;

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
        private void pboxStandBy_MouseEnter(object sender, EventArgs e)
        {
            rtbViewSearch.Visible = true;
            cBoxLinguagem.Visible = true;
            cBoxBiblioteca.Visible = true;
            cBoxFuncao.Visible = true;
            cBoxModData.Visible = true;
            btnStandBy.Visible = true;
            btnDefault.Visible = true;
            btnDefault.BackColor = Color.Green;

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
            btnDefault.Visible = false;

            pboxStandBy.Visible = true;
            pboxStandBy.Image = Propriedades.Recursos.ImgStandBy;

            this.SetDesktopBounds(
                Convert.ToInt16(Configuracoes.Default.LastPosition.Split(";")[0]),
                Convert.ToInt16(Configuracoes.Default.LastPosition.Split(";")[1]),
                150, 84);

        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void btnDefault_Click(object sender, EventArgs e)
        {
            btnDefault.BackColor = Color.Green;
            Configuracoes.Default.LastPosition = $"{this.Location.X};{this.Location.Y}";
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
                btnDefault.BackColor = Color.Green;
            }
            else
            {
                btnDefault.BackColor = Color.Silver;
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
            rtb.SelectionFont = new Font("", 10, FontStyle.Bold);
            rtb.AppendText(text);
            rtb.SelectionColor = rtb.ForeColor;
        }

        private void setupViewSearch()
        {
            rtbViewSearch.Clear();

            RtbAppendFormat(rtbViewSearch, "[ Linguagem ]>>>", Color.Blue);
            RtbAppendFormat(rtbViewSearch, $"[ {cBoxLinguagem.Text} ]", Color.Yellow);
            rtbViewSearch.AppendText(Environment.NewLine);
            rtbViewSearch.AppendText(biblitotecaEnt.FK_ID_Linguagem?.DescricaoLang);
            rtbViewSearch.AppendText(Environment.NewLine);
            rtbViewSearch.AppendText(Environment.NewLine);

            RtbAppendFormat(rtbViewSearch, "[ Biblioteca ]>>>", Color.Blue);
            RtbAppendFormat(rtbViewSearch, $"[ {cBoxBiblioteca.Text} ]", Color.Yellow);
            rtbViewSearch.AppendText(Environment.NewLine);
            rtbViewSearch.AppendText(biblitotecaEnt.DescricaoLib);
            rtbViewSearch.AppendText(Environment.NewLine);
            rtbViewSearch.AppendText(Environment.NewLine);

            RtbAppendFormat(rtbViewSearch, "[ Função ]>>>", Color.Blue);
            RtbAppendFormat(rtbViewSearch, $"[ {cBoxFuncao.Text} ]", Color.Yellow);
            rtbViewSearch.AppendText(Environment.NewLine);
            rtbViewSearch.AppendText(biblitotecaEnt.FK_ID_FcnModData?.Snippet);
        }
    }
}
