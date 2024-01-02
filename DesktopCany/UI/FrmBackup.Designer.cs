namespace DesktopCany.UI
{
    partial class FrmBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExportarTxt = new Button();
            btnImportarTxt = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // btnExportarTxt
            // 
            btnExportarTxt.Location = new Point(128, 59);
            btnExportarTxt.Margin = new Padding(4, 3, 4, 3);
            btnExportarTxt.Name = "btnExportarTxt";
            btnExportarTxt.Size = new Size(107, 55);
            btnExportarTxt.TabIndex = 0;
            btnExportarTxt.Text = "Exportar Txt";
            btnExportarTxt.UseVisualStyleBackColor = true;
            btnExportarTxt.Click += btnExportarTxt_Click;
            // 
            // btnImportarTxt
            // 
            btnImportarTxt.Location = new Point(128, 140);
            btnImportarTxt.Margin = new Padding(4, 3, 4, 3);
            btnImportarTxt.Name = "btnImportarTxt";
            btnImportarTxt.Size = new Size(107, 55);
            btnImportarTxt.TabIndex = 1;
            btnImportarTxt.Text = "Importar Txt";
            btnImportarTxt.UseVisualStyleBackColor = true;
            btnImportarTxt.Click += btnImportarTxt_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "bak";
            openFileDialog1.Filter = "Backup|*.bak";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "bak";
            saveFileDialog1.Filter = "Backup|*.bak";
            // 
            // FrmBackup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 285);
            Controls.Add(btnImportarTxt);
            Controls.Add(btnExportarTxt);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmBackup";
            Text = "Backup";
            Load += frmBackup_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnExportarTxt;
        private System.Windows.Forms.Button btnImportarTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}