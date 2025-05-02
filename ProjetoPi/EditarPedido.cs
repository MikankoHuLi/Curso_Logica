using MySqlX.XDevAPI;
using ProjetoPi.Domínio;
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
    public partial class EditarPedido : Form
    {
        private Aluguel aluguel = new Aluguel();
        public EditarPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            menu.Show();
            this.Hide();
        }

        private void EditarPedido_Load(object sender, EventArgs e)
        {
            dataGridPedidos.DataSource = aluguel.BuscarPedidos();
        }

        private void buttonBuscaPedido_Click(object sender, EventArgs e)
        {
            var pedidoDigitado = aluguel.BuscarPedidosPorNome(textBuscarPedido.Text);
            dataGridPedidos.DataSource = pedidoDigitado;
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            // TabIndex(?) arrumar ordem datagrid
            if (btnDetalhes.Text == "Retornar")
            {
                dataGridPedidos.DataSource = aluguel.BuscarPedidos();
                btnDetalhes.Text = "Detalhes";
                return;
            }

            if (btnDetalhes.Text == "Detalhes")
            {
                if (dataGridPedidos.SelectedRows.Count <= 0)
                {
                    labelErroPedido.Text = "Selecione um Pedido";
                    return;
                }

                var linhaSelecionada = dataGridPedidos.SelectedRows[0];
                var aluguelDetalhes = aluguel.BuscarDetalhesAluguel((int)linhaSelecionada.Cells[0].Value);
                dataGridPedidos.DataSource = aluguelDetalhes;
                btnDetalhes.Text = "Retornar";
                return;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }

        private void btnExtender_Click(object sender, EventArgs e)
        {
            if (dataGridPedidos.SelectedRows.Count <= 0)
            {
                labelErroPedido.Text = "Selecione um Pedido";
                return;
            }

            var linhaSelecionada = dataGridPedidos.SelectedRows[0];
            aluguel.ExtenderAluguel(((DateTime)linhaSelecionada.Cells[3].Value).AddDays(10), (int)linhaSelecionada.Cells[0].Value, ((decimal)linhaSelecionada.Cells[5].Value)+20);
            dataGridPedidos.DataSource = aluguel.BuscarPedidos();
        }
    }
}
