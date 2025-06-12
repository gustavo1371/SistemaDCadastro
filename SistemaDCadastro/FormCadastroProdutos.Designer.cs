namespace SistemaDCadastro
{
    partial class FormCadastroProdutos
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
            lblCodigo = new Label();
            lblNomeProduto = new Label();
            lblPreco = new Label();
            lblDescricao = new Label();
            txtCodigo = new TextBox();
            txtNomeProduto = new TextBox();
            textBox3 = new TextBox();
            txtDescricao = new TextBox();
            btnCadastrar = new Button();
            btnAtualizar = new Button();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(79, 42);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(79, 102);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(106, 15);
            lblNomeProduto.TabIndex = 1;
            lblNomeProduto.Text = "Nome do Produto:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(79, 164);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(43, 15);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "Preço: ";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(79, 225);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Descrição:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(79, 60);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 4;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(79, 120);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(100, 23);
            txtNomeProduto.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(79, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(79, 243);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(100, 23);
            txtDescricao.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(243, 59);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(108, 58);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(243, 142);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(108, 58);
            btnAtualizar.TabIndex = 9;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(243, 225);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(108, 58);
            btnExcluir.TabIndex = 10;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormCadastroProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluir);
            Controls.Add(btnAtualizar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtDescricao);
            Controls.Add(textBox3);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtCodigo);
            Controls.Add(lblDescricao);
            Controls.Add(lblPreco);
            Controls.Add(lblNomeProduto);
            Controls.Add(lblCodigo);
            Name = "FormCadastroProdutos";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNomeProduto;
        private Label lblPreco;
        private Label lblDescricao;
        private TextBox txtCodigo;
        private TextBox txtNomeProduto;
        private TextBox textBox3;
        private TextBox txtDescricao;
        private Button btnCadastrar;
        private Button btnAtualizar;
        private Button btnExcluir;
    }
}