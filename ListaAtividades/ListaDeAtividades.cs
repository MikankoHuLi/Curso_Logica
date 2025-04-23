using ListaAtividades.dominio;

namespace ListaAtividades
{
    public partial class ListaDeAtividades : Form
    {
        private Atividade? atividadeEmAndamento;

        public ListaDeAtividades()
        {
            InitializeComponent();
        }

        private void ListaDeAtividades_Load(object sender, EventArgs e)
        {
            CarregarAtividadeEmAndamento();
            CarregarAtividades();
        }
        private void CarregarAtividadeEmAndamento()
        {
            Atividade atividade = new ();

            atividadeEmAndamento = atividade.BuscarAtividadesAndamento();
            string textoAtividade = $"{atividadeEmAndamento.id} - {atividadeEmAndamento.titulo}";

            textAtividadeEmAndamento.Text = atividadeEmAndamento.id > 0 ? textoAtividade :string.Empty ;
            
        }


        private void CarregarAtividades()
        {
            Atividade atividade = new ();

            var atividadesPendentes = atividade.ListarAtividadesPendentes();
            gridAtividades.DataSource = atividadesPendentes;
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {


            if (atividadeEmAndamento == null || atividadeEmAndamento.id <= 0)
            {
                textErro.Text = "Não há atividade em andamento";
                textErro.ForeColor = Color.Red;
                return;
            }

            if (!atividadeEmAndamento.AtualizarSituacao())
            {
                textErro.Text = "Não foi possível finalizar a atividade";
                textErro.ForeColor = Color.Red;
                return;
            }

            CarregarAtividadeEmAndamento();
            textErro.Text = string.Empty;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (gridAtividades.SelectedRows.Count <= 0)
            {
                textErro.Text = "Selecione uma atividade";
                textErro.ForeColor = Color.Red;
                return;
            }

            var linhaSelecionada = gridAtividades.SelectedRows[0];

            Atividade atividade = new()
            {
                id = (int)linhaSelecionada.Cells[0].Value,
                titulo = (string)linhaSelecionada.Cells[1].Value,
                situacao = (Situacao)linhaSelecionada.Cells[2].Value

            };

            if (!atividade.AtualizarSituacao())
            {
                textErro.Text = "Não foi possível atualizar a atividade";
                textErro.ForeColor = Color.Red;
                return;
            }

            CarregarAtividadeEmAndamento();
            CarregarAtividades();
            textErro.Text = string.Empty;
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            var resultado = new CriarAtividade().ShowDialog();

            if (resultado != DialogResult.OK)
            {
                textErro.Text = "Criação da atividade não foi concluída";
                textErro.ForeColor = Color.Red;
                return;
            }
            textErro.Text = "Atividade criada com sucesso";
            textErro.ForeColor = Color.Green;
            CarregarAtividades();
        }
    }
    
}
