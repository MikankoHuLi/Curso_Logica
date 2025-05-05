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
        public bool alugado { get; set; }
        public decimal valor { get; set; }
        private readonly AluguelRepositorio repositorioAluguel = new AluguelRepositorio();

        public List<Jogo> BuscarJogoPorNome(string jogodigitado)
        {
            return repositorioAluguel.BuscarJogoPorNome(jogodigitado);
        }
        public List<Jogo> BuscarTodosJogos()
        {
            return repositorioAluguel.BuscarTodosJogos();
        }
    }
}
