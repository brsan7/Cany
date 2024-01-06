using DesktopCany.Propriedades;

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
            dgvLinguagens = new DataGridView();
            btnRemove = new Button();
            dgvBibliotecas = new DataGridView();
            dgvFuncoes = new DataGridView();
            txtBuscaLinguagens = new TextBox();
            txtBuscarBibliotecas = new TextBox();
            txtBuscarFuncoes = new TextBox();
            txtFcnModData = new TextBox();
            txtModProgramador = new TextBox();
            btnReset = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLinguagens).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBibliotecas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFuncoes).BeginInit();
            SuspendLayout();
            // 
            // dgvLinguagens
            // 
            dgvLinguagens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLinguagens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLinguagens.Location = new Point(12, 41);
            dgvLinguagens.Name = "dgvLinguagens";
            dgvLinguagens.RowTemplate.Height = 25;
            dgvLinguagens.Size = new Size(858, 119);
            dgvLinguagens.TabIndex = 0;
            dgvLinguagens.CellDoubleClick += dgvLinguagens_CellDoubleClick;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemove.ForeColor = Color.Black;
            btnRemove.Location = new Point(670, 415);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(200, 23);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remover";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // dgvBibliotecas
            // 
            dgvBibliotecas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBibliotecas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBibliotecas.Location = new Point(12, 165);
            dgvBibliotecas.Name = "dgvBibliotecas";
            dgvBibliotecas.RowTemplate.Height = 25;
            dgvBibliotecas.Size = new Size(858, 119);
            dgvBibliotecas.TabIndex = 7;
            dgvBibliotecas.CellDoubleClick += dgvBibliotecas_CellDoubleClick;
            // 
            // dgvFuncoes
            // 
            dgvFuncoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFuncoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncoes.Location = new Point(12, 290);
            dgvFuncoes.Name = "dgvFuncoes";
            dgvFuncoes.RowTemplate.Height = 25;
            dgvFuncoes.Size = new Size(858, 119);
            dgvFuncoes.TabIndex = 8;
            dgvFuncoes.CellDoubleClick += dgvFuncoes_CellDoubleClick;
            // 
            // txtBuscaLinguagens
            // 
            txtBuscaLinguagens.Location = new Point(12, 12);
            txtBuscaLinguagens.Name = "txtBuscaLinguagens";
            txtBuscaLinguagens.PlaceholderText = "buscar Linguagem";
            txtBuscaLinguagens.Size = new Size(150, 23);
            txtBuscaLinguagens.TabIndex = 9;
            txtBuscaLinguagens.TextChanged += txtBuscarLinguagem_TextChanged;
            // 
            // txtBuscarBibliotecas
            // 
            txtBuscarBibliotecas.Location = new Point(168, 12);
            txtBuscarBibliotecas.Name = "txtBuscarBibliotecas";
            txtBuscarBibliotecas.PlaceholderText = "buscar Biblioteca";
            txtBuscarBibliotecas.Size = new Size(150, 23);
            txtBuscarBibliotecas.TabIndex = 10;
            txtBuscarBibliotecas.TextChanged += txtBuscarBiblioteca_TextChanged;
            // 
            // txtBuscarFuncoes
            // 
            txtBuscarFuncoes.Location = new Point(324, 12);
            txtBuscarFuncoes.Name = "txtBuscarFuncoes";
            txtBuscarFuncoes.PlaceholderText = "buscar Função";
            txtBuscarFuncoes.Size = new Size(150, 23);
            txtBuscarFuncoes.TabIndex = 11;
            txtBuscarFuncoes.TextChanged += txtBuscarFuncoes_TextChanged;
            // 
            // txtFcnModData
            // 
            txtFcnModData.Location = new Point(480, 12);
            txtFcnModData.Name = "txtFcnModData";
            txtFcnModData.PlaceholderText = "buscar ModData";
            txtFcnModData.Size = new Size(150, 23);
            txtFcnModData.TabIndex = 12;
            txtFcnModData.TextChanged += txtBuscarModData_TextChanged;
            // 
            // txtModProgramador
            // 
            txtModProgramador.Location = new Point(636, 12);
            txtModProgramador.Name = "txtModProgramador";
            txtModProgramador.PlaceholderText = "buscar ModProgramador";
            txtModProgramador.Size = new Size(150, 23);
            txtModProgramador.TabIndex = 13;
            txtModProgramador.TextChanged += txtBuscarModProgramador_TextChanged;
            // 
            // btnReset
            // 
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(792, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(78, 23);
            btnReset.TabIndex = 14;
            btnReset.Text = "reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEdit.Enabled = false;
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(464, 415);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(200, 23);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // FrmGerenciamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(btnEdit);
            Controls.Add(btnReset);
            Controls.Add(txtModProgramador);
            Controls.Add(txtFcnModData);
            Controls.Add(txtBuscarFuncoes);
            Controls.Add(txtBuscarBibliotecas);
            Controls.Add(txtBuscaLinguagens);
            Controls.Add(dgvFuncoes);
            Controls.Add(dgvBibliotecas);
            Controls.Add(btnRemove);
            Controls.Add(dgvLinguagens);
            Name = "FrmGerenciamento";
            Text = "Gerenciamento";
            Load += FrmGerenciamentoDb_OnLoad;
            ((System.ComponentModel.ISupportInitialize)dgvLinguagens).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBibliotecas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFuncoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnEdit;
    }
}