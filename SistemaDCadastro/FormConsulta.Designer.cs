namespace SistemaDCadastro
{
    partial class FormConsulta
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
            btnBuscar = new Button();
            button2 = new Button();
            txtCPF = new TextBox();
            label1 = new Label();
            lstPedidos = new ListView();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 65);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 55);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(112, 65);
            button2.Name = "button2";
            button2.Size = new Size(94, 55);
            button2.TabIndex = 1;
            button2.Text = "btnVerTodos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(12, 27);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(194, 23);
            txtCPF.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "CPF:";
            // 
            // lstPedidos
            // 
            lstPedidos.Location = new Point(230, 27);
            lstPedidos.Name = "lstPedidos";
            lstPedidos.Size = new Size(194, 179);
            lstPedidos.TabIndex = 4;
            lstPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // FormConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 237);
            Controls.Add(lstPedidos);
            Controls.Add(label1);
            Controls.Add(txtCPF);
            Controls.Add(button2);
            Controls.Add(btnBuscar);
            Name = "FormConsulta";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button button2;
        private TextBox txtCPF;
        private Label label1;
        private ListView lstPedidos;
    }
}