using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPi
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            CriarPedido criarPedido = new CriarPedido();

            criarPedido.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarPedido editarPedido = new EditarPedido();

            editarPedido.Show();
            this.Hide();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            CriarCliente criarCliente = new CriarCliente();

            criarCliente.Show();
            this.Hide();
        }
    }
}
