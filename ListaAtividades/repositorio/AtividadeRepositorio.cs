using ListaAtividades.banco_de_dados;
using ListaAtividades.dominio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.repositorio
{
    internal class AtividadeRepositorio
    {
        public void Criar(string titulo)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = "INSERT INTO atividade (titulo) VALUES (@titulo);";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.ExecuteNonQuery();
                }


            }

        }
        public void AtualizarSituacao(int id, int novaSituacao)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = "UPDATE atividade SET situacao = @situacao WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@situacao", novaSituacao);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }


            }

        }
        public Atividade BuscarAtividadeAndamento()
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open ();

                string query = $"SELECT * FROM atividade WHERE situacao = {(int) Situacao.Realizando};";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Atividade()
                            {
                                id = reader.GetInt32("id"),
                                titulo = reader.GetString("titulo"),
                                situacao = (Situacao)reader.GetInt32("situacao")
                            }; 
                        }

                    }
                    
                }

            }

                return new Atividade();
        }
        public List<Atividade> ListarAtividadesPendentes()
        {
            List<Atividade> atividades = [];
            using (var conn = Database.GetConnection())
            {
                conn.Open ();

                string query = $"SELECT * FROM atividade WHERE situacao = {(int) Situacao.Pendente}; ";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            atividades.Add(new Atividade()
                            {
                                id = reader.GetInt32("id"),
                                titulo = reader.GetString("titulo"),
                                situacao = (Situacao)reader.GetInt32("situacao")
                            });
                        }

                    }
                }
            }

                return atividades;
        }

    }
}
