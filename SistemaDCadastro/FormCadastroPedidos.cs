using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SistemaDCadastro
{
    public partial class FormCadastroPedidos : Form
    {
        private string clienteNome = "";
        private List<PedidoItem> itensPedido = new List<PedidoItem>();
        private decimal totalPedido = 0;

        public FormCadastroPedidos()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text;
            clienteNome = BuscarNomeClientePorCPF(cpf);
            if (string.IsNullOrEmpty(clienteNome))
            {
                MessageBox.Show("Cliente não encontrado.");
                lblNomeCliente.Text = "";
            }
            else
            {
                lblNomeCliente.Text = clienteNome;
            }
        }

        private string BuscarNomeClientePorCPF(string cpf)
        {
            if (!File.Exists("clientes.csv")) return "";

            string[] linhas = File.ReadAllLines("clientes.csv");
            foreach (string linha in linhas)
            {
                if (linha.StartsWith(cpf + ","))
                {
                    string[] dados = linha.Split(',');
                    if (dados.Length >= 2) 
                        return dados[1];
                }
            }
            return "";
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            string codigoProduto = txtCodigoProduto.Text;
            if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }

            Produto produto = BuscarProdutoPorCodigo(codigoProduto);
            if (produto == null)
            {
                MessageBox.Show("Produto não encontrado.");
                return;
            }

            decimal totalItem = produto.Preco * quantidade;
            itensPedido.Add(new PedidoItem { CodigoProduto = codigoProduto, NomeProduto = produto.Nome, Quantidade = quantidade, Total = totalItem });
            totalPedido += totalItem;

            AtualizarListaProdutos();
            AtualizarTotalPedido();

            txtCodigoProduto.Clear();
            txtQuantidade.Clear();
        }

        private Produto BuscarProdutoPorCodigo(string codigo)
        {
            if (!File.Exists("produtos.csv")) return null;

            string[] linhas = File.ReadAllLines("produtos.csv");
            foreach (string linha in linhas)
            {
                if (linha.StartsWith(codigo + ","))
                {
                    string[] dados = linha.Split(',');
                    if (dados.Length >= 3)
                    {
                        string nome = dados[1];
                        if (decimal.TryParse(dados[2], out decimal preco))
                        {
                            return new Produto { Codigo = codigo, Nome = nome, Preco = preco };
                        }
                    }
                }
            }
            return null;
        }

        private void AtualizarListaProdutos()
        {
            listViewProdutos.Items.Clear();
            foreach (var item in itensPedido)
            {
                var listItem = new ListViewItem(item.CodigoProduto);
                listItem.SubItems.Add(item.NomeProduto);
                listItem.SubItems.Add(item.Quantidade.ToString());
                listItem.SubItems.Add(item.Total.ToString("F2"));
                listViewProdutos.Items.Add(listItem);
            }
        }

        private void AtualizarTotalPedido()
        {
            lblTotalPedido.Text = "Total: R$ " + totalPedido.ToString("F2");
        }

        private void btnSalvarPedido_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(clienteNome))
            {
                MessageBox.Show("Busque um cliente válido antes de salvar o pedido.");
                return;
            }
            if (itensPedido.Count == 0)
            {
                MessageBox.Show("Adicione produtos ao pedido antes de salvar.");
                return;
            }

            string cpf = txtCPF.Text;
            string codigoPedido = DateTime.Now.Ticks.ToString(); 

            string linhaPedido = $"{codigoPedido},{cpf},{totalPedido:F2}";

            File.AppendAllText("pedidos.csv", linhaPedido + Environment.NewLine);

            foreach (var item in itensPedido)
            {
                string linhaItem = $"{codigoPedido},{item.CodigoProduto},{item.NomeProduto},{item.Quantidade},{item.Total:F2}";
                File.AppendAllText("itensPedido.csv", linhaItem + Environment.NewLine);
            }

            MessageBox.Show("Pedido salvo com sucesso!");

            txtCPF.Clear();
            lblNomeCliente.Text = "";
            itensPedido.Clear();
            listViewProdutos.Items.Clear();
            totalPedido = 0;
            AtualizarTotalPedido();
        }
    }

    public class Produto
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }

    public class PedidoItem
    {
        public string CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; set; }
    }
}
