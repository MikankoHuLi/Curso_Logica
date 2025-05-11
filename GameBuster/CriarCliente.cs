using GameBuster.Domínio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfaceProjeto
{
    public partial class CriarCliente : Form
    {
        private Cliente cliente = new Cliente();
        private Endereco endereco = new Endereco();
        public CriarCliente()
        {
            InitializeComponent();
        }

        private void buttonVoltarMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            endereco = new Endereco()
            {
                logradouro = textLogradouro.Text,
                numero = textNumero.Text,
                complemento = textComplemento.Text,
                bairro = textBairro.Text,
                cep = textCep.Text,
                cidade = textCidade.Text
            };

            if (!cliente.ValidarNascimento(maskedTextBoxDataDeNascimento.Text) || maskedTextBoxDataDeNascimento.Text == "  /  /")
            {
                labelErro.Text = "Data de Nascimento Inválida";
                labelErro.ForeColor = Color.Red;
                return;
            }

            cliente = new Cliente()
            {

                nome = textNome.Text,
                cpf = textCpf.Text,
                email = textEmail.Text,
                telefone = maskTextTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", ""),
                genero = (Genero)comboBoxGenero.SelectedIndex,
                data_de_nascimento = Convert.ToDateTime(maskedTextBoxDataDeNascimento.Text)
            };
            if (!ValidarCadastro())
            {
                return;
            }
            labelErro.Text = "Cadastro realizado com sucesso";
            labelErro.ForeColor = Color.Green;

            cliente.CriarClientes(cliente, endereco);
            LimparFormulario();
        }

        private bool ValidarCadastro()
        {

            if (!ValidarCliente() || !ValidarEndereco())
            {
                return false;
            }

            return true;
        }

        private bool ValidarCliente()
        {


            if (!cliente.ValidarNome())
            {
                labelErro.Text = "Nome Inválido";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            if (!cliente.ValidarEmail())
            {
                labelErro.Text = "Email Inválido";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!EmailUnico())
            {
                labelErro.Text = "Email já cadastrado";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            if (!cliente.ValidarGenero())
            {
                labelErro.Text = "Selecione um gênero";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            if (!cliente.ValidarCpf())
            {
                labelErro.Text = "CPF Inválido";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!CpfUnico())
            {
                labelErro.Text = "CPF já cadastrado";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            if (!cliente.ValidarTelefone())
            {
                labelErro.Text = "Telefone Inválido";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!TelefoneUnico())
            {
                labelErro.Text = "Telefone já cadastrado";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            return true;
        }

        private bool ValidarEndereco()
        {

            if (!endereco.ValidarLogradouro())
            {
                labelErro.Text = "Logradouro Inválido";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!endereco.ValidarNumeroCasa())
            {
                labelErro.Text = "Número Inválido";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!endereco.ValidarComplemento())
            {
                labelErro.Text = "Complemento Inválido";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            if (!endereco.ValidarBairro())
            {
                labelErro.Text = "Bairro Inválido";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            if (!endereco.ValidarCEP())
            {
                labelErro.Text = "CEP Inválido";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            if (!endereco.ValidarCidade())
            {
                labelErro.Text = "Cidade Inválida";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            return true;

        }
        public bool EmailUnico()
        {
            foreach (var clientes in cliente.BuscarTodosClientes())
            {
                if (clientes.email == cliente.email)
                {
                    return false;
                }

            }
            return true;
        }
        public bool TelefoneUnico()
        {
            foreach (var clientes in cliente.BuscarTodosClientes())
            {
                if (clientes.telefone == cliente.telefone)
                {
                    return false;
                }

            }
            return true;
        }
        public bool CpfUnico()
        {
            foreach (var clientes in cliente.BuscarTodosClientes())
            {
                if (clientes.cpf == cliente.cpf)
                {
                    return false;
                }

            }
            return true;
        }
        private void LimparFormulario()
        {
            textNome.Text = string.Empty;
            textCpf.Text = string.Empty;
            textEmail.Text = string.Empty;
            maskTextTelefone.Text = string.Empty;
            comboBoxGenero.SelectedIndex = -1;
            maskedTextBoxDataDeNascimento.Text = string.Empty;
            textLogradouro.Text = string.Empty;
            textNumero.Text = string.Empty;
            textComplemento.Text = string.Empty;
            textBairro.Text = string.Empty;
            textCep.Text = string.Empty;
            textCidade.Text = string.Empty;
        }
        

        private void CriarCliente_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;
        }
    }
}
