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
        private void Carregar()
        {
            dataGridCliente.DataSource = cliente.BuscarTodosClientes();
            dataGridJogo.DataSource = jogo.BuscarTodosJogos();
            textData_Inicio.Text = Convert.ToString(DateTime.Now);
            textData_Devolucao.Text = Convert.ToString(DateTime.Now.AddDays(10));

            labelAvisoCliente.Text = string.Empty;
            labelAvisoJogo.Text = string.Empty;
        }
        private void LimparPedido()
        {
            jogosSelecionado.Clear();
            dataGridJogosPedido.DataSource = null;
            dataGridJogosPedido.DataSource = jogosSelecionado;

            textValor.Clear();
        }
        private void CalcularValorPedido()
        {
            decimal valorPedido = 0;

            for (int i = 0; i < jogosSelecionado.Count; i++)
            {

                if (jogosSelecionado[i].valor != 0)
                {
                    valorPedido = valorPedido + jogosSelecionado[i].valor;
                }

                textValor.Text = Convert.ToString(valorPedido);
            }
        }

        private void buttonVoltarMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            var listaclientes = cliente.BuscarClientesPorNome(textBoxBuscarCliente.Text);
            dataGridCliente.DataSource = listaclientes;
        }

        private void buttonBuscarPedido_Click(object sender, EventArgs e)
        {
            var jogodigitado = jogo.BuscarJogoPorNome(textBoxBuscarJogo.Text);
            dataGridJogo.DataSource = jogodigitado;
        }

        private void CriarPedido_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            // deixar adicionar apenas uma copia por jogo
            if (dataGridJogo.SelectedRows.Count <= 0)
            {
                labelAvisoJogo.Text = "Selecione um Jogo";
                return;
            }

            var linhaSelecionada = dataGridJogo.SelectedRows[0];

            var jogodigitado = jogo.BuscarJogoPorId((int) linhaSelecionada.Cells[0].Value);

            jogosSelecionado.AddRange(jogodigitado);

            dataGridJogosPedido.DataSource = null;
            dataGridJogosPedido.DataSource = jogosSelecionado;

            CalcularValorPedido();

        }

        private void buttonSelecionarCliente_Click(object sender, EventArgs e)
        {
            // to do armazenar cpf cliente selecionado
            if (dataGridCliente.SelectedRows.Count <= 0)
            {
                labelAvisoCliente.Text = "Selecione um Cliente";
                return;
            }

            var linhaSelecionada = dataGridCliente.SelectedRows[0];
            clienteIdSelecionado = (int)linhaSelecionada.Cells[0].Value;           
            labelAvisoCliente.Text = "Cliente selecionado";
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            //criar label de erro propria
            if (dataGridJogosPedido.SelectedRows.Count <= 0)
            {
                labelAvisoJogo.Text = "Selecione um Jogo";
                return;
            }

            var linhaSelecionada = dataGridJogosPedido.SelectedRows[0];

            var jogodigitado = jogo.BuscarJogoPorNome((string)linhaSelecionada.Cells[1].Value);

            jogosSelecionado.RemoveAt((dataGridJogosPedido.Rows.IndexOf(dataGridJogosPedido.SelectedRows[0])));

            dataGridJogosPedido.DataSource = null;
            dataGridJogosPedido.DataSource = jogosSelecionado;

            CalcularValorPedido();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            LimparPedido();
        }

        private void buttonFinalizarPedido_Click(object sender, EventArgs e)
        {
            if (comboBoxPagamento.SelectedIndex== -1)
            {
                labelAvisoCliente.Text = "Selecione uma forma de pagamento";
                return;
            }
            if (clienteIdSelecionado == -1)
            {
                labelAvisoCliente.Text = "Selecione um Cliente";
                return;
            }
            if (jogosSelecionado == null || jogosSelecionado.Count == 0)
            {
                labelAvisoJogo.Text = "Adicione um jogo ao pedido";
                return;
            }
            DateTime dataPedido = DateTime.Now;
            aluguel = new Aluguel() //popular todos os dados
            {
                cliente_id = clienteIdSelecionado,
                data_inicio = dataPedido,
                data_devolucao = dataPedido.AddDays(10),
                pagamento = (FormaDePagamento)comboBoxPagamento.SelectedIndex,
                valor = Convert.ToDecimal(textValor.Text)
            };

            aluguel.CriarPedidos();

            int aluguelId = aluguel.BuscarIdNovoAluguel();

            foreach (var jogo in jogosSelecionado)
            {
                jogo.AdicionarJogoAoPedido(aluguelId);
                jogo.Alugar();
            }
            
            LimparPedido();
            Carregar();
            labelAvisoCliente.Text = "Aluguel criado com sucesso";

        }
    }
}
