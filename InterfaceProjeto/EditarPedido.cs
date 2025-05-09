using InterfaceProjeto.Domínio;

namespace InterfaceProjeto
{
    public partial class EditarPedido : Form
    {
        private Aluguel aluguel = new Aluguel();

        public EditarPedido()
        {
            InitializeComponent();
        }

        private void buttonVoltarMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void buttonBuscarPedido_Click(object sender, EventArgs e)
        {
            var pedidoDigitado = aluguel.BuscarPedidosPorNome(textBuscarPedido.Text);
            dataGridPedidos.DataSource = null;
            dataGridPedidos.DataSource = pedidoDigitado;
        }

        private void EditarPedido_Load(object sender, EventArgs e)
        {
            dataGridPedidos.DataSource = aluguel.BuscarPedidos();
            labelErroPedido.Text = string.Empty;
        }

        private void buttonDetalhes_Click(object sender, EventArgs e)
        {

            if (buttonDetalhes.Text == "Retornar")
            {
                dataGridPedidos.DataSource = null;
                dataGridPedidos.DataSource = aluguel.BuscarPedidos();
                buttonDetalhes.Text = "Detalhes";
                return;
            }

            if (buttonDetalhes.Text == "Detalhes")
            {
                if (dataGridPedidos.SelectedRows.Count <= 0)
                {
                    labelErroPedido.Text = "Selecione um Pedido";
                    return;
                }

                var linhaSelecionada = dataGridPedidos.SelectedRows[0];
                var aluguelDetalhes = aluguel.BuscarDetalhesAluguel((int)linhaSelecionada.Cells[0].Value);
                dataGridPedidos.DataSource = null;
                dataGridPedidos.DataSource = aluguelDetalhes;
                buttonDetalhes.Text = "Retornar";
                return;
            }
        }

        private void buttonExtender_Click(object sender, EventArgs e)
        {
            if (dataGridPedidos.SelectedRows.Count <= 0)
            {
                labelErroPedido.Text = "Selecione um Pedido";
                return;
            }

            var linhaSelecionada = dataGridPedidos.SelectedRows[0];
            aluguel.ExtenderAluguel(((DateTime)linhaSelecionada.Cells[3].Value).AddDays(10), (int)linhaSelecionada.Cells[0].Value, ((decimal)linhaSelecionada.Cells[5].Value) + 20);
            dataGridPedidos.DataSource = null;
            dataGridPedidos.DataSource = aluguel.BuscarPedidos();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (dataGridPedidos.SelectedRows.Count <= 0)
            {
                labelErroPedido.Text = "Selecione um Pedido";
                return;
            }

            var idAluguel = (int) dataGridPedidos.SelectedRows[0].Cells[0].Value;
            var dataDevoluacao = (DateTime) dataGridPedidos.SelectedRows[0].Cells[3].Value;
            var valorAluguel = (decimal) dataGridPedidos.SelectedRows[0].Cells[5].Value;

            aluguel.PedidoEntregue(idAluguel, DateTime.Now);

            dataGridPedidos.DataSource = null;
            dataGridPedidos.DataSource = aluguel.BuscarPedidos();

            List<Jogo> jogos = aluguel.ListarJogos(idAluguel);
            jogos.ForEach(jogo => jogo.Devolver());

            if (dataDevoluacao < DateTime.Now)
            {
                decimal novoValor = valorAluguel + 20;
                aluguel.Multa(idAluguel, novoValor);
                labelErroPedido.Text = "Pedido entregue com multa de 20 reais";
                return;
            }

            labelErroPedido.Text = "Pedido Entregue";


        }
    }
}
