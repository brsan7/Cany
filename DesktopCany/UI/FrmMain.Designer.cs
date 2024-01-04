namespace DesktopCany.UI
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            consultaModificacaoToolStripMenuItem = new ToolStripMenuItem();
            registroToolStripMenuItem = new ToolStripMenuItem();
            janelasAbertasToolStripMenuItem = new ToolStripMenuItem();
            configuraçõesToolStripMenuItem = new ToolStripMenuItem();
            backupToolStripMenuItem = new ToolStripMenuItem();
            gerenciamentoToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblUsuario = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultaModificacaoToolStripMenuItem, registroToolStripMenuItem, janelasAbertasToolStripMenuItem, configuraçõesToolStripMenuItem, backupToolStripMenuItem, gerenciamentoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = janelasAbertasToolStripMenuItem;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(881, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // consultaModificacaoToolStripMenuItem
            // 
            consultaModificacaoToolStripMenuItem.Name = "consultaModificacaoToolStripMenuItem";
            consultaModificacaoToolStripMenuItem.Size = new Size(66, 20);
            consultaModificacaoToolStripMenuItem.Text = "Consulta";
            consultaModificacaoToolStripMenuItem.Click += ConsultaModificacaoToolStripMenuItem_Click;
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(111, 20);
            registroToolStripMenuItem.Text = "Desenvolvimento";
            registroToolStripMenuItem.Click += RegistroToolStripMenuItem_Click;
            // 
            // janelasAbertasToolStripMenuItem
            // 
            janelasAbertasToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            janelasAbertasToolStripMenuItem.Name = "janelasAbertasToolStripMenuItem";
            janelasAbertasToolStripMenuItem.Size = new Size(99, 20);
            janelasAbertasToolStripMenuItem.Text = "Janelas Abertas";
            // 
            // configuraçõesToolStripMenuItem
            // 
            configuraçõesToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            configuraçõesToolStripMenuItem.Size = new Size(96, 20);
            configuraçõesToolStripMenuItem.Text = "Configurações";
            configuraçõesToolStripMenuItem.Click += ConfiguracoesToolStripMenuItem_Click;
            // 
            // backupToolStripMenuItem
            // 
            backupToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            backupToolStripMenuItem.Size = new Size(58, 20);
            backupToolStripMenuItem.Text = "Backup";
            backupToolStripMenuItem.Click += BackupToolStripMenuItem_Click;
            // 
            // gerenciamentoToolStripMenuItem
            // 
            gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            gerenciamentoToolStripMenuItem.Size = new Size(100, 20);
            gerenciamentoToolStripMenuItem.Text = "Gerenciamento";
            gerenciamentoToolStripMenuItem.Click += GerenciamentoToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblUsuario });
            statusStrip1.Location = new Point(0, 489);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(881, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(186, 17);
            lblUsuario.Text = "Status : Conexão não Estabelecida";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 511);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            FormClosing += FrmMenu_FormClosing;
            Load += FrmMenu_Load;
            MdiChildActivate += FrmMain_MdiChildActivate;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaModificacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasAbertasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
    }
}

