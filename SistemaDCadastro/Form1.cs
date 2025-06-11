namespace SistemaDCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
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

           
            

           


        }
    }
}
