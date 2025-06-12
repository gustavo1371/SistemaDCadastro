using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDCadastro
{
    public partial class FormCadastroClientes : Form
    {
        string caminhoArquivo = @"C:\Users\Gustavo\source\repos\SistemaDCadastro\SistemaDCadastro\clientes.csv";

        public FormCadastroClientes()
        {
            InitializeComponent();
            
            txtCEP.Leave += txtCEP_Leave;
        }

        private async void txtCEP_Leave(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Trim().Replace("-", "");

            if (cep.Length != 8)
            {
                MessageBox.Show("CEP inválido. Digite os 8 números do CEP.");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();
                    var endereco = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

                    if (endereco.ContainsKey("erro"))
                    {
                        MessageBox.Show("CEP não encontrado.");
                        return;
                    }

                    txtLogradouro.Text = endereco.GetValueOrDefault("logradouro", "");
                    txtBairro.Text = endereco.GetValueOrDefault("bairro", "");
                    txtCidade.Text = endereco.GetValueOrDefault("localidade", "");
                    txtEstado.Text = endereco.GetValueOrDefault("uf", "");
                }
                catch
                {
                    MessageBox.Show("Erro ao buscar o CEP. Verifique sua conexão.");
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string linha = txtCPF.Text + "," + txtNome.Text + "," + txtEmail.Text + "," + txtCEP.Text + "," + txtLogradouro.Text + "," + txtNumero.Text + "," + txtBairro.Text + "," + txtCidade.Text + "," + txtEstado.Text + "," + txtTelefone.Text + "," + txtWhatsApp.Text;

            File.AppendAllText(caminhoArquivo, linha + Environment.NewLine);
            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(caminhoArquivo)) return;

            string cpf = txtCPF.Text;
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            string[] novasLinhas = new string[linhas.Length];

            for (int i = 0; i < linhas.Length; i++)
            {
                if (linhas[i].StartsWith(cpf + ","))
                {
                    novasLinhas[i] = cpf + "," + txtNome.Text + "," + txtEmail.Text + "," + txtCEP.Text + "," + txtLogradouro.Text + "," + txtNumero.Text + "," + txtBairro.Text + "," + txtCidade.Text + "," + txtEstado.Text + "," + txtTelefone.Text + "," + txtWhatsApp.Text;
                }
                else
                {
                    novasLinhas[i] = linhas[i];
                }
            }

            File.WriteAllLines(caminhoArquivo, novasLinhas);
            MessageBox.Show("Cliente atualizado com sucesso!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!File.Exists(caminhoArquivo)) return;

            string cpf = txtCPF.Text;
            string[] linhas = File.ReadAllLines(caminhoArquivo);
            File.WriteAllText(caminhoArquivo, "");

            foreach (string linha in linhas)
            {
                if (!linha.StartsWith(cpf + ","))
                {
                    File.AppendAllText(caminhoArquivo, linha + Environment.NewLine);
                }
            }

            MessageBox.Show("Cliente excluído com sucesso!");
        }
    }
}
