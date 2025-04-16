using ListaAtividades.dominio;

namespace ListaAtividades
{
    public partial class ListaDeAtividades : Form
    {
        public ListaDeAtividades()
        {
            InitializeComponent();
        }

        private void ListaDeAtividades_Load(object sender, EventArgs e)
        {
            Atividade atividade = new ();

            var atividadeEmAndamento = atividade.BuscarAtividadesAndamento();
            if (atividadeEmAndamento.id > 0)
            {
                textAtividadeEmAndamento.Text = $"{atividadeEmAndamento.id} - {atividadeEmAndamento.titulo}";
            }

            var atividadesPendentes = atividade.ListarAtivadadesPendentes();
            gridAtividades.DataSource = atividadeEmAndamento;
        }
    }
}
