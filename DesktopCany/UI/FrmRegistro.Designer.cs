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
            this.cmbLinguagens = new System.Windows.Forms.ComboBox();
            this.cmbBibliotecas = new System.Windows.Forms.ComboBox();
            this.rtbDescricaoLang = new System.Windows.Forms.RichTextBox();
            this.cmbFuncoes = new System.Windows.Forms.ComboBox();
            this.rtbSnippet = new System.Windows.Forms.RichTextBox();
            this.cmbFcnModDatas = new System.Windows.Forms.ComboBox();
            this.cmbModProgramador = new System.Windows.Forms.ComboBox();
            this.rtbDescricaoLib = new System.Windows.Forms.RichTextBox();
            this.chkBoxModEstavel = new System.Windows.Forms.CheckBox();
            this.btnRegMod = new System.Windows.Forms.Button();
            this.rtbDescricaoFcn = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmbLinguagens
            // 
            this.cmbLinguagens.FormattingEnabled = true;
            this.cmbLinguagens.Location = new System.Drawing.Point(12, 12);
            this.cmbLinguagens.MaxLength = 30;
            this.cmbLinguagens.Name = "cmbLinguagens";
            this.cmbLinguagens.Size = new System.Drawing.Size(310, 23);
            this.cmbLinguagens.TabIndex = 0;
            this.cmbLinguagens.SelectedIndexChanged += new System.EventHandler(this.CmbLinguagens_SelectedIndexChanged);
            this.cmbLinguagens.TextChanged += new System.EventHandler(this.CmbLinguagens_TextChanged);
            // 
            // cmbBibliotecas
            // 
            this.cmbBibliotecas.FormattingEnabled = true;
            this.cmbBibliotecas.Location = new System.Drawing.Point(12, 124);
            this.cmbBibliotecas.MaxLength = 30;
            this.cmbBibliotecas.Name = "cmbBibliotecas";
            this.cmbBibliotecas.Size = new System.Drawing.Size(310, 23);
            this.cmbBibliotecas.TabIndex = 1;
            this.cmbBibliotecas.SelectedIndexChanged += new System.EventHandler(this.CmbBibliotecas_SelectedIndexChanged);
            this.cmbBibliotecas.TextChanged += new System.EventHandler(this.CmbBibliotecas_TextChanged);
            // 
            // rtbDescricaoLang
            // 
            this.rtbDescricaoLang.Location = new System.Drawing.Point(12, 41);
            this.rtbDescricaoLang.MaxLength = 200;
            this.rtbDescricaoLang.Name = "rtbDescricaoLang";
            this.rtbDescricaoLang.Size = new System.Drawing.Size(310, 77);
            this.rtbDescricaoLang.TabIndex = 2;
            this.rtbDescricaoLang.Text = "";
            // 
            // cmbFuncoes
            // 
            this.cmbFuncoes.FormattingEnabled = true;
            this.cmbFuncoes.Location = new System.Drawing.Point(12, 236);
            this.cmbFuncoes.MaxLength = 50;
            this.cmbFuncoes.Name = "cmbFuncoes";
            this.cmbFuncoes.Size = new System.Drawing.Size(310, 23);
            this.cmbFuncoes.TabIndex = 3;
            this.cmbFuncoes.SelectedIndexChanged += new System.EventHandler(this.CmbFuncoes_SelectedIndexChanged);
            this.cmbFuncoes.TextChanged += new System.EventHandler(this.CmbFuncoes_TextChanged);
            // 
            // rtbSnippet
            // 
            this.rtbSnippet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSnippet.Location = new System.Drawing.Point(328, 12);
            this.rtbSnippet.Name = "rtbSnippet";
            this.rtbSnippet.Size = new System.Drawing.Size(658, 437);
            this.rtbSnippet.TabIndex = 4;
            this.rtbSnippet.Text = "";
            // 
            // cmbFcnModDatas
            // 
            this.cmbFcnModDatas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFcnModDatas.FormattingEnabled = true;
            this.cmbFcnModDatas.Location = new System.Drawing.Point(12, 398);
            this.cmbFcnModDatas.Name = "cmbFcnModDatas";
            this.cmbFcnModDatas.Size = new System.Drawing.Size(150, 23);
            this.cmbFcnModDatas.TabIndex = 5;
            this.cmbFcnModDatas.SelectedIndexChanged += new System.EventHandler(this.CmbFcnModDatas_SelectedIndexChanged);
            // 
            // cmbModProgramador
            // 
            this.cmbModProgramador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModProgramador.FormattingEnabled = true;
            this.cmbModProgramador.Location = new System.Drawing.Point(12, 426);
            this.cmbModProgramador.Name = "cmbModProgramador";
            this.cmbModProgramador.Size = new System.Drawing.Size(310, 23);
            this.cmbModProgramador.TabIndex = 6;
            this.cmbModProgramador.SelectedIndexChanged += new System.EventHandler(this.CmbModProgramadores_SelectedIndexChanged);
            // 
            // rtbDescricaoLib
            // 
            this.rtbDescricaoLib.Location = new System.Drawing.Point(12, 153);
            this.rtbDescricaoLib.MaxLength = 200;
            this.rtbDescricaoLib.Name = "rtbDescricaoLib";
            this.rtbDescricaoLib.Size = new System.Drawing.Size(310, 77);
            this.rtbDescricaoLib.TabIndex = 7;
            this.rtbDescricaoLib.Text = "";
            // 
            // chkBoxModEstavel
            // 
            this.chkBoxModEstavel.AutoSize = true;
            this.chkBoxModEstavel.Location = new System.Drawing.Point(168, 401);
            this.chkBoxModEstavel.Name = "chkBoxModEstavel";
            this.chkBoxModEstavel.Size = new System.Drawing.Size(62, 19);
            this.chkBoxModEstavel.TabIndex = 8;
            this.chkBoxModEstavel.Text = "Estável";
            this.chkBoxModEstavel.UseVisualStyleBackColor = true;
            this.chkBoxModEstavel.CheckedChanged += new System.EventHandler(this.ChkBoxModEstavel_SelectedIndexChanged);
            // 
            // btnRegMod
            // 
            this.btnRegMod.Enabled = false;
            this.btnRegMod.Location = new System.Drawing.Point(226, 397);
            this.btnRegMod.Name = "btnRegMod";
            this.btnRegMod.Size = new System.Drawing.Size(96, 23);
            this.btnRegMod.TabIndex = 9;
            this.btnRegMod.Text = "RegMod";
            this.btnRegMod.UseVisualStyleBackColor = true;
            this.btnRegMod.Click += new System.EventHandler(this.BtnRegMod_OnClick);
            // 
            // rtbDescricaoFcn
            // 
            this.rtbDescricaoFcn.Location = new System.Drawing.Point(12, 265);
            this.rtbDescricaoFcn.MaxLength = 400;
            this.rtbDescricaoFcn.Name = "rtbDescricaoFcn";
            this.rtbDescricaoFcn.Size = new System.Drawing.Size(310, 126);
            this.rtbDescricaoFcn.TabIndex = 10;
            this.rtbDescricaoFcn.Text = "";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 461);
            this.Controls.Add(this.rtbDescricaoFcn);
            this.Controls.Add(this.btnRegMod);
            this.Controls.Add(this.chkBoxModEstavel);
            this.Controls.Add(this.rtbDescricaoLib);
            this.Controls.Add(this.cmbModProgramador);
            this.Controls.Add(this.cmbFcnModDatas);
            this.Controls.Add(this.rtbSnippet);
            this.Controls.Add(this.cmbFuncoes);
            this.Controls.Add(this.rtbDescricaoLang);
            this.Controls.Add(this.cmbBibliotecas);
            this.Controls.Add(this.cmbLinguagens);
            this.Name = "FrmRegistro";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmRegistroOnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

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