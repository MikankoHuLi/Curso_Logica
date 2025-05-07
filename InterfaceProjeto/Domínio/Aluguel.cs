using InterfaceProjeto.Repositório;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProjeto.Domínio
{
    class Aluguel
    {
        public int id { get; set; }
        public string? nome_cliente { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_devolucao { get; set; }
        public FormaDePagamento pagamento { get; set; }
        public decimal valor { get; set; }
        public int cliente_id { get; set; }
        
        private readonly AluguelRepositorio repositorioAluguel = new AluguelRepositorio();
        public void CriarPedidos()
        {
            repositorioAluguel.CriarPedidos(this);
        }    
        public void ExtenderAluguel(DateTime novaDataDevolucao, int clienteSelecionado, decimal novoValor)
        {
            repositorioAluguel.ExtenderAluguel(novaDataDevolucao, clienteSelecionado, novoValor);
        }
        public void PedidoEntregue(int pedidoSelecionado)
        {
            repositorioAluguel.PedidoEntregue(pedidoSelecionado);
        }
        public void Multa(int id, decimal novoValor)
        {
            repositorioAluguel.Multa(id, novoValor);
        }
        public List<Aluguel> BuscarPedidos()
        {
            return repositorioAluguel.BuscarPedidos();
        }
        public List<Aluguel> BuscarPedidosPorNome(string pedidoDigitado)
        {
            return repositorioAluguel.BuscarPedidosPorNome(pedidoDigitado);
        }
        public List<Aluguel_Jogo> BuscarDetalhesAluguel(int aluguel)
        {
            return repositorioAluguel.BuscarDetalhesAluguel(aluguel);
        }
        public int BuscarIdNovoAluguel()
        {
            return repositorioAluguel.BuscarIdNovoAluguel(cliente_id, data_inicio);
        }

        public List<Jogo> ListarJogos(int id)
        {
            return repositorioAluguel.BuscarJogosPorIdAluguel(id);
        }

        public string RelatorioAlugueisFinalizados()
        {
            return repositorioAluguel.RelatorioAlugueisFinalizados();
        }
    }
}
