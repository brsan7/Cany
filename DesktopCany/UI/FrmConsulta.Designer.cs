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
            rtbViewSearch = new RichTextBox();
            cBoxFuncao = new ComboBox();
            cBoxBiblioteca = new ComboBox();
            cBoxLinguagem = new ComboBox();
            cBoxModData = new ComboBox();
            pboxStandBy = new PictureBox();
            btnStandBy = new Button();
            ((System.ComponentModel.ISupportInitialize)pboxStandBy).BeginInit();
            SuspendLayout();
            // 
            // rtbViewSearch
            // 
            rtbViewSearch.BackColor = SystemColors.WindowText;
            rtbViewSearch.BorderStyle = BorderStyle.None;
            rtbViewSearch.ForeColor = Color.Lime;
            rtbViewSearch.Location = new Point(0, 0);
            rtbViewSearch.Margin = new Padding(0);
            rtbViewSearch.Name = "rtbViewSearch";
            rtbViewSearch.ReadOnly = true;
            rtbViewSearch.Size = new Size(333, 436);
            rtbViewSearch.TabIndex = 2;
            rtbViewSearch.Text = "\t\tCany - Versão-3.7";
            // 
            // cBoxFuncao
            // 
            cBoxFuncao.FormattingEnabled = true;
            cBoxFuncao.Location = new Point(12, 497);
            cBoxFuncao.Name = "cBoxFuncao";
            cBoxFuncao.Size = new Size(310, 23);
            cBoxFuncao.TabIndex = 3;
            cBoxFuncao.SelectedIndexChanged += cBoxFuncao_SelectedIndexChanged;
            // 
            // cBoxBiblioteca
            // 
            cBoxBiblioteca.FormattingEnabled = true;
            cBoxBiblioteca.Location = new Point(12, 468);
            cBoxBiblioteca.Name = "cBoxBiblioteca";
            cBoxBiblioteca.Size = new Size(310, 23);
            cBoxBiblioteca.TabIndex = 4;
            cBoxBiblioteca.SelectedIndexChanged += cBoxBiblioteca_SelectedIndexChanged;
            // 
            // cBoxLinguagem
            // 
            cBoxLinguagem.FormattingEnabled = true;
            cBoxLinguagem.Location = new Point(12, 439);
            cBoxLinguagem.Name = "cBoxLinguagem";
            cBoxLinguagem.Size = new Size(232, 23);
            cBoxLinguagem.TabIndex = 5;
            cBoxLinguagem.SelectedIndexChanged += cBoxLinguagem_SelectedIndexChanged;
            // 
            // cBoxModData
            // 
            cBoxModData.FormattingEnabled = true;
            cBoxModData.Location = new Point(12, 526);
            cBoxModData.Name = "cBoxModData";
            cBoxModData.Size = new Size(310, 23);
            cBoxModData.TabIndex = 6;
            cBoxModData.SelectedIndexChanged += cBoxModData_SelectedIndexChanged;
            // 
            // pboxStandBy
            // 
            pboxStandBy.Image = Propriedades.Recursos.ImgStandBy;
            pboxStandBy.InitialImage = Propriedades.Recursos.ImgStandBy;
            pboxStandBy.Location = new Point(0, 0);
            pboxStandBy.Margin = new Padding(0);
            pboxStandBy.Name = "pboxStandBy";
            pboxStandBy.Size = new Size(150, 84);
            pboxStandBy.TabIndex = 7;
            pboxStandBy.TabStop = false;
            pboxStandBy.Visible = false;
            pboxStandBy.MouseEnter += pboxStandBy_MouseEnter;
            // 
            // btnStandBy
            // 
            btnStandBy.FlatAppearance.BorderSize = 0;
            btnStandBy.Location = new Point(247, 439);
            btnStandBy.Margin = new Padding(0);
            btnStandBy.Name = "btnStandBy";
            btnStandBy.Size = new Size(75, 23);
            btnStandBy.TabIndex = 8;
            btnStandBy.Text = "Stand By";
            btnStandBy.UseVisualStyleBackColor = true;
            btnStandBy.Click += btnStandBy_Click;
            // 
            // FrmConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(334, 561);
            Controls.Add(btnStandBy);
            Controls.Add(pboxStandBy);
            Controls.Add(cBoxModData);
            Controls.Add(cBoxLinguagem);
            Controls.Add(cBoxBiblioteca);
            Controls.Add(cBoxFuncao);
            Controls.Add(rtbViewSearch);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Location = new Point(1030, 0);
            MaximizeBox = false;
            MaximumSize = new Size(350, 600);
            MinimizeBox = false;
            Name = "FrmConsulta";
            Opacity = 0.8D;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.Manual;
            Text = "Cany";
            TopMost = true;
            Load += FrmConsultaOnLoad;
            ((System.ComponentModel.ISupportInitialize)pboxStandBy).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox rtbViewSearch;
        private ComboBox cBoxFuncao;
        private ComboBox cBoxBiblioteca;
        private ComboBox cBoxLinguagem;
        private ComboBox cBoxModData;
        private PictureBox pboxStandBy;
        private Button btnStandBy;
    }
}