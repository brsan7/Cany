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
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        Repositorio.BackupRep bkpDAL = new Repositorio.BackupRep();

        private void btnGerar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = 
            saveFileDialog1.ShowDialog();

            if (resposta != DialogResult.Cancel)
            {
                //bkpDAL.GerarBackup(saveFileDialog1.FileName);
                MessageBox.Show("Backup Concluído");
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            DialogResult resposta =
            openFileDialog1.ShowDialog();

            if (resposta != DialogResult.Cancel)
            {
                //bkpDAL.RestaurarBackup(openFileDialog1.FileName);
                MessageBox.Show("Backup Restaurado");
            }
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {

        }
    }
}
