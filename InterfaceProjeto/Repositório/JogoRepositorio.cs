using InterfaceProjeto.BancodeDados;
using InterfaceProjeto.Domínio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProjeto.Repositório
{
    class JogoRepositorio
    {
        public List<Jogo> BuscarJogoPorId(int id)
        {
            List<Jogo> buscaJogos = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM jogo WHERE id = @id ; ";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            buscaJogos.Add(new Jogo()
                            {
                                id = reader.GetInt32("id"),
                                nome = reader.GetString("nome"),
                                genero = reader.GetString("genero"),
                                valor = reader.GetDecimal("valor")
                            });
                        }
                    }
                }

            }

            return buscaJogos;
        }
        public List<Jogo> BuscarJogoPorNome(string jogodigitado)
        {
            List<Jogo> buscaJogos = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM jogo WHERE alugado = 0 AND (nome LIKE @jogodigitado OR genero LIKE @jogodigitado ); ";

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
                                genero = reader.GetString("genero"),
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
                string query = "SELECT * FROM jogo WHERE alugado = 0; ";

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
                                genero = reader.GetString("genero"),
                                valor = reader.GetDecimal("valor")
                            });
                        }
                    }
                }

            }

            return buscaJogos;
        }
        public void AdicionarJogoAoPedido(int aluguelId, int jogoId)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO aluguel_jogo (aluguel_id, jogo_id) VALUES ( @aluguel_id, @jogo_id );";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@aluguel_id", aluguelId);
                    cmd.Parameters.AddWithValue("@jogo_id", jogoId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void JogoAlugado(int idJogoAlugado)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "UPDATE jogo SET alugado = 1 WHERE id = @jogoAlugado;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@jogoAlugado", idJogoAlugado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void JogoDevolvido(int id)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "UPDATE jogo SET alugado = 0 WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
