using ProjetoPi.Repositório;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPi.Domínio
{
    internal class Aluguel
    {
        public int id { get; set; }        
        public string? nome_cliente { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_devolucao { get; set; }
        public FormaDePagamento pagamento { get; set; }
        public decimal valor { get; set; }
        public int cliente_id { get; set; }
        private readonly AluguelRepositorio repositorioAluguel = new AluguelRepositorio();
        public void CriarPedidos(Aluguel novoAluguel)
        {
            repositorioAluguel.CriarPedidos(novoAluguel);
        }
        public void AdicionarJogoAoPedido(int aluguelId, int jogoId)
        {
            repositorioAluguel.AdicionarJogoAoPedido(aluguelId, jogoId);
        }
        public void ExtenderAluguel(DateTime novaDataDevolucao, int clienteSelecionado, decimal novoValor)
        {
            repositorioAluguel.ExtenderAluguel(novaDataDevolucao, clienteSelecionado, novoValor);
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

    }
}
