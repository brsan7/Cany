using DesktopCany.Propriedades;

namespace DesktopCany.UI
{
    partial class FrmRegistro
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
            cmbLinguagens = new ComboBox();
            cmbBibliotecas = new ComboBox();
            rtbDescricaoLang = new RichTextBox();
            cmbFuncoes = new ComboBox();
            rtbSnippet = new RichTextBox();
            cmbFcnModDatas = new ComboBox();
            cmbModProgramador = new ComboBox();
            rtbDescricaoLib = new RichTextBox();
            chkBoxModEstavel = new CheckBox();
            btnRegMod = new Button();
            rtbDescricaoFcn = new RichTextBox();
            SuspendLayout();
            // 
            // cmbLinguagens
            // 
            cmbLinguagens.FormattingEnabled = true;
            cmbLinguagens.Location = new Point(12, 12);
            cmbLinguagens.MaxLength = 30;
            cmbLinguagens.Name = "cmbLinguagens";
            cmbLinguagens.Size = new Size(310, 23);
            cmbLinguagens.TabIndex = 0;
            cmbLinguagens.SelectedIndexChanged += CmbLinguagens_SelectedIndexChanged;
            cmbLinguagens.TextChanged += CmbLinguagens_TextChanged;
            // 
            // cmbBibliotecas
            // 
            cmbBibliotecas.FormattingEnabled = true;
            cmbBibliotecas.Location = new Point(12, 124);
            cmbBibliotecas.MaxLength = 30;
            cmbBibliotecas.Name = "cmbBibliotecas";
            cmbBibliotecas.Size = new Size(310, 23);
            cmbBibliotecas.TabIndex = 1;
            cmbBibliotecas.SelectedIndexChanged += CmbBibliotecas_SelectedIndexChanged;
            cmbBibliotecas.TextChanged += CmbBibliotecas_TextChanged;
            // 
            // rtbDescricaoLang
            // 
            rtbDescricaoLang.BorderStyle = BorderStyle.None;
            rtbDescricaoLang.Location = new Point(12, 41);
            rtbDescricaoLang.MaxLength = 200;
            rtbDescricaoLang.Name = "rtbDescricaoLang";
            rtbDescricaoLang.Size = new Size(310, 77);
            rtbDescricaoLang.TabIndex = 2;
            rtbDescricaoLang.Text = "";
            // 
            // cmbFuncoes
            // 
            cmbFuncoes.FormattingEnabled = true;
            cmbFuncoes.Location = new Point(12, 236);
            cmbFuncoes.MaxLength = 50;
            cmbFuncoes.Name = "cmbFuncoes";
            cmbFuncoes.Size = new Size(310, 23);
            cmbFuncoes.TabIndex = 3;
            cmbFuncoes.SelectedIndexChanged += CmbFuncoes_SelectedIndexChanged;
            cmbFuncoes.TextChanged += CmbFuncoes_TextChanged;
            // 
            // rtbSnippet
            // 
            rtbSnippet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbSnippet.BorderStyle = BorderStyle.None;
            rtbSnippet.Location = new Point(328, 12);
            rtbSnippet.Name = "rtbSnippet";
            rtbSnippet.Size = new Size(524, 437);
            rtbSnippet.TabIndex = 4;
            rtbSnippet.Text = "";
            // 
            // cmbFcnModDatas
            // 
            cmbFcnModDatas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFcnModDatas.FormattingEnabled = true;
            cmbFcnModDatas.Location = new Point(12, 398);
            cmbFcnModDatas.Name = "cmbFcnModDatas";
            cmbFcnModDatas.Size = new Size(207, 23);
            cmbFcnModDatas.TabIndex = 5;
            cmbFcnModDatas.SelectedIndexChanged += CmbFcnModDatas_SelectedIndexChanged;
            // 
            // cmbModProgramador
            // 
            cmbModProgramador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModProgramador.FormattingEnabled = true;
            cmbModProgramador.Location = new Point(12, 426);
            cmbModProgramador.Name = "cmbModProgramador";
            cmbModProgramador.Size = new Size(208, 23);
            cmbModProgramador.TabIndex = 6;
            cmbModProgramador.SelectedIndexChanged += CmbModProgramadores_SelectedIndexChanged;
            // 
            // rtbDescricaoLib
            // 
            rtbDescricaoLib.BorderStyle = BorderStyle.None;
            rtbDescricaoLib.Location = new Point(12, 153);
            rtbDescricaoLib.MaxLength = 200;
            rtbDescricaoLib.Name = "rtbDescricaoLib";
            rtbDescricaoLib.Size = new Size(310, 77);
            rtbDescricaoLib.TabIndex = 7;
            rtbDescricaoLib.Text = "";
            // 
            // chkBoxModEstavel
            // 
            chkBoxModEstavel.AutoSize = true;
            chkBoxModEstavel.Enabled = false;
            chkBoxModEstavel.Location = new Point(225, 400);
            chkBoxModEstavel.Name = "chkBoxModEstavel";
            chkBoxModEstavel.Size = new Size(97, 19);
            chkBoxModEstavel.TabIndex = 8;
            chkBoxModEstavel.Text = "Homologado";
            chkBoxModEstavel.UseVisualStyleBackColor = true;
            chkBoxModEstavel.CheckedChanged += ChkBoxModEstavel_SelectedIndexChanged;
            // 
            // btnRegMod
            // 
            btnRegMod.Enabled = false;
            btnRegMod.ForeColor = Color.Black;
            btnRegMod.Location = new Point(226, 427);
            btnRegMod.Name = "btnRegMod";
            btnRegMod.Size = new Size(96, 23);
            btnRegMod.TabIndex = 9;
            btnRegMod.Text = "RegMod";
            btnRegMod.UseVisualStyleBackColor = true;
            btnRegMod.Click += BtnRegMod_OnClick;
            // 
            // rtbDescricaoFcn
            // 
            rtbDescricaoFcn.BorderStyle = BorderStyle.None;
            rtbDescricaoFcn.Location = new Point(12, 265);
            rtbDescricaoFcn.MaxLength = 400;
            rtbDescricaoFcn.Name = "rtbDescricaoFcn";
            rtbDescricaoFcn.Size = new Size(310, 126);
            rtbDescricaoFcn.TabIndex = 10;
            rtbDescricaoFcn.Text = "";
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 461);
            Controls.Add(rtbDescricaoFcn);
            Controls.Add(btnRegMod);
            Controls.Add(chkBoxModEstavel);
            Controls.Add(rtbDescricaoLib);
            Controls.Add(cmbModProgramador);
            Controls.Add(cmbFcnModDatas);
            Controls.Add(rtbSnippet);
            Controls.Add(cmbFuncoes);
            Controls.Add(rtbDescricaoLang);
            Controls.Add(cmbBibliotecas);
            Controls.Add(cmbLinguagens);
            Name = "FrmRegistro";
            Text = "Home";
            Load += FrmRegistroOnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbLinguagens;
        private ComboBox cmbBibliotecas;
        private RichTextBox rtbDescricaoLang;
        private ComboBox cmbFuncoes;
        private RichTextBox rtbSnippet;
        private ComboBox cmbFcnModDatas;
        private ComboBox cmbModProgramador;
        private RichTextBox rtbDescricaoLib;
        private CheckBox chkBoxModEstavel;
        private Button btnRegMod;
        private RichTextBox rtbDescricaoFcn;
    }
}