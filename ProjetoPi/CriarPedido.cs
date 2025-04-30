using Mysqlx.Resultset;
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
        private int clienteIdSelecionado;
        private List<Jogo> jogosSelecionado = [];


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


            //aluguel = new Aluguel() //popular todos os dados
            //{
            //    cliente_id = (int)dataGridCliente.SelectedRows[0].Cells[0].Value,
            //    data_inicio = DateTime.Now,
            //    data_devolucao = DateTime.Now.AddDays(10),
            //    /*pagamento = Convert.ToInt32(comboBoxPagamento.Text),*/
            //    valor = Convert.ToDecimal(textValor.Text)
            //};



            //aluguel.CriarPedidos(aluguel);
        }

        private void buttonSelecionarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridCliente.SelectedRows.Count <= 0)
            {
                labelClienteSelecionado.Text = "Selecione um Cliente";
                return;
            }

            var linhaSelecionada = dataGridCliente.SelectedRows[0];
            clienteIdSelecionado = (int)linhaSelecionada.Cells[0].Value;

            if (clienteIdSelecionado != -1)
            {
                labelClienteSelecionado.Text = "Cliente Selecionado";
            }
        }

        private void buttonAdicionarJogo_Click(object sender, EventArgs e)
        {
            if (dataGridJogo.SelectedRows.Count <= 0)
            {
                labelJogoSelecionado.Text = "Selecione um Jogo";
                return;
            }

            var linhaSelecionada = dataGridJogo.SelectedRows[0];

            var jogodigitado = jogo.BuscarJogoPorNome((string)linhaSelecionada.Cells[1].Value);

            jogosSelecionado.AddRange(jogodigitado);

            dataGridJogosPedido.DataSource = null;
            dataGridJogosPedido.DataSource = jogosSelecionado;

        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridJogosPedido.SelectedRows.Count <= 0)
            {
                labelJogoSelecionado.Text = "Selecione um Jogo";
                return;
            }

            var linhaSelecionada = dataGridJogosPedido.SelectedRows[0];

            var jogodigitado = jogo.BuscarJogoPorNome((string)linhaSelecionada.Cells[1].Value);

            jogosSelecionado.RemoveAt((dataGridJogosPedido.Rows.IndexOf(dataGridJogosPedido.SelectedRows[0])));

            dataGridJogosPedido.DataSource = null;
            dataGridJogosPedido.DataSource = jogosSelecionado;

        }

        private void buttonLimparPedido_Click(object sender, EventArgs e)
        {
            jogosSelecionado.Clear();
            dataGridJogosPedido.DataSource = null;
            dataGridJogosPedido.DataSource = jogosSelecionado;
        }
    }
}
