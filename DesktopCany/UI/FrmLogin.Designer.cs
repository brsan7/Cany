using DesktopCany.Propriedades;
namespace DesktopCany.UI
{
    partial class FrmLogin
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
            btnAutenticar = new Button();
            txtUsuario = new TextBox();
            SuspendLayout();
            // 
            // btnAutenticar
            // 
            btnAutenticar.Location = new Point(12, 79);
            btnAutenticar.Margin = new Padding(4, 3, 4, 3);
            btnAutenticar.Name = "btnAutenticar";
            btnAutenticar.Size = new Size(310, 27);
            btnAutenticar.TabIndex = 0;
            btnAutenticar.Text = "Autenticar";
            btnAutenticar.UseVisualStyleBackColor = true;
            btnAutenticar.Click += btnAutenticar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 50);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Configure sua Assinatura de Colaborador";
            txtUsuario.Size = new Size(310, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 161);
            Controls.Add(txtUsuario);
            Controls.Add(btnAutenticar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Colaborador";
            Load += FrmLoginOnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAutenticar;
        private TextBox txtUsuario;
    }
}