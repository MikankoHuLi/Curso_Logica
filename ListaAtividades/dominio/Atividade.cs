using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.dominio
{
    internal class Atividade
    {
        public int id {  get; set; }
        public string titulo {  get; set; }
        public Situacao situacao { get; set; }

        public void Criar()
        {
            
        }

        public void AtualizarSituacao()
        {
            
        }

        public Atividade BuscarAtividadesAndamento()
        {
            return new Atividade();
        }

        public List<Atividade> ListarAtivadadesPendentes()
        {
            return [];
        }

        private bool ValidarTitulo()
        {
            return !string.IsNullOrWhiteSpace(titulo);
        }

        private Situacao BuscarProximaSituacao()
        {
            return Situacao.Concluido;
        }
    }
}
