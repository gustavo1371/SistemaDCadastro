namespace SistemaDCadastro
{
    partial class FormCadastroPedidos
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
            lblCPF = new Label();
            txtCPF = new TextBox();
            btnBuscarCliente = new Button();
            label0 = new Label();
            lblNomeCliente = new Label();
            lblCodigoProduto = new Label();
            txtCodigoProduto = new TextBox();
            lblQuantidade = new Label();
            txtQuantidade = new TextBox();
            btnAdicionarProduto = new Button();
            listViewProdutos = new ListView();
            lblTotalPedido0 = new Label();
            lblTotalPedido = new Label();
            btnSalvarPedido = new Button();
            SuspendLayout();
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(12, 9);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(83, 15);
            lblCPF.TabIndex = 0;
            lblCPF.Text = "Insira seu CPF:";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(12, 27);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(246, 23);
            txtCPF.TabIndex = 1;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(273, 26);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(85, 24);
            btnBuscarCliente.TabIndex = 2;
            btnBuscarCliente.Text = "Buscar...";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.Location = new Point(12, 65);
            label0.Name = "label0";
            label0.Size = new Size(50, 15);
            label0.TabIndex = 3;
            label0.Text = "Cliente: ";
            // 
            // lblNomeCliente
            // 
            lblNomeCliente.AutoSize = true;
            lblNomeCliente.Location = new Point(68, 65);
            lblNomeCliente.Name = "lblNomeCliente";
            lblNomeCliente.Size = new Size(16, 15);
            lblNomeCliente.TabIndex = 4;
            lblNomeCliente.Text = "...";
            // 
            // lblCodigoProduto
            // 
            lblCodigoProduto.AutoSize = true;
            lblCodigoProduto.Location = new Point(12, 102);
            lblCodigoProduto.Name = "lblCodigoProduto";
            lblCodigoProduto.Size = new Size(112, 15);
            lblCodigoProduto.TabIndex = 5;
            lblCodigoProduto.Text = "Código do Produto:";
            // 
            // txtCodigoProduto
            // 
            txtCodigoProduto.Location = new Point(12, 120);
            txtCodigoProduto.Name = "txtCodigoProduto";
            txtCodigoProduto.Size = new Size(246, 23);
            txtCodigoProduto.TabIndex = 6;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(12, 146);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(72, 15);
            lblQuantidade.TabIndex = 7;
            lblQuantidade.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(12, 164);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(112, 23);
            txtQuantidade.TabIndex = 8;
            // 
            // btnAdicionarProduto
            // 
            btnAdicionarProduto.Location = new Point(141, 162);
            btnAdicionarProduto.Name = "btnAdicionarProduto";
            btnAdicionarProduto.Size = new Size(117, 24);
            btnAdicionarProduto.TabIndex = 9;
            btnAdicionarProduto.Text = "Adicionar Produto";
            btnAdicionarProduto.UseVisualStyleBackColor = true;
            btnAdicionarProduto.Click += btnAdicionarProduto_Click;
            // 
            // listViewProdutos
            // 
            listViewProdutos.Location = new Point(288, 120);
            listViewProdutos.Name = "listViewProdutos";
            listViewProdutos.Size = new Size(240, 169);
            listViewProdutos.TabIndex = 10;
            listViewProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // lblTotalPedido0
            // 
            lblTotalPedido0.AutoSize = true;
            lblTotalPedido0.Location = new Point(12, 203);
            lblTotalPedido0.Name = "lblTotalPedido0";
            lblTotalPedido0.Size = new Size(75, 15);
            lblTotalPedido0.TabIndex = 11;
            lblTotalPedido0.Text = "Total Pedido:";
            // 
            // lblTotalPedido
            // 
            lblTotalPedido.AutoSize = true;
            lblTotalPedido.Location = new Point(93, 203);
            lblTotalPedido.Name = "lblTotalPedido";
            lblTotalPedido.Size = new Size(16, 15);
            lblTotalPedido.TabIndex = 12;
            lblTotalPedido.Text = "...";
            // 
            // btnSalvarPedido
            // 
            btnSalvarPedido.Location = new Point(12, 243);
            btnSalvarPedido.Name = "btnSalvarPedido";
            btnSalvarPedido.Size = new Size(117, 46);
            btnSalvarPedido.TabIndex = 13;
            btnSalvarPedido.Text = "Salvar Pedido";
            btnSalvarPedido.UseVisualStyleBackColor = true;
            // 
            // FormCadastroPedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvarPedido);
            Controls.Add(lblTotalPedido);
            Controls.Add(lblTotalPedido0);
            Controls.Add(listViewProdutos);
            Controls.Add(btnAdicionarProduto);
            Controls.Add(txtQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(txtCodigoProduto);
            Controls.Add(lblCodigoProduto);
            Controls.Add(lblNomeCliente);
            Controls.Add(label0);
            Controls.Add(btnBuscarCliente);
            Controls.Add(txtCPF);
            Controls.Add(lblCPF);
            Name = "FormCadastroPedidos";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCPF;
        private TextBox txtCPF;
        private Button btnBuscarCliente;
        private Label label0;
        private Label lblNomeCliente;
        private Label lblCodigoProduto;
        private TextBox txtCodigoProduto;
        private Label lblQuantidade;
        private TextBox txtQuantidade;
        private Button btnAdicionarProduto;
        private ListView listViewProdutos;
        private Label lblTotalPedido0;
        private Label lblTotalPedido;
        private Button btnSalvarPedido;
    }
}