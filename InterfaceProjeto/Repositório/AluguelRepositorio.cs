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
    class AluguelRepositorio
    {
       
        public void CriarPedidos(Aluguel novoAluguel)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO aluguel (cliente_id, data_inicio, data_devolução, pagamento, valor) VALUES (@cliente_id, @data_inicio, @data_devolução, @pagamento,@valor ;";

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
       
        public List<Aluguel> BuscarPedidos()
        {
            List<Aluguel> buscaPedidos = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT cliente.nome ,aluguel.id , data_inicio, data_devolucao, pagamento, aluguel.valor, cliente_id FROM aluguel  INNER JOIN cliente ON cliente.id = aluguel.cliente_id WHERE entregue = 0; ";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            buscaPedidos.Add(new Aluguel()
                            {

                                id = reader.GetInt32("id"),
                                nome_cliente = reader.GetString("nome"),
                                data_inicio = reader.GetDateTime("data_inicio"),
                                data_devolucao = reader.GetDateTime("data_devolucao"),
                                pagamento = (FormaDePagamento)reader.GetInt32("pagamento"),
                                valor = reader.GetDecimal("valor"),
                                cliente_id = reader.GetInt32("cliente_id")
                            });
                        }
                    }
                }

            }

            return buscaPedidos;
        }
        public List<Aluguel> BuscarPedidosPorNome(string pedidoDigitado)
        {
            List<Aluguel> buscaPedidos = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT cliente.nome ,aluguel.id , data_inicio, data_devolucao, pagamento, aluguel.valor, cliente_id FROM aluguel  INNER JOIN cliente ON cliente.id = aluguel.cliente_id WHERE cliente.nome LIKE @pedidoDigitado OR cliente.cpf LIKE @pedidoDigitado; ";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pedidoDigitado", $"{pedidoDigitado}%");
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            buscaPedidos.Add(new Aluguel()
                            {

                                id = reader.GetInt32("id"),
                                nome_cliente = reader.GetString("nome"),
                                data_inicio = reader.GetDateTime("data_inicio"),
                                data_devolucao = reader.GetDateTime("data_devolucao"),
                                pagamento = (FormaDePagamento)reader.GetInt32("pagamento"),
                                valor = reader.GetDecimal("valor"),
                                cliente_id = reader.GetInt32("cliente_id")
                            });
                        }
                    }
                }

            }

            return buscaPedidos;
        }
        public List<Aluguel_Jogo> BuscarDetalhesAluguel(int aluguel)
        {
            List<Aluguel_Jogo> AluguelJogos = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT jogo.nome, jogo.genero, jogo.valor FROM aluguel_jogo INNER JOIN aluguel ON aluguel.id = aluguel_jogo.aluguel_id INNER JOIN jogo ON jogo.id = aluguel_jogo.jogo_id INNER JOIN cliente ON cliente.id = aluguel.cliente_id  where aluguel.id = @aluguel;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@aluguel", $"{aluguel}%");
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            AluguelJogos.Add(new Aluguel_Jogo()
                            {                               
                                nome = reader.GetString("nome"),
                                genero = reader.GetString("genero"),
                                valor = reader.GetDecimal("valor")
                            });
                        }
                    }
                }

            }

            return AluguelJogos;
        }

        public void ExtenderAluguel(DateTime novaDataDevolucao, int clienteSelecionado, decimal novoValor)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "UPDATE aluguel SET data_devolucao = @novaDataDevolucao , valor = @novoValor WHERE id = @clienteSelecionado;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@clienteSelecionado", clienteSelecionado);
                    cmd.Parameters.AddWithValue("@novaDataDevolucao", novaDataDevolucao);
                    cmd.Parameters.AddWithValue("@novoValor", novoValor);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void PedidoEntregue(int pedidoSelecionado)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "UPDATE aluguel SET entregue = 1 WHERE id = @pedidoSelecionado;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pedidoSelecionado", pedidoSelecionado);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Multa(int pedidoSelecionado, decimal novoValor)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "UPDATE aluguel SET multa = 1 , valor = @novoValor WHERE id = @pedidoSelecionado;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pedidoSelecionado", pedidoSelecionado);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
