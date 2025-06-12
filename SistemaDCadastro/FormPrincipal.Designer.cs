namespace SistemaDCadastro
{
    partial class FormPrincipal
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
            btnClientes = new Button();
            btnProdutos = new Button();
            btnPedidos = new Button();
            btnUsuarios = new Button();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(43, 37);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(142, 58);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(43, 101);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(142, 58);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Location = new Point(43, 165);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(142, 58);
            btnPedidos.TabIndex = 2;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(43, 229);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(142, 58);
            btnUsuarios.TabIndex = 3;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 362);
            Controls.Add(btnUsuarios);
            Controls.Add(btnPedidos);
            Controls.Add(btnProdutos);
            Controls.Add(btnClientes);
            Name = "FormPrincipal";
            Text = "Tela Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProdutos;
        private Button btnPedidos;
        private Button btnUsuarios;
    }
}