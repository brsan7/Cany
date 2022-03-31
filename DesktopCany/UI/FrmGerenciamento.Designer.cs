namespace DesktopCany.UI
{
    partial class FrmGerenciamento
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
            this.dgvLinguagens = new System.Windows.Forms.DataGridView();
            this.cmbBuscaLinguagens = new System.Windows.Forms.ComboBox();
            this.cmbBuscaBibliotecas = new System.Windows.Forms.ComboBox();
            this.cmbBuscaFuncoes = new System.Windows.Forms.ComboBox();
            this.cmbBuscaModDatas = new System.Windows.Forms.ComboBox();
            this.cmbBuscaModProgramadores = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvBibliotecas = new System.Windows.Forms.DataGridView();
            this.dgvFuncoes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinguagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncoes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLinguagens
            // 
            this.dgvLinguagens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLinguagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinguagens.Location = new System.Drawing.Point(12, 41);
            this.dgvLinguagens.Name = "dgvLinguagens";
            this.dgvLinguagens.RowTemplate.Height = 25;
            this.dgvLinguagens.Size = new System.Drawing.Size(774, 119);
            this.dgvLinguagens.TabIndex = 0;
            // 
            // cmbBuscaLinguagens
            // 
            this.cmbBuscaLinguagens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBuscaLinguagens.FormattingEnabled = true;
            this.cmbBuscaLinguagens.Location = new System.Drawing.Point(12, 12);
            this.cmbBuscaLinguagens.Name = "cmbBuscaLinguagens";
            this.cmbBuscaLinguagens.Size = new System.Drawing.Size(150, 23);
            this.cmbBuscaLinguagens.TabIndex = 1;
            // 
            // cmbBuscaBibliotecas
            // 
            this.cmbBuscaBibliotecas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBuscaBibliotecas.FormattingEnabled = true;
            this.cmbBuscaBibliotecas.Location = new System.Drawing.Point(168, 12);
            this.cmbBuscaBibliotecas.Name = "cmbBuscaBibliotecas";
            this.cmbBuscaBibliotecas.Size = new System.Drawing.Size(150, 23);
            this.cmbBuscaBibliotecas.TabIndex = 2;
            // 
            // cmbBuscaFuncoes
            // 
            this.cmbBuscaFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBuscaFuncoes.FormattingEnabled = true;
            this.cmbBuscaFuncoes.Location = new System.Drawing.Point(324, 12);
            this.cmbBuscaFuncoes.Name = "cmbBuscaFuncoes";
            this.cmbBuscaFuncoes.Size = new System.Drawing.Size(150, 23);
            this.cmbBuscaFuncoes.TabIndex = 3;
            // 
            // cmbBuscaModDatas
            // 
            this.cmbBuscaModDatas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBuscaModDatas.FormattingEnabled = true;
            this.cmbBuscaModDatas.Location = new System.Drawing.Point(480, 12);
            this.cmbBuscaModDatas.Name = "cmbBuscaModDatas";
            this.cmbBuscaModDatas.Size = new System.Drawing.Size(150, 23);
            this.cmbBuscaModDatas.TabIndex = 4;
            // 
            // cmbBuscaModProgramadores
            // 
            this.cmbBuscaModProgramadores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBuscaModProgramadores.FormattingEnabled = true;
            this.cmbBuscaModProgramadores.Location = new System.Drawing.Point(636, 12);
            this.cmbBuscaModProgramadores.Name = "cmbBuscaModProgramadores";
            this.cmbBuscaModProgramadores.Size = new System.Drawing.Size(150, 23);
            this.cmbBuscaModProgramadores.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(324, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remover Modificação";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvBibliotecas
            // 
            this.dgvBibliotecas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBibliotecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBibliotecas.Location = new System.Drawing.Point(12, 165);
            this.dgvBibliotecas.Name = "dgvBibliotecas";
            this.dgvBibliotecas.RowTemplate.Height = 25;
            this.dgvBibliotecas.Size = new System.Drawing.Size(774, 119);
            this.dgvBibliotecas.TabIndex = 7;
            // 
            // dgvFuncoes
            // 
            this.dgvFuncoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFuncoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncoes.Location = new System.Drawing.Point(12, 290);
            this.dgvFuncoes.Name = "dgvFuncoes";
            this.dgvFuncoes.RowTemplate.Height = 25;
            this.dgvFuncoes.Size = new System.Drawing.Size(774, 119);
            this.dgvFuncoes.TabIndex = 8;
            // 
            // FrmGerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFuncoes);
            this.Controls.Add(this.dgvBibliotecas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbBuscaModProgramadores);
            this.Controls.Add(this.cmbBuscaModDatas);
            this.Controls.Add(this.cmbBuscaFuncoes);
            this.Controls.Add(this.cmbBuscaBibliotecas);
            this.Controls.Add(this.cmbBuscaLinguagens);
            this.Controls.Add(this.dgvLinguagens);
            this.Name = "FrmGerenciamento";
            this.Text = "FrmGerenciamento";
            this.Load += new System.EventHandler(this.FrmGerenciamentoDb_OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinguagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvLinguagens;
        private ComboBox cmbBuscaLinguagens;
        private ComboBox cmbBuscaBibliotecas;
        private ComboBox cmbBuscaFuncoes;
        private ComboBox cmbBuscaModDatas;
        private ComboBox cmbBuscaModProgramadores;
        private Button button1;
        private DataGridView dgvBibliotecas;
        private DataGridView dgvFuncoes;
    }
}