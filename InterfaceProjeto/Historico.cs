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
    public partial class Historico : Form
    {
        private Aluguel aluguel = new Aluguel();
        public Historico()
        {
            InitializeComponent();
        }
        private void RelatorioAlugueisFinalizados()
        {
            var downloadsPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads";
            var fileName = $"relatorio-alugueis-finalizados_{DateTime.Now.ToLocalTime().ToString().Replace("/", "").Replace(":", "").Replace(" ", "-")}.csv";
            var data = new Aluguel().RelatorioAlugueisFinalizados();
            File.WriteAllText(Path.Combine(downloadsPath, Path.GetFileName(fileName)), data);
            MessageBox.Show($"Arquivo salvo em {fileName}");
            labelErro.Text = string.Empty;
        }
        private void RelatorioJogosAlugados()
        {
            var downloadsPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads";
            var fileName = $"relatorio-jogos-alugados_{DateTime.Now.ToLocalTime().ToString().Replace("/", "").Replace(":", "").Replace(" ", "-")}.csv";
            var data = new Aluguel().RelatorioJogosAlugados();
            File.WriteAllText(Path.Combine(downloadsPath, Path.GetFileName(fileName)), data);
            MessageBox.Show($"Arquivo salvo em {fileName}");
            labelErro.Text = string.Empty;
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            dataGridPedidos.DataSource = aluguel.BuscarPedidosEntregues();
            labelErro.Text = string.Empty;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            var pedidoDigitado = aluguel.BuscarPedidosEntreguesPorNome(textBuscarPedido.Text);
            dataGridPedidos.DataSource = null;
            dataGridPedidos.DataSource = pedidoDigitado;
        }

        private void buttonRelatorio_Click(object sender, EventArgs e)
        {
            int indice = comboRelatorio.SelectedIndex;
            if (indice == -1)
            {
                labelErro.Text = "Selecione um opção";
            }
            if (indice == 0)
            {
                RelatorioAlugueisFinalizados();               
            }
            if (indice == 1)
            {
                RelatorioJogosAlugados();
            }

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }
    }
}
