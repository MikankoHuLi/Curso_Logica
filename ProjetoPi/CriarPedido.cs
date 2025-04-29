using ProjetoPi.Domínio;
using ProjetoPi.Repositório;
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
    public partial class CriarPedido : Form

    {
        private Cliente cliente = new Cliente();
        private Jogo jogo = new Jogo();
        private Aluguel? aluguel;

        public CriarPedido()
        {
            InitializeComponent();
        }

        private void CriarPedido_Load(object sender, EventArgs e)
        {
            dataGridCliente.DataSource = cliente.BuscarTodosClientes();
            dataGridJogo.DataSource = jogo.BuscarTodosJogos();
            textData_Inicio.Text = Convert.ToString(DateTime.Now);
            textData_Devolucao.Text = Convert.ToString(DateTime.Now.AddDays(10));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            menu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var listaclientes = cliente.BuscarClientesPorNome(textBoxBuscarCliente.Text);
            dataGridCliente.DataSource = listaclientes;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var jogodigitado = jogo.BuscarJogoPorNome(textBoxBuscarJogo.Text);
            dataGridJogo.DataSource = jogodigitado;
        }

        private void buttonCriarAluguel_Click(object sender, EventArgs e)
        {
            aluguel = new Aluguel() //popular todos os dados
            {
                cliente_id = (int)dataGridCliente.SelectedRows[0].Cells[0].Value,
                data_inicio = DateTime.Now,
                data_devolucao = DateTime.Now.AddDays(10),
                pagamento = Convert.ToInt32(comboBoxPagamento.Text),
                valor = Convert.ToDecimal(textValor.Text),
            };

         

            aluguel.CriarPedidos(aluguel);
        }
    }
}
