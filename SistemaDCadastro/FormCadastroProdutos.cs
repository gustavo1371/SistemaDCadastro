using System;
using System.IO;
using System.Windows.Forms;

namespace SistemaDCadastro
{
    public partial class FormCadastroProdutos : Form
    {
        public FormCadastroProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nome = txtNomeProduto.Text;
            string preco = txtPreco.Text;
            string descricao = txtDescricao.Text;

            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(preco))
            {
                MessageBox.Show("Preencha os campos Código, Nome e Preço.");
                return;
            }

            if (!File.Exists("produtos.csv"))
            {
                File.WriteAllText("produtos.csv", "Codigo,Nome,Preco,Descricao" + Environment.NewLine);
            }

            string[] linhas = File.ReadAllLines("produtos.csv");

            // Evita duplicar código
            foreach (string linha in linhas)
            {
                if (linha.StartsWith(codigo + ","))
                {
                    MessageBox.Show("Código já existe. Use Atualizar para modificar.");
                    return;
                }
            }

            string novaLinha = codigo + "," + nome + "," + preco + "," + descricao;
            File.AppendAllText("produtos.csv", novaLinha + Environment.NewLine);

            MessageBox.Show("Produto cadastrado com sucesso!");

            txtCodigo.Clear();
            txtNomeProduto.Clear();
            txtPreco.Clear();
            txtDescricao.Clear();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!File.Exists("produtos.csv"))
            {
                MessageBox.Show("Arquivo de produtos não encontrado.");
                return;
            }

            string codigo = txtCodigo.Text;
            string nome = txtNomeProduto.Text;
            string preco = txtPreco.Text;
            string descricao = txtDescricao.Text;

            string[] linhas = File.ReadAllLines("produtos.csv");
            File.WriteAllText("produtos.csv", "Codigo,Nome,Preco,Descricao" + Environment.NewLine);

            foreach (string linha in linhas)
            {
                if (linha.StartsWith(codigo + ","))
                {
                    string novaLinha = codigo + "," + nome + "," + preco + "," + descricao;
                    File.AppendAllText("produtos.csv", novaLinha + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText("produtos.csv", linha + Environment.NewLine);
                }
            }

            MessageBox.Show("Produto atualizado com sucesso!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!File.Exists("produtos.csv"))
            {
                MessageBox.Show("Arquivo de produtos não encontrado.");
                return;
            }

            string codigo = txtCodigo.Text;
            string[] linhas = File.ReadAllLines("produtos.csv");
            File.WriteAllText("produtos.csv", "Codigo,Nome,Preco,Descricao" + Environment.NewLine);

            foreach (string linha in linhas)
            {
                if (!linha.StartsWith(codigo + ","))
                {
                    File.AppendAllText("produtos.csv", linha + Environment.NewLine);
                }
            }

            MessageBox.Show("Produto excluído com sucesso!");

            txtCodigo.Clear();
            txtNomeProduto.Clear();
            txtPreco.Clear();
            txtDescricao.Clear();
        }
    }
}
