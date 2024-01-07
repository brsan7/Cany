using DesktopCany.Propriedades;

namespace DesktopCany.UI
{
    partial class FrmConfiguracao
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
            lblTitulo = new Label();
            txtCorTexto = new TextBox();
            txtCorFundo = new TextBox();
            lblCor = new Label();
            txtConexao = new TextBox();
            btnRestaurar = new Button();
            btnSalvar = new Button();
            colorDialog1 = new ColorDialog();
            btnCorFundo = new Button();
            btnCorText = new Button();
            colorDialog2 = new ColorDialog();
            chkBoxBorder = new CheckBox();
            rbtnLocal = new RadioButton();
            rbtnServidor = new RadioButton();
            cBoxLite = new ComboBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnLocal = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(41, 70);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(74, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cor do Texto";
            // 
            // txtCorTexto
            // 
            txtCorTexto.Location = new Point(41, 88);
            txtCorTexto.Margin = new Padding(4, 3, 4, 3);
            txtCorTexto.Name = "txtCorTexto";
            txtCorTexto.Size = new Size(143, 23);
            txtCorTexto.TabIndex = 2;
            // 
            // txtCorFundo
            // 
            txtCorFundo.Location = new Point(41, 153);
            txtCorFundo.Margin = new Padding(4, 3, 4, 3);
            txtCorFundo.Name = "txtCorFundo";
            txtCorFundo.Size = new Size(143, 23);
            txtCorFundo.TabIndex = 4;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(41, 135);
            lblCor.Margin = new Padding(4, 0, 4, 0);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(79, 15);
            lblCor.TabIndex = 2;
            lblCor.Text = "Cor de Fundo";
            // 
            // txtNomeBase
            // 
            txtConexao.Location = new Point(41, 300);
            txtConexao.Margin = new Padding(4, 3, 4, 3);
            txtConexao.Name = "txtNomeBase";
            txtConexao.Size = new Size(195, 23);
            txtConexao.TabIndex = 7;
            // 
            // btnRestaurar
            // 
            btnRestaurar.ForeColor = Color.Black;
            btnRestaurar.Location = new Point(41, 340);
            btnRestaurar.Margin = new Padding(4, 3, 4, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(88, 27);
            btnRestaurar.TabIndex = 8;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.ForeColor = Color.Black;
            btnSalvar.Location = new Point(148, 340);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 27);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCorFundo
            // 
            btnCorFundo.ForeColor = Color.Black;
            btnCorFundo.Location = new Point(202, 153);
            btnCorFundo.Margin = new Padding(4, 3, 4, 3);
            btnCorFundo.Name = "btnCorFundo";
            btnCorFundo.Size = new Size(34, 23);
            btnCorFundo.TabIndex = 5;
            btnCorFundo.Text = "...";
            btnCorFundo.UseVisualStyleBackColor = true;
            btnCorFundo.Click += btnCor_Click;
            // 
            // btnCorText
            // 
            btnCorText.ForeColor = Color.Black;
            btnCorText.Location = new Point(202, 88);
            btnCorText.Margin = new Padding(4, 3, 4, 3);
            btnCorText.Name = "btnCorText";
            btnCorText.Size = new Size(34, 23);
            btnCorText.TabIndex = 3;
            btnCorText.Text = "...";
            btnCorText.UseVisualStyleBackColor = true;
            btnCorText.Click += btnCorText_Click;
            // 
            // chkBoxBorder
            // 
            chkBoxBorder.AutoSize = true;
            chkBoxBorder.Location = new Point(41, 37);
            chkBoxBorder.Name = "chkBoxBorder";
            chkBoxBorder.Size = new Size(108, 19);
            chkBoxBorder.TabIndex = 1;
            chkBoxBorder.Text = "Borda da Janela";
            chkBoxBorder.UseVisualStyleBackColor = true;
            // 
            // rbtnLocal
            // 
            rbtnLocal.AutoSize = true;
            rbtnLocal.Location = new Point(29, 16);
            rbtnLocal.Name = "rbtnLocal";
            rbtnLocal.Size = new Size(53, 19);
            rbtnLocal.TabIndex = 10;
            rbtnLocal.TabStop = true;
            rbtnLocal.Text = "Local";
            rbtnLocal.UseVisualStyleBackColor = true;
            rbtnLocal.CheckedChanged += rbtnLocal_CheckedChanged;
            // 
            // rbtnServidor
            // 
            rbtnServidor.AutoSize = true;
            rbtnServidor.Location = new Point(29, 81);
            rbtnServidor.Name = "rbtnServidor";
            rbtnServidor.Size = new Size(68, 19);
            rbtnServidor.TabIndex = 11;
            rbtnServidor.TabStop = true;
            rbtnServidor.Text = "Servidor";
            rbtnServidor.UseVisualStyleBackColor = true;
            rbtnServidor.CheckedChanged += rbtnServidor_CheckedChanged;
            // 
            // cBoxLite
            // 
            cBoxLite.FormattingEnabled = true;
            cBoxLite.Location = new Point(41, 235);
            cBoxLite.Name = "cBoxLite";
            cBoxLite.Size = new Size(143, 23);
            cBoxLite.TabIndex = 12;
            // 
            // btnLocal
            // 
            btnLocal.ForeColor = Color.Black;
            btnLocal.Location = new Point(190, 41);
            btnLocal.Margin = new Padding(4, 3, 4, 3);
            btnLocal.Name = "btnLocal";
            btnLocal.Size = new Size(34, 23);
            btnLocal.TabIndex = 13;
            btnLocal.Text = "...";
            btnLocal.UseVisualStyleBackColor = true;
            btnLocal.Click += btnLocal_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 176);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customização";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLocal);
            groupBox2.Controls.Add(rbtnServidor);
            groupBox2.Controls.Add(rbtnLocal);
            groupBox2.Location = new Point(12, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(253, 140);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Conexão";
            // 
            // FrmConfiguracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 377);
            Controls.Add(cBoxLite);
            Controls.Add(chkBoxBorder);
            Controls.Add(btnCorText);
            Controls.Add(btnCorFundo);
            Controls.Add(btnSalvar);
            Controls.Add(btnRestaurar);
            Controls.Add(txtConexao);
            Controls.Add(txtCorFundo);
            Controls.Add(lblCor);
            Controls.Add(txtCorTexto);
            Controls.Add(lblTitulo);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConfiguracao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurações";
            Load += frmConfiguracao_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCorTexto;
        private System.Windows.Forms.TextBox txtCorFundo;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtConexao;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCorFundo;
        private Button btnCorText;
        private ColorDialog colorDialog2;
        private CheckBox chkBoxBorder;
        private RadioButton rbtnLocal;
        private RadioButton rbtnServidor;
        private ComboBox cBoxLite;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnLocal;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}