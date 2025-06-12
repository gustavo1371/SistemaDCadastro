using System;
using System.IO;
using System.Windows.Forms;

namespace SistemaDCadastro
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "ADMIN" && senha == "123")
            {
                MessageBox.Show("Login ADMIN bem-sucedido!");
                return;
            }

            if (verificarUsuario(usuario, senha))
            {
                MessageBox.Show("Login efetuado com êxito!");
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }

        private bool verificarUsuario(string usuario, string senha)
        {
            string caminho = "usuarios.csv";

            if (!File.Exists(caminho))
            {
                MessageBox.Show("Arquivo de usuários não encontrado.");
                return false;
            }

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(',');

                if (dados.Length >= 2)
                {
                    string user = dados[0].Trim();
                    string pass = dados[1].Trim();

                    if (usuario == user && senha == pass)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

    }
}
