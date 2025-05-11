using GameBuster.BancoDeDados;
using GameBuster.Domínio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBuster.Repositório
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

                                numero_pedido = reader.GetInt32("id"),
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
                string query = "SELECT cliente.nome, aluguel.id, data_inicio, data_devolucao, data_retorno, pagamento, aluguel.valor, cliente_id FROM aluguel INNER JOIN cliente ON cliente.id = aluguel.cliente_id WHERE entregue = 1; ";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            buscaPedidos.Add(new Aluguel()
                            {

                                numero_pedido = reader.GetInt32("id"),
                                nome_cliente = reader.GetString("nome"),
                                data_inicio = reader.GetDateTime("data_inicio"),
                                data_devolucao = reader.GetDateTime("data_devolucao"),
                                data_retorno = reader.GetDateTime("data_retorno"),
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
                string query = "SELECT cliente.nome ,aluguel.id , data_inicio, data_devolucao, data_retorno, pagamento, aluguel.valor, cliente_id FROM aluguel  INNER JOIN cliente ON cliente.id = aluguel.cliente_id WHERE cliente.nome LIKE @pedidoDigitado AND entregue = 0 OR cliente.cpf LIKE @pedidoDigitado AND entregue = 0; ";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pedidoDigitado", $"{pedidoDigitado}%");
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            buscaPedidos.Add(new Aluguel()
                            {

                                numero_pedido = reader.GetInt32("id"),
                                nome_cliente = reader.GetString("nome"),
                                data_inicio = reader.GetDateTime("data_inicio"),
                                data_devolucao = reader.GetDateTime("data_devolucao"),
                                data_retorno = reader.GetDateTime("data_retorno"),
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
                string query = "SELECT cliente.nome ,aluguel.id , data_inicio, data_devolucao, data_retorno, pagamento, aluguel.valor, cliente_id FROM aluguel  INNER JOIN cliente ON cliente.id = aluguel.cliente_id WHERE cliente.nome LIKE @pedidoDigitado AND entregue = 1 OR cliente.cpf LIKE @pedidoDigitado AND entregue = 1 ; ";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@pedidoDigitado", $"{pedidoDigitado}%");
                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            buscaPedidos.Add(new Aluguel()
                            {

                                numero_pedido = reader.GetInt32("id"),
                                nome_cliente = reader.GetString("nome"),
                                data_inicio = reader.GetDateTime("data_inicio"),
                                data_devolucao = reader.GetDateTime("data_devolucao"),
                                data_retorno = reader.GetDateTime("data_retorno"),
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
            resultado.AppendLine("NumeroPedido;IdCliente;Cliente;cpf;data_inicio;data_devolucao;data_retorno;pagamento;valor;multa");

            var query = "SELECT aluguel.id, cliente_id, cliente.nome, cliente.cpf, data_inicio, data_devolucao, data_retorno, pagamento, valor, multa FROM aluguel INNER JOIN cliente ON cliente.id = aluguel.cliente_id WHERE entregue = 1;";

            using (var con = DataBase.GetConnection())
            {
                con.Open();

                using var cmd = new MySqlCommand(query, con);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resultado.AppendLine($"{reader.GetInt32("id")};{reader.GetInt32("cliente_id")};{reader.GetString("nome")};{reader.GetString("cpf")};{reader.GetDateTime("data_inicio")};{reader.GetDateTime("data_devolucao")};{reader.GetDateTime("data_retorno")};{reader.GetInt32("pagamento")};{reader.GetDecimal("valor")};{reader.GetInt32("multa")}");
                }
            }

            return resultado.ToString();
        }
        public string RelatorioQuantidadePedidosCliente()
        {
            var resultado = new StringBuilder();
            resultado.AppendLine("NumeroDePedidos;Nome;CPF");

            var query = "SELECT count(aluguel.id) AS 'NumeroPedidos', cliente.nome,cliente.cpf FROM aluguel INNER JOIN cliente ON cliente.id = aluguel.cliente_id GROUP BY cliente.nome ;";

            using (var con = DataBase.GetConnection())
            {
                con.Open();

                using var cmd = new MySqlCommand(query, con);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resultado.AppendLine($"{reader.GetInt32("NumeroPedidos")};{reader.GetString("nome")};{reader.GetString("cpf")}");
                }
            }

            return resultado.ToString();
        }
        public string RelatorioJogosMaisAlugados()
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
        public string RelatorioPedidosComMulta()
        {
            var resultado = new StringBuilder();
            resultado.AppendLine("NumeroPedido;Valor;Cliente;CPF;Email;data_inicio;data_devolucao;data_retorno;pagamento");

            var query = "SELECT aluguel.id , aluguel.valor  ,cliente.nome, cliente.cpf, cliente.email, data_inicio,data_devolucao,data_retorno,pagamento FROM aluguel INNER JOIN cliente ON cliente.id = aluguel.cliente_id WHERE multa = 1;";

            using (var con = DataBase.GetConnection())
            {
                con.Open();

                using var cmd = new MySqlCommand(query, con);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resultado.AppendLine($"{reader.GetInt32("id")};{reader.GetDecimal("valor")};{reader.GetString("nome")};{reader.GetString("cpf")};{reader.GetString("email")};{reader.GetDateTime("data_inicio")};{reader.GetDateTime("data_devolucao")};{reader.GetDateTime("data_retorno")};{reader.GetInt32("pagamento")}");
                }
            }

            return resultado.ToString();
        }
        public string RelatorioJogosIndisponiveis()
        {
            var resultado = new StringBuilder();
            resultado.AppendLine("NumeroPedido;Cliente;IdJogo;NomeJogo;Genero;Valor");

            var query = "SELECT aluguel_id, cliente.nome AS 'cliente', jogo_id, jogo.nome, jogo.genero, jogo.valor FROM aluguel_jogo INNER JOIN aluguel ON aluguel.id = aluguel_jogo.aluguel_id INNER JOIN jogo ON jogo.id = aluguel_jogo.jogo_id INNER JOIN cliente ON cliente.id = aluguel.cliente_id WHERE alugado = 1 AND entregue = 0;";

            using (var con = DataBase.GetConnection())
            {
                con.Open();

                using var cmd = new MySqlCommand(query, con);
                using var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    resultado.AppendLine($"{reader.GetInt32("aluguel_id")};{reader.GetString("cliente")};{reader.GetInt32("jogo_id")};{reader.GetString("nome")};{reader.GetString("genero")};{reader.GetDecimal("valor")}");
                }
            }

            return resultado.ToString();
        }
    }
}
