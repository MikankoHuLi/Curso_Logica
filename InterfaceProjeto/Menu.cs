using InterfaceProjeto.Domínio;

namespace InterfaceProjeto
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonCriarPedido_Click(object sender, EventArgs e)
        {
            CriarPedido criarPedido = new CriarPedido();
            criarPedido.Show();
            this.Hide();
        }

        private void buttonCriarCliente_Click(object sender, EventArgs e)
        {
            CriarCliente criarCliente = new CriarCliente();
            criarCliente.Show();
            this.Hide();
        }

        private void buttonEditarPedido_Click(object sender, EventArgs e)
        {
            EditarPedido editarPedido = new EditarPedido();
            editarPedido.Show();
            this.Hide();
        }

        private void buttonRelatorioAlugueisFinalizados_Click(object sender, EventArgs e)
        {
            var downloadsPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\Downloads";
            var fileName = $"relatorio-alugueis-finalizados_{DateTime.Now.ToLocalTime().ToString().Replace("/", "").Replace(":", "").Replace(" ", "-")}.csv";
            var data = new Aluguel().RelatorioAlugueisFinalizados();
            File.WriteAllText(Path.Combine(downloadsPath, Path.GetFileName(fileName)), data);
            MessageBox.Show($"Arquivo salvo em {fileName}");
        }
    }
}
