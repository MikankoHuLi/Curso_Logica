using InterfaceProjeto.BancodeDados;
using InterfaceProjeto.Domínio;
using MySql.Data.MySqlClient;
using System.Text;

namespace InterfaceProjeto.Repositório
{
    class AluguelRepositorio
    {

        public void CriarPedidos(Aluguel novoAluguel)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO aluguel (cliente_id, data_inicio, data_devolucao, pagamento, valor) VALUES (@cliente_id, @data_inicio, @data_devolucao, @pagamento, @valor) ;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    int pagamentoNum = Convert.ToInt32(novoAluguel.pagamento);
                    cmd.Parameters.AddWithValue("@cliente_id", novoAluguel.cliente_id);
                    cmd.Parameters.AddWithValue("@data_inicio", novoAluguel.data_inicio);
                    cmd.Parameters.AddWithValue("@data_devolucao", novoAluguel.data_devolucao);
                    cmd.Parameters.AddWithValue("@pagamento", pagamentoNum);
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
                string query = "SELECT cliente.nome, aluguel.id, data_inicio, data_devolucao, pagamento, aluguel.valor, cliente_id FROM aluguel INNER JOIN cliente ON cliente.id = aluguel.cliente_id WHERE entregue = 0; ";

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
        public List<Aluguel> BuscarPedidosEntregues()
        {
            List<Aluguel> buscaPedidos = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT cliente.nome, aluguel.id, data_inicio, data_devolucao, pagamento, aluguel.valor, cliente_id FROM aluguel INNER JOIN cliente ON cliente.id = aluguel.cliente_id WHERE entregue = 1; ";

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
                string query = "SELECT cliente.nome ,aluguel.id , data_inicio, data_devolucao, pagamento, aluguel.valor, cliente_id FROM aluguel  INNER JOIN cliente ON cliente.id = aluguel.cliente_id WHERE cliente.nome LIKE @pedidoDigitado AND entregue = 0 OR cliente.cpf LIKE @pedidoDigitado AND entregue = 0; ";

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
        public List<Aluguel> BuscarPedidosEntreguesPorNome(string pedidoDigitado)
        {
            List<Aluguel> buscaPedidos = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT cliente.nome ,aluguel.id , data_inicio, data_devolucao, pagamento, aluguel.valor, cliente_id FROM aluguel  INNER JOIN cliente ON cliente.id = aluguel.cliente_id WHERE cliente.nome LIKE @pedidoDigitado AND entregue = 1 OR cliente.cpf LIKE @pedidoDigitado AND entregue = 1 ; ";

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
        public void PedidoEntregue(int pedidoSelecionado, DateTime data_retorno)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "UPDATE aluguel SET entregue = 1, data_retorno = @data_retorno WHERE id = @pedidoSelecionado ;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pedidoSelecionado", pedidoSelecionado);
                    cmd.Parameters.AddWithValue("@data_retorno", data_retorno);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Multa(int id, decimal novoValor)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "UPDATE aluguel SET multa = 1 , valor = @novoValor WHERE id = @id ;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@novoValor", novoValor);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public int BuscarIdNovoAluguel(int clienteSelecionado, DateTime dataPedido)
        {
            int idNovoAluguel = -1;

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT id FROM aluguel where cliente_id = @clienteSelecionado AND data_inicio = @dataPedido ;";
                string data = $"{dataPedido.Year}-{dataPedido.Month}-{dataPedido.Day} {dataPedido.Hour}:{dataPedido.Minute}:{dataPedido.Second}";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@clienteSelecionado", clienteSelecionado);
                    cmd.Parameters.AddWithValue("@dataPedido", data);

                    using (var reader = cmd.ExecuteReader())
                    {
                        idNovoAluguel = reader.Read() ? reader.GetInt32("id") : -1;
                    }
                }
            }

            return idNovoAluguel;
        }
    
        public List<Jogo> BuscarJogosPorIdAluguel(int aluguelId)
        {
            List<Jogo> jogos = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT jogo_id FROM aluguel_jogo WHERE aluguel_id = @aluguel_id ;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@aluguel_id", aluguelId);
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            jogos.Add(new Jogo()
                            {
                                id = reader.GetInt32("jogo_id")
                            });
                        }
                    }
                }

            }

            return jogos;
        }
    
        public string RelatorioAlugueisFinalizados()
        {
            var resultado = new StringBuilder();
            resultado.AppendLine("id;nome;cpf;email;data_inicio;data_devolucao;valor;pagamento");

            var query = "SELECT \r\n    a.id,\r\n    c.nome,\r\n    c.cpf,\r\n    c.email,\r\n    a.data_inicio,\r\n    a.data_devolucao,\r\n    a.valor,\r\n    a.pagamento\r\nFROM\r\n    aluguel a\r\n        INNER JOIN\r\n    cliente c ON a.cliente_id = c.id\r\nWHERE\r\n    a.entregue = 1;";

            using (var con = DataBase.GetConnection())
            {
                con.Open();

                using var cmd = new MySqlCommand(query, con);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resultado.AppendLine($"{reader.GetInt32("id")};{reader.GetString("nome")};{reader.GetString("cpf")};{reader.GetString("email")};{reader.GetDateTime("data_inicio")};{reader.GetDateTime("data_devolucao")};{reader.GetDecimal("valor")};{reader.GetInt32("pagamento")}");
                }
            }

            return resultado.ToString();
        }
        public string RelatorioJogosAlugados()
        {
            var resultado = new StringBuilder();
            resultado.AppendLine("QuantidadeDeAlugueis;Nome");

            var query = "SELECT count(aluguel_id) , jogo.nome FROM aluguel_jogo INNER JOIN aluguel ON aluguel.id = aluguel_jogo.aluguel_id INNER JOIN jogo ON jogo.id = aluguel_jogo.jogo_id INNER JOIN cliente ON cliente.id = aluguel.cliente_id GROUP BY jogo.nome;";

            using (var con = DataBase.GetConnection())
            {
                con.Open();

                using var cmd = new MySqlCommand(query, con);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resultado.AppendLine($"{reader.GetInt32("count(aluguel_id)")};{reader.GetString("nome")}");
                }
            }

            return resultado.ToString();
        }
    }
}
