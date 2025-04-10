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
    }
}
