using ProjetoPi.Domínio;

namespace ProjetoPi
{
    public partial class CriarCliente : Form
    {
        private Cliente? cliente;
       
        public CriarCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente = new Cliente() //popular todos os dados
            {
                nome = textNome.Text,
                telefone = textTelefone.Text,
                email = textEmail.Text,
                cpf = textCpf.Text,
                cep = textCep.Text,
            };


            if (!cliente.ValidarCadastro()) // trocar validação unica por metodo com todas validacoes
            {
                labelErro.Text = "nasceu";
                return;
            }
            labelErro.Text = "cadastro";
            
        }
    }
}
