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
    public partial class FormConsulta : Form
    {
        private string cpf = "";
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cpf = txtCPF.Text.Trim();
            lstPedidos.Items.Clear();

            if (string.IsNullOrEmpty(cpf))
            {
                cpf = txtCPF.Text.Trim();
                lstPedidos.Items.Clear();

                if (string.IsNullOrEmpty(cpf))
                {
                    MessageBox.Show("Informe o CPF.");
                    return;
                }

                if (!File.Exists("pedidos.csv"))
                {
                    MessageBox.Show("Arquivo de pedidos não encontrado.");
                    return;
                }

                string[] linhas = File.ReadAllLines("pedidos.csv");
                foreach (string linha in linhas)
                {
                    if (linha.StartsWith(cpf + ","))
                    {
                        lstPedidos.Items.Add(linha);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstPedidos.Items.Clear();

            if (!File.Exists("pedidos.csv"))
            {
                MessageBox.Show("Arquivo de pedidos não encontrado.");
                return;
            }

            string[] linhas = File.ReadAllLines("pedidos.csv");
            foreach (string linha in linhas)
            {
                lstPedidos.Items.Add(linha);
            }
        }
    }
}
