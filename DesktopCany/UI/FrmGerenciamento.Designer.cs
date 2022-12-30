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
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgvBibliotecas = new System.Windows.Forms.DataGridView();
            this.dgvFuncoes = new System.Windows.Forms.DataGridView();
            this.txtBuscaLinguagens = new System.Windows.Forms.TextBox();
            this.txtBuscarBibliotecas = new System.Windows.Forms.TextBox();
            this.txtBuscarFuncoes = new System.Windows.Forms.TextBox();
            this.txtFcnModData = new System.Windows.Forms.TextBox();
            this.txtModProgramador = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
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
            this.dgvLinguagens.Size = new System.Drawing.Size(858, 119);
            this.dgvLinguagens.TabIndex = 0;
            this.dgvLinguagens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinguagens_CellDoubleClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(324, 415);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(234, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.dgvBibliotecas.Size = new System.Drawing.Size(858, 119);
            this.dgvBibliotecas.TabIndex = 7;
            this.dgvBibliotecas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBibliotecas_CellDoubleClick);
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
            this.dgvFuncoes.Size = new System.Drawing.Size(858, 119);
            this.dgvFuncoes.TabIndex = 8;
            this.dgvFuncoes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncoes_CellDoubleClick);
            // 
            // txtBuscaLinguagens
            // 
            this.txtBuscaLinguagens.Location = new System.Drawing.Point(12, 12);
            this.txtBuscaLinguagens.Name = "txtBuscaLinguagens";
            this.txtBuscaLinguagens.PlaceholderText = "buscar Linguagem";
            this.txtBuscaLinguagens.Size = new System.Drawing.Size(150, 23);
            this.txtBuscaLinguagens.TabIndex = 9;
            this.txtBuscaLinguagens.TextChanged += new System.EventHandler(this.txtBuscarLinguagem_TextChanged);
            // 
            // txtBuscarBibliotecas
            // 
            this.txtBuscarBibliotecas.Location = new System.Drawing.Point(168, 12);
            this.txtBuscarBibliotecas.Name = "txtBuscarBibliotecas";
            this.txtBuscarBibliotecas.PlaceholderText = "buscar Biblioteca";
            this.txtBuscarBibliotecas.Size = new System.Drawing.Size(150, 23);
            this.txtBuscarBibliotecas.TabIndex = 10;
            this.txtBuscarBibliotecas.TextChanged += new System.EventHandler(this.txtBuscarBiblioteca_TextChanged);
            // 
            // txtBuscarFuncoes
            // 
            this.txtBuscarFuncoes.Location = new System.Drawing.Point(324, 12);
            this.txtBuscarFuncoes.Name = "txtBuscarFuncoes";
            this.txtBuscarFuncoes.PlaceholderText = "buscar Função";
            this.txtBuscarFuncoes.Size = new System.Drawing.Size(150, 23);
            this.txtBuscarFuncoes.TabIndex = 11;
            this.txtBuscarFuncoes.TextChanged += new System.EventHandler(this.txtBuscarFuncoes_TextChanged);
            // 
            // txtFcnModData
            // 
            this.txtFcnModData.Location = new System.Drawing.Point(480, 12);
            this.txtFcnModData.Name = "txtFcnModData";
            this.txtFcnModData.PlaceholderText = "buscar ModData";
            this.txtFcnModData.Size = new System.Drawing.Size(150, 23);
            this.txtFcnModData.TabIndex = 12;
            this.txtFcnModData.TextChanged += new System.EventHandler(this.txtBuscarModData_TextChanged);
            // 
            // txtModProgramador
            // 
            this.txtModProgramador.Location = new System.Drawing.Point(636, 12);
            this.txtModProgramador.Name = "txtModProgramador";
            this.txtModProgramador.PlaceholderText = "buscar ModProgramador";
            this.txtModProgramador.Size = new System.Drawing.Size(150, 23);
            this.txtModProgramador.TabIndex = 13;
            this.txtModProgramador.TextChanged += new System.EventHandler(this.txtBuscarModProgramador_TextChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(792, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 23);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmGerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtModProgramador);
            this.Controls.Add(this.txtFcnModData);
            this.Controls.Add(this.txtBuscarFuncoes);
            this.Controls.Add(this.txtBuscarBibliotecas);
            this.Controls.Add(this.txtBuscaLinguagens);
            this.Controls.Add(this.dgvFuncoes);
            this.Controls.Add(this.dgvBibliotecas);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvLinguagens);
            this.Name = "FrmGerenciamento";
            this.Text = "Gerenciamento";
            this.Load += new System.EventHandler(this.FrmGerenciamentoDb_OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinguagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBibliotecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvLinguagens;
        private Button btnRemove;
        private DataGridView dgvBibliotecas;
        private DataGridView dgvFuncoes;
        private TextBox txtBuscaLinguagens;
        private TextBox txtBuscarBibliotecas;
        private TextBox txtBuscarFuncoes;
        private TextBox txtFcnModData;
        private TextBox txtModProgramador;
        private Button btnReset;
    }
}