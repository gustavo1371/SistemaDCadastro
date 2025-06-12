namespace SistemaDCadastro
{
    partial class FormCadastroClientes
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
            lblNome = new Label();
            lblCPF = new Label();
            lblEmail = new Label();
            lblCEP = new Label();
            lblCidade = new Label();
            lblBairro = new Label();
            lblNumero = new Label();
            lblLogradouro = new Label();
            lblWhatsApp = new Label();
            lblTelefone = new Label();
            lblEstado = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCPF = new TextBox();
            txtCEP = new TextBox();
            txtLogradouro = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            txtEstado = new TextBox();
            txtWhatsApp = new TextBox();
            txtTelefone = new TextBox();
            btnCadastrar = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(12, 120);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 1;
            lblCPF.Text = "CPF:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 66);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblCEP
            // 
            lblCEP.AutoSize = true;
            lblCEP.Location = new Point(12, 177);
            lblCEP.Name = "lblCEP";
            lblCEP.Size = new Size(31, 15);
            lblCEP.TabIndex = 3;
            lblCEP.Text = "CEP:";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(12, 234);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(47, 15);
            lblCidade.TabIndex = 7;
            lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(202, 234);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(41, 15);
            lblBairro.TabIndex = 6;
            lblBairro.Text = "Bairro:";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(12, 292);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 5;
            lblNumero.Text = "Número:";
            // 
            // lblLogradouro
            // 
            lblLogradouro.AutoSize = true;
            lblLogradouro.Location = new Point(202, 177);
            lblLogradouro.Name = "lblLogradouro";
            lblLogradouro.Size = new Size(72, 15);
            lblLogradouro.TabIndex = 4;
            lblLogradouro.Text = "Logradouro:";
            // 
            // lblWhatsApp
            // 
            lblWhatsApp.AutoSize = true;
            lblWhatsApp.Location = new Point(548, 84);
            lblWhatsApp.Name = "lblWhatsApp";
            lblWhatsApp.Size = new Size(65, 15);
            lblWhatsApp.TabIndex = 10;
            lblWhatsApp.Text = "WhatsApp:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(548, 9);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 9;
            lblTelefone.Text = "Telefone:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(408, 177);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 27);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(491, 23);
            txtNome.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 84);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(491, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(12, 138);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(491, 23);
            txtCPF.TabIndex = 13;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(12, 198);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(161, 23);
            txtCEP.TabIndex = 14;
            txtCEP.TextChanged += txtCEP_Leave;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(202, 198);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(184, 23);
            txtLogradouro.TabIndex = 15;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(12, 252);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(161, 23);
            txtCidade.TabIndex = 16;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(202, 252);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(184, 23);
            txtBairro.TabIndex = 17;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 310);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(161, 23);
            txtNumero.TabIndex = 18;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(408, 198);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(184, 23);
            txtEstado.TabIndex = 19;
            // 
            // txtWhatsApp
            // 
            txtWhatsApp.Location = new Point(548, 102);
            txtWhatsApp.Name = "txtWhatsApp";
            txtWhatsApp.Size = new Size(177, 23);
            txtWhatsApp.TabIndex = 20;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(548, 27);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(177, 23);
            txtTelefone.TabIndex = 21;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(377, 310);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(112, 47);
            btnCadastrar.TabIndex = 22;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(495, 310);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(112, 47);
            btnAtualizar.TabIndex = 23;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(613, 310);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(112, 47);
            btnExcluir.TabIndex = 24;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 379);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtTelefone);
            Controls.Add(txtWhatsApp);
            Controls.Add(txtEstado);
            Controls.Add(txtNumero);
            Controls.Add(txtBairro);
            Controls.Add(txtCidade);
            Controls.Add(txtLogradouro);
            Controls.Add(txtCEP);
            Controls.Add(txtCPF);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lblWhatsApp);
            Controls.Add(lblTelefone);
            Controls.Add(lblEstado);
            Controls.Add(lblCidade);
            Controls.Add(lblBairro);
            Controls.Add(lblNumero);
            Controls.Add(lblLogradouro);
            Controls.Add(lblCEP);
            Controls.Add(lblEmail);
            Controls.Add(lblCPF);
            Controls.Add(lblNome);
            Name = "FormCadastroClientes";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblCPF;
        private Label lblEmail;
        private Label lblCEP;
        private Label lblCidade;
        private Label lblBairro;
        private Label lblNumero;
        private Label lblLogradouro;
        private Label lblWhatsApp;
        private Label lblTelefone;
        private Label lblEstado;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCPF;
        private TextBox txtCEP;
        private TextBox txtLogradouro;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private TextBox txtEstado;
        private TextBox txtWhatsApp;
        private TextBox txtTelefone;
        private Button btnCadastrar;
        private Button btnAtualizar;
        private Button btnExcluir;
    }
}