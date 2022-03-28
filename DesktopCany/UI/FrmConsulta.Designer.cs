namespace DesktopCany.UI
{
    partial class FrmConsulta
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
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnEstadoBusca = new System.Windows.Forms.Button();
            this.rtbViewSearch = new System.Windows.Forms.RichTextBox();
            this.cBoxFuncao = new System.Windows.Forms.ComboBox();
            this.cBoxBiblioteca = new System.Windows.Forms.ComboBox();
            this.cBoxLinguagem = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(12, 439);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PlaceholderText = "Digite para buscar na tela";
            this.txtBusca.Size = new System.Drawing.Size(251, 23);
            this.txtBusca.TabIndex = 0;
            // 
            // btnEstadoBusca
            // 
            this.btnEstadoBusca.Location = new System.Drawing.Point(269, 439);
            this.btnEstadoBusca.Name = "btnEstadoBusca";
            this.btnEstadoBusca.Size = new System.Drawing.Size(61, 23);
            this.btnEstadoBusca.TabIndex = 1;
            this.btnEstadoBusca.Text = "ON/OFF";
            this.btnEstadoBusca.UseVisualStyleBackColor = true;
            this.btnEstadoBusca.Click += new System.EventHandler(this.onClick);
            // 
            // rtbViewSearch
            // 
            this.rtbViewSearch.Location = new System.Drawing.Point(0, 0);
            this.rtbViewSearch.Name = "rtbViewSearch";
            this.rtbViewSearch.Size = new System.Drawing.Size(330, 433);
            this.rtbViewSearch.TabIndex = 2;
            this.rtbViewSearch.Text = "Bem Vindo ao Software Livre Cany - Versão 3   =======>*SlCany*   ================" +
    "=======>*Em Construção*   =======================>*Em Operação*   ==============" +
    "=========>*FrmRegistro*";
            // 
            // cBoxFuncao
            // 
            this.cBoxFuncao.FormattingEnabled = true;
            this.cBoxFuncao.Location = new System.Drawing.Point(12, 526);
            this.cBoxFuncao.Name = "cBoxFuncao";
            this.cBoxFuncao.Size = new System.Drawing.Size(310, 23);
            this.cBoxFuncao.TabIndex = 3;
            // 
            // cBoxBiblioteca
            // 
            this.cBoxBiblioteca.FormattingEnabled = true;
            this.cBoxBiblioteca.Location = new System.Drawing.Point(12, 497);
            this.cBoxBiblioteca.Name = "cBoxBiblioteca";
            this.cBoxBiblioteca.Size = new System.Drawing.Size(310, 23);
            this.cBoxBiblioteca.TabIndex = 4;
            // 
            // cBoxLinguagem
            // 
            this.cBoxLinguagem.FormattingEnabled = true;
            this.cBoxLinguagem.Location = new System.Drawing.Point(12, 468);
            this.cBoxLinguagem.Name = "cBoxLinguagem";
            this.cBoxLinguagem.Size = new System.Drawing.Size(310, 23);
            this.cBoxLinguagem.TabIndex = 5;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(334, 561);
            this.Controls.Add(this.cBoxLinguagem);
            this.Controls.Add(this.cBoxBiblioteca);
            this.Controls.Add(this.cBoxFuncao);
            this.Controls.Add(this.rtbViewSearch);
            this.Controls.Add(this.btnEstadoBusca);
            this.Controls.Add(this.txtBusca);
            this.Name = "FrmConsulta";
            this.Text = "FrmConsulta";
            this.Load += new System.EventHandler(this.FrmConsultaOnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBusca;
        private Button btnEstadoBusca;
        private RichTextBox rtbViewSearch;
        private ComboBox cBoxFuncao;
        private ComboBox cBoxBiblioteca;
        private ComboBox cBoxLinguagem;
    }
}