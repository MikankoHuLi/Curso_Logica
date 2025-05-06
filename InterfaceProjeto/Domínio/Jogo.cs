using InterfaceProjeto.Repositório;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProjeto.Domínio
{
    class Jogo
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string genero { get; set; }
        public decimal valor { get; set; }
        private readonly JogoRepositorio repositorioJogo = new JogoRepositorio();

        public List<Jogo> BuscarJogoPorNome(string jogodigitado)
        {
            return repositorioJogo.BuscarJogoPorNome(jogodigitado);
        }
        public List<Jogo> BuscarTodosJogos()
        {
            return repositorioJogo.BuscarTodosJogos();
        }
        public void AdicionarJogoAoPedido(int aluguelId, int jogoId)
        {
            repositorioJogo.AdicionarJogoAoPedido(aluguelId, jogoId);
        }
    }
}
