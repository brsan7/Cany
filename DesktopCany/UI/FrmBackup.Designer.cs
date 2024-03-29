﻿using DesktopCany.Propriedades;

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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            progressBar1 = new ProgressBar();
            labelFeedBack = new Label();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // btnExportarTxt
            // 
            btnExportarTxt.ForeColor = Color.Black;
            btnExportarTxt.Location = new Point(85, 77);
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
            btnImportarTxt.ForeColor = Color.Black;
            btnImportarTxt.Location = new Point(85, 150);
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
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Top;
            progressBar1.Location = new Point(0, 0);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(277, 23);
            progressBar1.TabIndex = 2;
            progressBar1.Visible = false;
            // 
            // labelFeedBack
            // 
            labelFeedBack.AutoSize = true;
            labelFeedBack.Location = new Point(10, 26);
            labelFeedBack.Name = "labelFeedBack";
            labelFeedBack.Size = new Size(83, 15);
            labelFeedBack.TabIndex = 3;
            labelFeedBack.Text = "FeedBack User";
            labelFeedBack.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 177);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "BackUp/Restore";
            // 
            // FrmBackup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 277);
            Controls.Add(labelFeedBack);
            Controls.Add(progressBar1);
            Controls.Add(btnImportarTxt);
            Controls.Add(btnExportarTxt);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmBackup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Backup";
            Load += frmBackup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExportarTxt;
        private System.Windows.Forms.Button btnImportarTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ProgressBar progressBar1;
        private Label labelFeedBack;
        private GroupBox groupBox1;
    }
}