using System.Net.Sockets;

namespace CadastroCliente
{
    public partial class Cadastro : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        public Cadastro()
        {
            InitializeComponent();

            EnderecoCliente endereco01 = new EnderecoCliente()
            {
                logradouro = "The Last Drop Avenue",
                numero = "01",
                complemento = "",
                bairro = "Vielas",
                municipio = "Vielas",
                estado = "Zaun",
                cep = "08987789"
            };

            EnderecoCliente endereco02 = new EnderecoCliente()
            {
                logradouro = "Kiramman Manor",
                numero = "69",
                complemento = "",
                bairro = "Capital",
                municipio = "Capital",
                estado = "Piltover",
                cep = "08987666"
            };

            Cliente jinx = new Cliente()
            {
                id = 01,
                nome = "Powder",
                dataNascimento = "04/07/2000",
                telefone = "905888408",
                email = "jnx@gmail.com",
                nomeSocial = "Jinx",
                estrangeiro = true,
                endereco = endereco01,
                genero = GeneroCliente.Feminino,
                etnia = EtniaCliente.Branco,
                tipo = TipoCliente.PF
            };
            clientes.Add(jinx);

            Cliente vi = new Cliente()
            {
                id = 02,
                nome = "Violet",
                dataNascimento = "19/04/1995",
                telefone = "945895612",
                email = "vi@gmail.com",
                nomeSocial = "Vi",
                estrangeiro = true,
                endereco = endereco02,
                genero = GeneroCliente.Feminino,
                etnia = EtniaCliente.Branco,
                tipo = TipoCliente.PF
            };
            clientes.Add(vi);

            Cliente cupcake = new Cliente()
            {
                id = 03,
                nome = "Caitlyn",
                dataNascimento = "09/07/1994",
                telefone = "947331285",
                email = "cupcake@gmail.com",
                nomeSocial = "Cupcake",
                estrangeiro = false,
                endereco = endereco02,
                genero = GeneroCliente.Feminino,
                etnia = EtniaCliente.Amarelo,
                tipo = TipoCliente.PF
            };
            clientes.Add(cupcake);

            //clientes.Add(new Cliente() {id = 03,nome = "Caitlyn", dataNascimento = "09/07/1994", telefone = "947331285", email ="cupcake@gmail.com",
            //nomeSocial = "Cupcake", estrangeiro = false, endereco = endereco02, genero = GeneroCliente.Feminino, etnia = EtniaCliente.Amarelo, tipo = TipoCliente.PF});
            //dessa forma o cliente anonimo


        }
        private bool ValorBranco(string valor)
        {
            return string.IsNullOrWhiteSpace(valor);
        }

        private bool ValidarNome()
        {
            if (ValorBranco(textNome.Text))
            {
                return false;
            }
            if (!textNome.Text.Any(char.IsWhiteSpace))
            {
                return false;
            }

            return true;
        }
        private bool ValidarTelefone()
        {
            if (ValorBranco(textTelefone.Text))
            {
                return false;
            }
      
            if (!textTelefone.Text.Any(char.IsNumber))
            {
                return false;
            }

            //colocar nao deixar parte em branco
            return true;
        }


        private bool ValidarCadastro()
        {
            if (!ValidarNome())
            {
                return false;
            }
            if (!ValidarTelefone())
            {
                return false;
            }

            return true;
        }

        private void butCadastro_Click(object sender, EventArgs e)
        {
            if (!ValidarCadastro())
            {
                cadastrolabel.Text = "Não foi possível cadastrar";
                cadastrolabel.ForeColor = Color.Red;

            }
            else
            {
                cadastrolabel.Text = "Cadastrado com sucesso";
                cadastrolabel.ForeColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastrolabel.Text = "";
        }
    }
}
