using DesktopCany.Entidades;
using DesktopCany.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DesktopCany.UI
{
    public partial class FrmBackup : Form
    {
        private BibliotecaEnt biblitotecaEnt = new();
        private LinguagemEnt linguagemEnt = new();
        private FuncaoEnt funcaoEnt = new();
        private string txt = String.Empty;
        public FrmBackup()
        {
            InitializeComponent();
        }

        Repositorio.BackupRep bkpDAL = new Repositorio.BackupRep();

        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private void frmBackup_Load(object sender, EventArgs e)
        {
            labelFeedBack.Text = "";
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private async void btnExportarTxt_Click(object sender, EventArgs e)
        {
            Stream exStream;
            StreamWriter streamWrite;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*txt)|*txt";
            saveFileDialog.Title = "Exportar Txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((exStream = saveFileDialog.OpenFile()) != null)
                {
                    using (streamWrite = new StreamWriter(exStream, Encoding.Latin1))
                    {
                        char[] escrita = ComporTxt().ToCharArray();
                        await streamWrite.WriteAsync(escrita, 0, escrita.Length);
                        //labelFeedBack.Text = "Importando.";
                        }
                    exStream.Close();
                }
                MessageBox.Show("Exportação Concluída!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            }
        }
        private string ComporTxt()
        {
            List<BibliotecaEnt> todosRegistros = BackupRep.SelecionarTB_Bibliotecas();
            int indexGeral = 1;
            string composicaoTxt = ">|[Inicio_Arquivo]|<";
            string finalRegistro = ">|[Final_Registro]|<";

            foreach (var item in todosRegistros)
            {
                BibliotecaEnt lib = item;
                FuncaoEnt funcao = new();
                funcao.ID_FcnModData = item.ID_FcnModData;
                lib.FK_ID_FcnModData = funcao;
                funcao = FuncoesRep.BuscarMod(item);
                string descricaoLinguagem = LinguagensRep.BuscarDescricao(item.ID_Linguagem.ToString());
                composicaoTxt =
/*Composição indentada*/
$@"{composicaoTxt}
==>[ID_Linguagem]|>:
{item.ID_Linguagem}
==>[DescricaoLang]|>:
{descricaoLinguagem}
==>[ID_Biblioteca]|>:
{item.ID_Biblioteca}
==>[Biblioteca]|>:
{item.Biblioteca}
==>[DescricaoLib]|>:
{item.DescricaoLib}
==>[ID_FcnModData]|>:
{item.ID_FcnModData}
==>[DescricaoFcn]|>:
{funcao.DescricaoFcn}
==>[Funcao]|>:
{funcao.Funcao}
==>[ModProgramador]|>:
{funcao.ModProgramador}
==>[ModEstavel]|>:
{funcao.ModEstavel}
==>[Snippet]|>:
{funcao.Snippet}
{finalRegistro}";
                /*Composição indentada*/
                indexGeral++;
                if (indexGeral == todosRegistros.Count)
                {
                    finalRegistro = String.Empty;
                }
            };//foreach (var item in todosRegistros)

            return composicaoTxt;
        }//private string ComporTxt()

        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
        /////////////////////////////////////////////////////////////////////////////////////
        /***********************************************************************************/
        /**********************************[INICIO_EVENTO]**********************************/
        /***********************************************************************************/
        private async void btnImportarTxt_Click(object sender, EventArgs e)
        {
            Stream inStream;
            StreamReader leitruraStream;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*txt)|*txt";
            openFileDialog.Title = "Importar Txt";
            labelFeedBack.Text = "Carregando o arquivo.";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((inStream = openFileDialog.OpenFile()) != null)
                {
                    biblitotecaEnt = new();
                    linguagemEnt = new();
                    funcaoEnt = new();
                    txt = String.Empty;
                    
                    using (leitruraStream = new StreamReader(inStream, Encoding.Latin1))
                    {
                        char[] leitura = new char[leitruraStream.BaseStream.Length];
                        await leitruraStream.ReadAsync(leitura,0,(int)leitruraStream.BaseStream.Length);
                        
                        foreach (var c in leitura)
                        {
                            txt = $"{txt}{c}";
                        }
                        labelFeedBack.Text = "Importando.";
                    }
                    inStream.Close();
                    backgroundWorker1.WorkerReportsProgress = true;
                    backgroundWorker1.RunWorkerAsync(txt);
                }
            }
            else
            {
                labelFeedBack.Text = "";
            }

        }//private void btnImportarTxt_Click(object sender, EventArgs e)

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker? worker = sender as BackgroundWorker;
            ImportarTXT($"{e.Argument}", worker, e);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Importação Concluída!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            progressBar1.Value = 0;
            this.labelFeedBack.Text = "";
        }


        private void ImportarTXT(string txt, BackgroundWorker? worker, DoWorkEventArgs e)
        {
            int percentItem = 100 / txt.Split(">|[Final_Registro]|<").Length;
            int percentComplete = 0;
            int index = 0;

            foreach (var registro in txt.Split(">|[Final_Registro]|<"))
            {
                percentComplete = percentItem * index;
                worker?.ReportProgress(percentComplete);
                index++;
                
                foreach (var campos in registro.Split("==>["))
                {
                    switch (campos.Split("]|>:")[0])
                    {
                        case "ID_Linguagem":
                            linguagemEnt.ID_Linguagem = campos.Split($"]|>:{Environment.NewLine}")[1];
                            break;
                        case "DescricaoLang":
                            linguagemEnt.DescricaoLang = campos.Split($"]|>:{Environment.NewLine}")[1];
                            break;
                        case "ID_Biblioteca":
                            /*AUTOMATICO*/
                            break;
                        case "Biblioteca":
                            biblitotecaEnt.Biblioteca = campos.Split($"]|>:{Environment.NewLine}")[1];
                            break;
                        case "DescricaoLib":
                            biblitotecaEnt.DescricaoLib = campos.Split($"]|>:{Environment.NewLine}")[1];
                            break;
                        case "ID_FcnModData":
                            funcaoEnt.ID_FcnModData = campos.Split($"]|>:{Environment.NewLine}")[1];
                            break;
                        case "DescricaoFcn":
                            funcaoEnt.DescricaoFcn = campos.Split($"]|>:{Environment.NewLine}")[1];
                            break;
                        case "Funcao":
                            funcaoEnt.Funcao = campos.Split($"]|>:{Environment.NewLine}")[1];
                            break;
                        case "ModProgramador":
                            funcaoEnt.ModProgramador = campos.Split($"]|>:{Environment.NewLine}")[1];
                            break;
                        case "ModEstavel":
                            funcaoEnt.ModEstavel = Convert.ToBoolean(campos.Split($"]|>:{Environment.NewLine}")[1]);
                            break;
                        case "Snippet":
                            funcaoEnt.Snippet = campos.Split($"]|>:{Environment.NewLine}")[1];
                            break;

                    }//switch (campos.Split("]|>:")[0])

                }//foreach (var campos in registro.Split("==>["))

                biblitotecaEnt.FK_ID_Linguagem = linguagemEnt;
                biblitotecaEnt.FK_ID_FcnModData = funcaoEnt;
                if (!BibliotecasRep.Registrar(biblitotecaEnt))
                {
                    if (LinguagensRep.Buscar_Linguagem(linguagemEnt.ID_Linguagem).Count <= 0)
                    {
                        LinguagensRep.Registrar(linguagemEnt);
                    }
                    if (FuncoesRep.Buscar_Funcao(funcaoEnt.ID_FcnModData).Count <= 0)
                    {
                        FuncoesRep.Registrar(funcaoEnt);
                    }

                    BibliotecaEnt agrupamentoEnt = new()
                    {
                        Biblioteca = biblitotecaEnt.Biblioteca,
                        DescricaoLib = biblitotecaEnt.DescricaoLib,
                        ID_Linguagem = linguagemEnt.ID_Linguagem,
                        ID_FcnModData = funcaoEnt.ID_FcnModData,
                        FK_ID_Linguagem = null,
                        FK_ID_FcnModData = null
                    };
                    if (BibliotecasRep.Buscar_BibliotecasPorFuncao(biblitotecaEnt).Count <= 0)
                    {
                        BibliotecasRep.Registrar(agrupamentoEnt);
                    }
                }

            }//foreach (var registro in txt.Split(">|[Final_Registro]|<"))
            worker?.ReportProgress(100);
        }
        /***********************************************************************************/
        /**********************************[FIM_EVENTO]*************************************/
        /***********************************************************************************/
    }
}
