using InterfaceProjeto.Domínio;
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
        private Cliente? cliente;
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
            cliente = new Cliente()
            {
                nome = textNome.Text,
                telefone = maskTextTelefone.Text,
                email = textEmail.Text,
                cpf = textCpf.Text,
                cep = textCep.Text,
                //popular novos dados
            };

            if (!cliente.VALIDARCADASTRO())
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
    }
}
