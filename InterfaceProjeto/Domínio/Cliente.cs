using InterfaceProjeto.Repositório;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProjeto.Domínio
{
    class Cliente
    {       
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public Genero genero { get; set; }
        public DateTime data_de_nascimento { get; set; }



        private readonly ClienteRepositoriocs repositorioCliente = new ClienteRepositoriocs();

        public List<Cliente> BuscarClientesPorNome(string nomedigitado)
        {
            return repositorioCliente.BuscarClientesPorNome(nomedigitado);
        }
        public List<Cliente> BuscarTodosClientes()
        {
            return repositorioCliente.BuscarTodosClientes();
        }
        public void CriarClientes(Cliente novoCliente, Endereco novoEndereco)
        {
            repositorioCliente.CriarClientes(novoCliente, novoEndereco);
        }
        public bool VALIDARNOME()
        {

            if (!nome.Any(char.IsWhiteSpace) || nome.Any(char.IsNumber) || nome.Any(char.IsPunctuation))
            {
                return false;
            }

            return !string.IsNullOrWhiteSpace(nome);
        }
        public bool VALIDARTELEFONE()
        {


            if (telefone.Length < 14 || telefone.Any(char.IsWhiteSpace)) //validar numeros sequenciais ou repetidos
            {
                return false;
            }

            //for (int i = 0; i < clientes.Count; i++)
            //{
            //    if (clientes[i].telefone == textTelefone.Text)
            //    {
            //        return false;
            //    }
            //} trocar trocar pelo metodo banco de dados
            return !string.IsNullOrWhiteSpace(telefone);
        }
        public bool VALIDAREMAIL()
        {

            if (email.Any(char.IsWhiteSpace) || !email.Contains("@") || !email.Contains(".") || !email.Any(char.IsLetter))
            {
                return false;
            }

            //for (int i = 0; i < clientes.Count; i++)
            //{
            //    if (clientes[i].email == textEmail.Text)
            //    {
            //        return false;
            //    }
            //} trocar pelo metodo banco de dados
            return !string.IsNullOrWhiteSpace(email);
        }
        public bool VALIDARCPF() //validar numeros sequenciais ou repetidos
        {

            if (cpf.Any(char.IsWhiteSpace))
            {
                return false;
            }
            if (cpf.Length < 9)
            {
                return false;
            }

            return !string.IsNullOrWhiteSpace(cpf);
        }
        

        public bool VALIDARCADASTRO()
        {
            if (!VALIDARNOME())
            { return false; }
            if (!VALIDARTELEFONE())
            { return false; }
            if (!VALIDAREMAIL())
            { return false; }            
            if (!VALIDARCPF())
            { return false; }

            return true;
        }
    }
}
