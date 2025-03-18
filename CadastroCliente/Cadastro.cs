namespace CadastroCliente
{
    public partial class Cadastro : Form
    {    
        List<Cliente> clientes;
        public Cadastro()
        {
            InitializeComponent();

            EnderecoCliente endereco01 = new EnderecoCliente(){logradouro = "The Last Drop Avenue",numero = "01",complemento = "",bairro = "Vielas",municipio = "Vielas",
            estado = "Zaun",cep = "08987789"};

            EnderecoCliente endereco02 = new EnderecoCliente(){logradouro = "Kiramman Manor",numero = "69",complemento = "",bairro = "Capital",municipio = "Capital",
            estado = "Piltover",cep = "08987666"};

            EnderecoCliente endereco03 = new EnderecoCliente(){logradouro = "Kiramman Manor",numero = "69",complemento = "",bairro = "Capital",municipio = "Capital",
            estado = "Piltover",cep = "08987666"};

            clientes.Add(new Cliente() {id = 01,nome = "Powder", dataNascimento = "04/07/2000", telefone = "905888408", email ="jnx@gmail.com",
            nomeSocial = "Jinx", estrangeiro = true, endereco = endereco01, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Branco, tipo = TipoCliente.PF});

            clientes.Add(new Cliente() {id = 02,nome = "Violet", dataNascimento = "19/04/1995", telefone = "945895612", email ="vi@gmail.com",
            nomeSocial = "Vi", estrangeiro = true, endereco = endereco02, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Branco, tipo = TipoCliente.PF});

            clientes.Add(new Cliente() {id = 03,nome = "Caitlyn", dataNascimento = "09/07/1994", telefone = "947331285", email ="cupcake@gmail.com",
            nomeSocial = "Cupcake", estrangeiro = false, endereco = endereco03, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Amarelo, tipo = TipoCliente.PF});


        }

    }
}
