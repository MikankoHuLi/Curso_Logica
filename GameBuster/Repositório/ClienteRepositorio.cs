using GameBuster.BancoDeDados;
using GameBuster.Domínio;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBuster.Repositório
{
    class ClienteRepositorio
    {
        public void CriarClientes(Cliente novoCliente, Endereco novoEndereco)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO cliente (nome, telefone, email, cpf,genero,data_de_nascimento,logradouro,numero,complemento, bairro, cep,cidade) VALUES (@nome, @telefone, @email, @cpf,@genero,@data_de_nascimento,@logradouro,@numero,@complemento,@bairro, @cep,@cidade);";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", novoCliente.nome);
                    cmd.Parameters.AddWithValue("@telefone", novoCliente.telefone);
                    cmd.Parameters.AddWithValue("@email", novoCliente.email);
                    cmd.Parameters.AddWithValue("@cpf", novoCliente.cpf);
                    cmd.Parameters.AddWithValue("@genero", novoCliente.genero);
                    cmd.Parameters.AddWithValue("@data_de_nascimento", novoCliente.data_de_nascimento);
                    cmd.Parameters.AddWithValue("@logradouro", novoEndereco.logradouro);
                    cmd.Parameters.AddWithValue("@numero", novoEndereco.numero);
                    cmd.Parameters.AddWithValue("@complemento", novoEndereco.complemento);
                    cmd.Parameters.AddWithValue("@bairro", novoEndereco.bairro);
                    cmd.Parameters.AddWithValue("@cep", novoEndereco.cep);
                    cmd.Parameters.AddWithValue("@cidade", novoEndereco.cidade);

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
                string query = "SELECT * FROM cliente WHERE nome LIKE @nomedigitado OR cpf LIKE @nomedigitado;";

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
                                genero = (Genero)reader.GetInt32("genero"),
                                data_de_nascimento = reader.GetDateTime("data_de_nascimento")

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
                                genero = (Genero)reader.GetInt32("genero"),
                                data_de_nascimento = reader.GetDateTime("data_de_nascimento")

                            });
                        }
                    }
                }

            }

            return buscaClientes;
        }
    }
}
