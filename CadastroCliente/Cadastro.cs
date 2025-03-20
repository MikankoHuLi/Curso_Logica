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
                logradouro = "The Last Drop Avenue",numero = "01", complemento = "",bairro = "Vielas",municipio = "Vielas",estado = "Zaun", cep = "08987789"
            };

            EnderecoCliente endereco02 = new EnderecoCliente()
            {
                logradouro = "Kiramman Manor", numero = "69",complemento = "",bairro = "Capital", municipio = "Capital", estado = "Piltover",cep = "08987666"
            };

            Cliente jinx = new Cliente()
            {
                id = 01, nome = "Powder",dataNascimento = "04/07/2000",telefone = "(11)90588-8408",email = "jnx@gmail.com",nomeSocial = "Jinx",estrangeiro = true,
                endereco = endereco01,genero = GeneroCliente.Feminino,etnia = EtniaCliente.Branco,tipo = TipoCliente.PF
            };
            clientes.Add(jinx);

            Cliente vi = new Cliente()
            {
                id = 02,nome = "Violet",dataNascimento = "19/04/1995",telefone = "(11)97788-8408",email = "vi@gmail.com",nomeSocial = "Vi",estrangeiro = true,
                endereco = endereco02, genero = GeneroCliente.Feminino,etnia = EtniaCliente.Branco,tipo = TipoCliente.PF
            };
            clientes.Add(vi);

            Cliente cupcake = new Cliente()
            {
                id = 03, nome = "Caitlyn", dataNascimento = "09/07/1994",telefone = "(11)95688-8408",email = "cupcake@gmail.com",nomeSocial = "Cupcake", estrangeiro = false,
                endereco = endereco02, genero = GeneroCliente.Feminino,etnia = EtniaCliente.Amarelo,tipo = TipoCliente.PF
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
            if (!textNome.Text.Any(char.IsWhiteSpace) || textNome.Text.Any(char.IsNumber) || textNome.Text.Any(char.IsPunctuation))
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
      
            if (textTelefone.Text.Length < 14)
            {
                return false;
            }

            if (textTelefone.Text.Any(char.IsWhiteSpace))
            {
                return false;
            }
         
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].telefone == textTelefone.Text)
                {
                    return false;
                }
            }
            return true;
        }
        private bool ValidarNascimento()
        { 
            if (ValorBranco(textNascimento.Text))
            {
                return false;
            }

            if (textNascimento.Text.Length < 10)
            {
                return false;
            }

            if (textNascimento.Text.Contains(" "))
            {
                return false;
            }
            return true;
        }
        private bool ValidarEmail()
        {
            if (ValorBranco(textEmail.Text))
            {
                return false;
            }
            if (textEmail.Text.Any(char.IsWhiteSpace) || !textEmail.Text.Contains("@") || !textEmail.Text.Contains("."))
            {
                return false;
            }
            
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].email == textEmail.Text)
                {
                    return false;
                }
            }
            return true;
        }
        private bool ValidarNomeSocial()
        {
            if (textNomeSocial.Text.Any(char.IsNumber) || textNomeSocial.Text.Any(char.IsPunctuation))
            {
                return false;
            }

            return true;
        }
        private bool ValidarTipo()
        {
            if (!radioPF.Checked && !radioPJ.Checked)
            {
                return false;
            }
           
            return true;
        }
        private bool ValidarGenero()
        {
            if (textGenero.SelectedItem == null)
            {
                return false;
            }


            return true;
        }
        private bool ValidarEtnia()
        {
            if (textEtnia.SelectedItem == null)
            {
                return false;
            }


            return true;
        }
        private bool ValidarRua()
        {
            if (ValorBranco(textRua.Text))
            {
                return false;
            }
            if (textRua.Text.Any(char.IsPunctuation))
            {
                return false;
            }

            return true;
        }
        private bool ValidarNumeroCasa()
        {
            if (ValorBranco(textNumeroCasa.Text))
            {
                return false;
            }
            if (textNumeroCasa.Text.Any(char.IsPunctuation) || textNumeroCasa.Text.All(char.IsLetter))
            {
                return false;
            }

            return true;
        }
        private bool ValidarBairro()
        {
            if (ValorBranco(textBairro.Text))
            {
                return false;
            }
            if (textBairro.Text.Any(char.IsPunctuation) || textBairro.Text.All(char.IsNumber))
            {
                return false;
            }

            return true;
        }
        private bool ValidarMunicipio()
        {
            if (ValorBranco(textMunicipio.Text))
            {
                return false;
            }
            if (textMunicipio.Text.Any(char.IsPunctuation) || textMunicipio.Text.Any(char.IsNumber))
            {
                return false;
            }

            return true;
        }
        private bool ValidarEstado()
        {
            if (textEstado.SelectedItem == null)
            {
                return false;
            }


            return true;
        }
        private bool ValidarCEP()
        {
            if (ValorBranco(textCEP.Text))
            {
                return false;
            }
            if (textCEP.Text.Any(char.IsWhiteSpace))
            {
                return false;
            }
            if (textCEP.Text.Length < 9)
            {
                return false;
            }

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
            if (!ValidarNascimento())
            {
                return false;
            }
            if (!ValidarEmail())
            {
                return false;
            }
            if (!ValidarNomeSocial())
            {
                return false;
            }
            if (!ValidarGenero())
            {
                return false;
            }
            if (!ValidarEtnia())
            {
                return false;
            }
            if (!ValidarRua())
            {
                return false;
            }
            if (!ValidarNumeroCasa())
            {
                return false;
            }
            if (!ValidarBairro())
            {
                return false;
            }
            if (!ValidarMunicipio())
            {
                return false;
            }
            if (!ValidarEstado())
            {
                return false;
            }
            if (!ValidarCEP())
            {
                return false;
            }
            if (!ValidarTipo())
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
