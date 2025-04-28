using MySql.Data.MySqlClient;
using ProjetoPi.BancoDeDados;
using ProjetoPi.Domínio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPi.Repositório
{
    internal class AluguelRepositorio
    {

        public List<Jogo> BuscarJogoPorNome(string jogodigitado)
        {
            List<Jogo> buscaJogos = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM jogo WHERE nome LIKE @jogodigitado; ";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@jogodigitado", $"{jogodigitado}%");
                    using (var reader = cmd.ExecuteReader())
                    { 
                        
                        while (reader.Read())
                        {
                            buscaJogos.Add(new Jogo()
                            {

                                id = reader.GetInt32("id"),
                                nome = reader.GetString("nome"),
                                alugado = reader.GetBoolean("alugado"),
                                valor = reader.GetDecimal("valor")
                            });
                        }
                    }
                }

            }

            return buscaJogos;
        }
        public List<Jogo> BuscarTodosJogos()
        {
            List<Jogo> buscaJogos = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM jogo; ";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            buscaJogos.Add(new Jogo()
                            {

                                id = reader.GetInt32("id"),
                                nome = reader.GetString("nome"),
                                alugado = reader.GetBoolean("alugado"),
                                valor = reader.GetDecimal("valor")
                            });
                        }
                    }
                }

            }

            return buscaJogos;
        }

        public void CriarPedidos(Aluguel novoAluguel)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO aluguel (cliente_id, data_inicio, data_devolução, pagamento, valor) VALUES (@cliente_id, @data_inicio, @data_devolução, @pagamento,@valor;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cliente_id", novoAluguel.cliente_id);
                    cmd.Parameters.AddWithValue("@data_inicio", novoAluguel.data_inicio);
                    cmd.Parameters.AddWithValue("@data_devolução", novoAluguel.data_devolucao);
                    cmd.Parameters.AddWithValue("@pagamento", novoAluguel.pagamento);
                    cmd.Parameters.AddWithValue("@valor", novoAluguel.valor);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
