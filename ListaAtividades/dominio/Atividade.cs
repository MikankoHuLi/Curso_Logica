using ListaAtividades.repositorio;
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
        private readonly AtividadeRepositorio repositorio = new AtividadeRepositorio();

        public bool Criar()
        {
            if (!ValidarTitulo())
            {
               return false;
            }

            repositorio.Criar(titulo);
            return true;    
        }

        public bool AtualizarSituacao()
        {
            if (!ValidarId())
            { 
                return false; 
            }
            if (!ValidarSituacao())
            {
                return false;
            }

            Atividade atividadeEmAndamento = BuscarAtividadesAndamento();
            Situacao novaSituacao = BuscarProximaSituacao();

            if (atividadeEmAndamento.id > 0 && atividadeEmAndamento.situacao == novaSituacao)
            {
                return false;
            }

            repositorio.AtualizarSituacao(id, (int) novaSituacao);
            return true;
        }

        public Atividade BuscarAtividadesAndamento()
        {
            return repositorio.BuscarAtividadeAndamento();
        }

        public List<Atividade> ListarAtividadesPendentes()
        {
            return repositorio.ListarAtividadesPendentes();
        }
        private bool ValidarId()
        {
            return id > 0;
        }
        private bool ValidarSituacao()
        {
            return situacao != Situacao.Concluido;
        }

        private bool ValidarTitulo()
        {
            return !string.IsNullOrWhiteSpace(titulo);
        }

        private Situacao BuscarProximaSituacao()
        {
            //if (situacao == Situacao.Pendente)
            //{
            //    return Situacao.Realizando;
            //}

            //return Situacao.Concluido;
            return situacao == Situacao.Pendente ? Situacao.Realizando : Situacao.Concluido;
        }
    }
}
