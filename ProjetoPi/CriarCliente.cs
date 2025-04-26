using ProjetoPi.Domínio;

namespace ProjetoPi
{
    public partial class CriarCliente : Form
    {
        private Cliente? cliente;

        public CriarCliente()
        {
            InitializeComponent();
            //telefone,cep,cpf poderiam ser masked opcional e converter na interface
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

            if (!cliente.VALIDARCADASTRO()) // trocar validação unica por metodo com todas validacoes
            {
                labelErro.Text = "invalido";
                return;
            }
            labelErro.Text = "cadastro";

            cliente.CriarClientes(cliente);

        }

        private void CriarCliente_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            menu.Show();
            this.Hide();
        }
    }
}
