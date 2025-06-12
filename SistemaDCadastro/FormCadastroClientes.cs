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
    public partial class FormCadastroClientes : Form
    {
        string caminhoArquivo = @"C:\Users\Gustavo\source\repos\SistemaDCadastro\SistemaDCadastro\clientes.csv";

        public FormCadastroClientes()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string linha = txtCPF.Text + "," + txtNome.Text + "," + txtEmail.Text + "," + txtCEP.Text + "," + txtLogradouro.Text + "," + txtNumero.Text + "," + txtBairro.Text + "," +txtCidade.Text + "," + txtEstado.Text + "," + txtTelefone.Text + "," + txtWhatsApp.Text;

            File.AppendAllText("clientes.csv", linha + Environment.NewLine);
            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!File.Exists("clientes.csv")) return;

            string cpf = txtCPF.Text;
            string[] linhas = File.ReadAllLines("clientes.csv");
            string[] novasLinhas = new string[linhas.Length];

            for (int i = 0; i < linhas.Length; i++)
            {
                if (linhas[i].StartsWith(cpf + ","))
                {
                    novasLinhas[i] = cpf + "," + txtNome.Text + "," + txtEmail.Text + "," + txtCEP.Text + "," + txtLogradouro.Text + "," + txtNumero.Text + "," + txtBairro.Text + "," +txtCidade.Text + "," + txtEstado.Text + "," + txtTelefone.Text + "," + txtWhatsApp.Text;
                }
                else
                {
                    novasLinhas[i] = linhas[i];
                }
            }

            File.WriteAllLines("clientes.csv", novasLinhas);
            MessageBox.Show("Cliente atualizado com sucesso!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!File.Exists("clientes.csv")) return;

            string cpf = txtCPF.Text;
            string[] linhas = File.ReadAllLines("clientes.csv");
            File.WriteAllText("clientes.csv", "");

            foreach (string linha in linhas)
            {
                if (!linha.StartsWith(cpf + ","))
                {
                    File.AppendAllText("clientes.csv", linha + Environment.NewLine);
                }
            }

            MessageBox.Show("Cliente excluído com sucesso!");
        }
    }
}
