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

namespace DesktopCany.UI
{
    public partial class FrmConsulta : Form
    {
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void onClick(object sender, EventArgs e)
        {
            //
        }

        private void FrmConsultaOnLoad(object sender, EventArgs e)
        {
            //BibliotecaEnt inAgrupamentoEnt = ComporRegistro();
            //if (!BibliotecasRep.Registrar(inAgrupamentoEnt))
            //{
            //    //MessageBox.Show("INSERT SQLita");
            //    //DominioRep.Registrar(classFileEnt.FK_ID_Biblioteca.FK_ID_Linguagem);
            //    FuncoesRep.Registrar(inAgrupamentoEnt.FK_ID_FcnModData);
            //    BibliotecaEnt agrupamentoEnt = new()
            //    {
            //        Biblioteca = inAgrupamentoEnt.Biblioteca,
            //        DescricaoLib = inAgrupamentoEnt.DescricaoLib,
            //        ID_Linguagem = inAgrupamentoEnt.ID_Linguagem,
            //        ID_FcnModData = FuncoesRep.Consultar("").Last().ID_FcnModData,
            //        FK_ID_Linguagem = null,
            //        FK_ID_FcnModData = null
            //    };
            //    BibliotecasRep.Registrar(agrupamentoEnt);
            //}

            ////var composiçãoViewSearch = Environment.NewLine + AgrupamentoRep.Consultar().FK_ID_Funcao.ModEstavel.ToString();
            ////rtbViewSearch.Text += composiçãoViewSearch;
            ////txtBusca.Text = BibliotecasRep.Consultar("").Last().ID_Biblioteca.ToString();
            ////LinguagemEnt teste = LinguagensRep.Consultar();
            //cBoxLinguagem.DataSource = LinguagensRep.SelecionarLinguagens();
            ////BibliotecaEnt teste2 = BibliotecasRep.Consultar();
            //cBoxBiblioteca.DataSource = BibliotecasRep.Consultar();
            //FuncaoEnt teste3 = FuncoesRep.Consultar();
            //cBoxFuncao.Text = teste3.Funcao;

        }

        private BibliotecaEnt ComporRegistro()
        {
            LinguagemEnt inDominioEnt = new()
            {
                ID_Linguagem = "C++",
                DescricaoLang = "Linguagem capaz de operar em baixo, médio e alto nível"
                +Environment.NewLine+"Otimizado para trabalhar em baixo e médio nível"
                +Environment.NewLine+""
            };
            FuncaoEnt inFerramentasEnt = new()
            {
                ID_FcnModData = DateTime.Now.ToString(),
                Funcao = "sprintf()",
                DescricaoFcn = "descrição da função",
                ModProgramador = "Programador Responsável",
                Snippet = "Snippet:[sprintf()]"
                + Environment.NewLine + "*Markdown{ Syntax highlighting }"
            };
            BibliotecaEnt inAgrupamentoEnt = new()
            {
                Biblioteca = "stdlib.h",
                DescricaoLib = "descrição da biblioteca",
                FK_ID_Linguagem = inDominioEnt,
                FK_ID_FcnModData = inFerramentasEnt
            };
            return inAgrupamentoEnt;
        }
    }
}
