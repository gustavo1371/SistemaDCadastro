using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDCadastro
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCadastroClientes form = new FormCadastroClientes();
            form.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormCadastroProdutos form = new FormCadastroProdutos();
            form.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormCadastroPedidos form = new FormCadastroPedidos();
            form.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormCadastroUsuarios form = new FormCadastroUsuarios();
            form.Show();
        }
    }
}
