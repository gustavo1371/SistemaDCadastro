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
    public partial class FormCadastroUsuarios : Form
    {
        string caminhoArquivo = @"C:\Users\Gustavo\source\repos\SistemaDCadastro\SistemaDCadastro\usuarios.csv";

        string usuarioLogado = "ADMIN";
        public FormCadastroUsuarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (usuarioLogado != "ADMIN")
            {
                MessageBox.Show("Somente o ADMIN pode cadastrar usuários!");
                return;
            }

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Preencha os campos.");
                return;
            }

            File.AppendAllText(caminhoArquivo, $"{usuario},{senha}{Environment.NewLine}");
            MessageBox.Show("Usuário cadastrado com sucesso!");
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();

            if (usuarioLogado != "ADMIN")
            {
                MessageBox.Show("Somente o ADMIN pode excluir usuários!");
                return;
            }

            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo de usuários não encontrado.");
                return;
            }

            string[] linhas = File.ReadAllLines(caminhoArquivo);
            bool encontrado = false;

            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                foreach (string linha in linhas)
                {
                    if (!linha.StartsWith(usuario + ","))
                    {
                        sw.WriteLine(linha);
                    }
                    else
                    {
                        encontrado = true;
                    }
                }
            }

            if (encontrado)
                MessageBox.Show("Usuário excluído com sucesso!");
            else
                MessageBox.Show("Usuário não encontrado.");

            txtUsuario.Clear();
            txtSenha.Clear();
        }
    }
}
