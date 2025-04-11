using CadastroCliente.banco_de_dados;
using CadastroCliente.dominio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.repositorio
{
    internal class ClienteRepositorio
    {
        public List<Cliente> ListarClientes()
        {
            var clientes = new List<Cliente>();

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = "SELECT c.*, e.logradouro, e.numero, e.complemento, e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco = e.id;";

                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var nomeSocial = !reader.IsDBNull("nome_social") ? reader.GetString("nome_social") : "";
                    var complemento = !reader.IsDBNull("complemento") ? reader.GetString("complemento") : "";


                    clientes.Add(new Cliente
                    {
                        id = reader.GetInt32("id"),
                        nome = reader.GetString("nome"),
                        nomeSocial = nomeSocial,
                        dataNascimento = reader.GetDateTime("data_nascimento"),
                        email = reader.GetString("email"),
                        telefone = reader.GetString("telefone"),
                        tipo = (TipoCliente)reader.GetInt32("tipo"),
                        etnia = (EtniaCliente)reader.GetInt32("etnia"),
                        genero = (GeneroCliente)reader.GetInt32("genero"),
                        estrangeiro = reader.GetBoolean("estrangeiro"),
                        endereco = new EnderecoCliente
                        {
                            id = reader.GetInt32("id_endereco"),
                            logradouro = reader.GetString("logradouro"),
                            numero = reader.GetString("numero"),
                            complemento = complemento,
                            bairro = reader.GetString("bairro"),
                            municipio = reader.GetString("municipio"),
                            estado = reader.GetString("estado"),
                            cep = reader.GetString("cep")
                        }
                    });
                }
            }

            return clientes;
        }

        public void InserirCliente(Cliente novocliente)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string queryEndereco = "INSERT INTO endereco (logradouro, numero, bairro, municipio, estado, cep, complemento)" +
                                       "VALUES (@logradouro, @numero, @bairro, @municipio, @estado, @cep, @complemento);";
                using (var cmd = new MySqlCommand(queryEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@logradouro", novocliente.endereco.logradouro);
                    cmd.Parameters.AddWithValue("@numero", novocliente.endereco.numero);
                    cmd.Parameters.AddWithValue("@bairro", novocliente.endereco.bairro);
                    cmd.Parameters.AddWithValue("@municipio", novocliente.endereco.municipio);
                    cmd.Parameters.AddWithValue("@estado", novocliente.endereco.estado);
                    cmd.Parameters.AddWithValue("@cep", novocliente.endereco.cep);
                    cmd.Parameters.AddWithValue("@complemento", novocliente.endereco.complemento);
                    cmd.ExecuteNonQuery();
                }

                int idEndereco = -1;

                string queryIdEndereco = "SELECT id FROM endereco " +                                           
                                         "WHERE logradouro = @logradouro " +                                            
                                         "AND numero = @numero " +                                            
                                         "AND bairro = @bairro " +                                           
                                         "AND municipio = @municipio " +                                            
                                         "AND estado = @estado " +                                            
                                         "AND cep = @cep " +                                            
                                         "AND complemento = @complemento;";

                using (var cmd = new MySqlCommand(queryIdEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@logradouro", novocliente.endereco.logradouro);
                    cmd.Parameters.AddWithValue("@numero", novocliente.endereco.numero);
                    cmd.Parameters.AddWithValue("@bairro", novocliente.endereco.bairro);
                    cmd.Parameters.AddWithValue("@municipio", novocliente.endereco.municipio);
                    cmd.Parameters.AddWithValue("@estado", novocliente.endereco.estado);
                    cmd.Parameters.AddWithValue("@cep", novocliente.endereco.cep);
                    cmd.Parameters.AddWithValue("@complemento", novocliente.endereco.complemento);
                    using (var reader = cmd.ExecuteReader())
                    {
                        idEndereco = reader.Read() ? reader.GetInt32("id") : -1;
                    }
                }

                string query = "INSERT INTO cliente (nome, nome_social, data_nascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco)" +
                               "VALUES (@nome, @nome_social, @data_nascimento, @email, @telefone, @tipo, @etnia, @genero, @estrangeiro, @id_endereco);";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", novocliente.nome);
                    cmd.Parameters.AddWithValue("@nome_social", novocliente.nomeSocial);
                    cmd.Parameters.AddWithValue("@data_nascimento", novocliente.dataNascimento);
                    cmd.Parameters.AddWithValue("@email", novocliente.email);
                    cmd.Parameters.AddWithValue("@telefone", novocliente.telefone);
                    cmd.Parameters.AddWithValue("@tipo", novocliente.tipo);
                    cmd.Parameters.AddWithValue("@etnia", novocliente.etnia);
                    cmd.Parameters.AddWithValue("@genero", novocliente.genero);
                    cmd.Parameters.AddWithValue("@estrangeiro", novocliente.estrangeiro);
                    cmd.Parameters.AddWithValue("@id_endereco", idEndereco);
                    cmd.ExecuteNonQuery();
                }
            }
            
        }
    }
}
