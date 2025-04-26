using MySql.Data.MySqlClient;
using ProjetoPi.BancoDeDados;
using ProjetoPi.Domínio;

namespace ProjetoPi.Repositório
{
    internal class ClienteRepositoriocs
    {
        public void CriarClientes(Cliente novoCliente )
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO cliente (nome, telefone, email, cpf, cep) VALUES (@nome, @telefone, @email, @cpf, @cep);";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", novoCliente.nome);
                    cmd.Parameters.AddWithValue("@telefone", novoCliente.telefone);
                    cmd.Parameters.AddWithValue("@email", novoCliente.email);
                    cmd.Parameters.AddWithValue("@cpf", novoCliente.cpf);
                    cmd.Parameters.AddWithValue("@cep", novoCliente.cep);

                    cmd.ExecuteNonQuery();
                }
            }
        }
            public List<Cliente> BuscarClientesPorNome(string nomedigitado)
        {
            List<Cliente> buscaClientes = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM cliente WHERE nome LIKE @nomedigitado;";

                using (var cmd = new MySqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@nomedigitado", $"{nomedigitado}%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            buscaClientes.Add(new Cliente()
                            {

                                id = reader.GetInt32("id"),
                                nome = reader.GetString("nome"),
                                telefone = reader.GetString("telefone"),
                                email = reader.GetString("email"),
                                cpf = reader.GetString("cpf"),
                                cep = reader.GetString("cep")

                            });
                        }
                    }
                }

            }

            return buscaClientes;
        }
        public List<Cliente> BuscarTodosClientes()
        {
            List<Cliente> buscaClientes = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM cliente;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            buscaClientes.Add(new Cliente()
                            {

                                id = reader.GetInt32("id"),
                                nome = reader.GetString("nome"),
                                telefone = reader.GetString("telefone"),
                                email = reader.GetString("email"),
                                cpf = reader.GetString("cpf"),
                                cep = reader.GetString("cep")

                            });
                        }
                    }
                }

            }

            return buscaClientes;
        }
    }

}
