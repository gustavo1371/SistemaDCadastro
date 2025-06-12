namespace SistemaDCadastro
{
    partial class FormCadastroUsuarios
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
            lblSenha = new Label();
            lblUsuario = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            btnCadastrar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(46, 118);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(46, 48);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuário:";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(46, 136);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(148, 23);
            txtSenha.TabIndex = 5;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(46, 66);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(148, 23);
            txtUsuario.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(46, 192);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(105, 50);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(172, 192);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(105, 50);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormCadastroUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 257);
            Controls.Add(btnExcluir);
            Controls.Add(btnCadastrar);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Name = "FormCadastroUsuarios";
            Text = "Tela de Cadastro de Usuário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSenha;
        private Label lblUsuario;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Button btnCadastrar;
        private Button btnExcluir;
    }
}