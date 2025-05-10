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
        private void RelatorioQuantidadePedidosCliente()
        {
            var downloadsPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads";
            var fileName = $"relatorio-quantidade-pedidos-cliente_{DateTime.Now.ToLocalTime().ToString().Replace("/", "").Replace(":", "").Replace(" ", "-")}.csv";
            var data = new Aluguel().RelatorioQuantidadePedidosCliente();
            File.WriteAllText(Path.Combine(downloadsPath, Path.GetFileName(fileName)), data);
            MessageBox.Show($"Arquivo salvo em {fileName}");
            labelErro.Text = string.Empty;
        }
        private void RelatorioJogosMaisAlugados()
        {
            var downloadsPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads";
            var fileName = $"relatorio-jogos-mais-alugados_{DateTime.Now.ToLocalTime().ToString().Replace("/", "").Replace(":", "").Replace(" ", "-")}.csv";
            var data = new Aluguel().RelatorioJogosMaisAlugados();
            File.WriteAllText(Path.Combine(downloadsPath, Path.GetFileName(fileName)), data);
            MessageBox.Show($"Arquivo salvo em {fileName}");
            labelErro.Text = string.Empty;
        }
        private void RelatorioJogosIndisponiveis()
        {           
            var downloadsPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads";
            var fileName = $"relatorio-jogos-indisponiveis_{DateTime.Now.ToLocalTime().ToString().Replace("/", "").Replace(":", "").Replace(" ", "-")}.csv";
            var data = new Aluguel().RelatorioJogosIndisponiveis();
            File.WriteAllText(Path.Combine(downloadsPath, Path.GetFileName(fileName)), data);
            MessageBox.Show($"Arquivo salvo em {fileName}");
            labelErro.Text = string.Empty;
        }
        private void RelatorioPedidosComMulta()
        {
            var downloadsPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads";
            var fileName = $"relatorio-pedidos-com-multa_{DateTime.Now.ToLocalTime().ToString().Replace("/", "").Replace(":", "").Replace(" ", "-")}.csv";
            var data = new Aluguel().RelatorioPedidosComMulta();
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
                RelatorioQuantidadePedidosCliente();
            }
            if (indice == 2)
            {   
                RelatorioJogosMaisAlugados();
            }
            if (indice == 3)
            { 
                RelatorioPedidosComMulta();
            }
            if (indice == 4)
            {                  
                RelatorioJogosIndisponiveis();
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
