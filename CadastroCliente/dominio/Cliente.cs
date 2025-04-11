using CadastroCliente.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CadastroCliente.Cadastro;

namespace CadastroCliente.dominio
{
    internal class Cliente
    {
        private readonly ClienteRepositorio clienteRepositorio = new();
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string nomeSocial { get; set; }
        public bool estrangeiro { get; set; }
        public EnderecoCliente endereco { get; set; }
        public GeneroCliente genero { get; set; }
        public EtniaCliente etnia { get; set; }
        public TipoCliente tipo { get; set; }

        public List<Cliente> ListarClientes()
        {
            return clienteRepositorio.ListarClientes();
        }

        public void InserirCliente(Cliente novocliente)
        {
            clienteRepositorio.InserirCliente(novocliente);
        }
    }
}
