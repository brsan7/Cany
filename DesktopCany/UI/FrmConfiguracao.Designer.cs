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
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtNomeBase = new TextBox();
            lblNomeBase = new Label();
            btnRestaurar = new Button();
            btnSalvar = new Button();
            colorDialog1 = new ColorDialog();
            btnCorFundo = new Button();
            btnCorText = new Button();
            colorDialog2 = new ColorDialog();
            chkBoxBorder = new CheckBox();
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
            // txtEndereco
            // 
            txtEndereco.Location = new Point(41, 219);
            txtEndereco.Margin = new Padding(4, 3, 4, 3);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(195, 23);
            txtEndereco.TabIndex = 6;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(41, 201);
            lblEndereco.Margin = new Padding(4, 0, 4, 0);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(142, 15);
            lblEndereco.TabIndex = 4;
            lblEndereco.Text = "Endereço do servidor SQL";
            // 
            // txtNomeBase
            // 
            txtNomeBase.Location = new Point(41, 284);
            txtNomeBase.Margin = new Padding(4, 3, 4, 3);
            txtNomeBase.Name = "txtNomeBase";
            txtNomeBase.Size = new Size(195, 23);
            txtNomeBase.TabIndex = 7;
            // 
            // lblNomeBase
            // 
            lblNomeBase.AutoSize = true;
            lblNomeBase.Location = new Point(41, 266);
            lblNomeBase.Margin = new Padding(4, 0, 4, 0);
            lblNomeBase.Name = "lblNomeBase";
            lblNomeBase.Size = new Size(135, 15);
            lblNomeBase.TabIndex = 6;
            lblNomeBase.Text = "Nome da Base de Dados";
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
            chkBoxBorder.Location = new Point(41, 29);
            chkBoxBorder.Name = "chkBoxBorder";
            chkBoxBorder.Size = new Size(108, 19);
            chkBoxBorder.TabIndex = 1;
            chkBoxBorder.Text = "Borda da Janela";
            chkBoxBorder.UseVisualStyleBackColor = true;
            // 
            // FrmConfiguracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 377);
            Controls.Add(chkBoxBorder);
            Controls.Add(btnCorText);
            Controls.Add(btnCorFundo);
            Controls.Add(btnSalvar);
            Controls.Add(btnRestaurar);
            Controls.Add(txtNomeBase);
            Controls.Add(lblNomeBase);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(txtCorFundo);
            Controls.Add(lblCor);
            Controls.Add(txtCorTexto);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmConfiguracao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configurações";
            Load += frmConfiguracao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCorTexto;
        private System.Windows.Forms.TextBox txtCorFundo;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNomeBase;
        private System.Windows.Forms.Label lblNomeBase;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCorFundo;
        private Button btnCorText;
        private ColorDialog colorDialog2;
        private CheckBox chkBoxBorder;
    }
}