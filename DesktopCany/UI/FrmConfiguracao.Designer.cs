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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNomeBase = new System.Windows.Forms.TextBox();
            this.lblNomeBase = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(36, 37);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo da Aplicação";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(40, 55);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(195, 23);
            this.txtTitulo.TabIndex = 1;
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(40, 117);
            this.txtCor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(143, 23);
            this.txtCor.TabIndex = 3;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(36, 98);
            this.lblCor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(75, 15);
            this.lblCor.TabIndex = 2;
            this.lblCor.Text = "Cor das Telas";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(40, 180);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(195, 23);
            this.txtEndereco.TabIndex = 5;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(36, 162);
            this.lblEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(142, 15);
            this.lblEndereco.TabIndex = 4;
            this.lblEndereco.Text = "Endereço do servidor SQL";
            // 
            // txtNomeBase
            // 
            this.txtNomeBase.Location = new System.Drawing.Point(40, 249);
            this.txtNomeBase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNomeBase.Name = "txtNomeBase";
            this.txtNomeBase.Size = new System.Drawing.Size(195, 23);
            this.txtNomeBase.TabIndex = 7;
            // 
            // lblNomeBase
            // 
            this.lblNomeBase.AutoSize = true;
            this.lblNomeBase.Location = new System.Drawing.Point(36, 231);
            this.lblNomeBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeBase.Name = "lblNomeBase";
            this.lblNomeBase.Size = new System.Drawing.Size(135, 15);
            this.lblNomeBase.TabIndex = 6;
            this.lblNomeBase.Text = "Nome da Base de Dados";
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(40, 295);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(88, 27);
            this.btnRestaurar.TabIndex = 8;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(148, 295);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 27);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCor
            // 
            this.btnCor.Location = new System.Drawing.Point(202, 117);
            this.btnCor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCor.Name = "btnCor";
            this.btnCor.Size = new System.Drawing.Size(34, 23);
            this.btnCor.TabIndex = 10;
            this.btnCor.Text = "...";
            this.btnCor.UseVisualStyleBackColor = true;
            this.btnCor.Click += new System.EventHandler(this.btnCor_Click);
            // 
            // FrmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 377);
            this.Controls.Add(this.btnCor);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.txtNomeBase);
            this.Controls.Add(this.lblNomeBase);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frmConfiguracao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNomeBase;
        private System.Windows.Forms.Label lblNomeBase;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCor;
    }
}