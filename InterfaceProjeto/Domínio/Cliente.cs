using InterfaceProjeto.Repositório;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProjeto.Domínio
{
    class Cliente
    {
        public int id { get; set; }
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
        public bool ValorBranco(string valor)
        {
            return string.IsNullOrWhiteSpace(valor);
        }

        public bool ValidarNome()
        {
            if (ValorBranco(nome))
            {
                return false;
            }
            if (!nome.Any(char.IsWhiteSpace) || nome.Any(char.IsNumber) || nome.Any(char.IsPunctuation))
            {
                return false;
            }

            return true;
        }
        public bool ValidarTelefone()
        {
            if (ValorBranco(telefone))
            {
                return false;
            }

            if (telefone.Length < 14 || telefone.Any(char.IsWhiteSpace))
            {
                return false;
            }

            //for (int i = 0; i < clientes.Count; i++)
            //{
            //    if (clientes[i].telefone == textTelefone.Text)
            //    {
            //        return false;
            //    }
            //}
            return true;
        }
        public bool ValidarNascimento()
        {
            if (ValorBranco(data_de_nascimento.ToString()))
            {
                return false;

            }

            if (data_de_nascimento.ToString().Length < 9 || data_de_nascimento.ToString().Contains(" "))
            {
                return false;
            }

            int index = 6;
            string ano = data_de_nascimento.ToString().Substring(index); 
            if (Convert.ToInt32(ano) > 2007 || Convert.ToInt32(ano) < 1900)
            {
                return false;
            }

            DateTime temp;
            if (!DateTime.TryParse(data_de_nascimento.ToString(), out temp))
            {
                return false;
            }

            return true;
        }
        public bool ValidarEmail()
        {
            if (ValorBranco(email))
            {
                return false;
            }
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
            //}
            return true;
        }

        public bool ValidarGenero()
        {
            if (genero.ToString() == null)
            {
                return false;
            }


            return true;
        }
        

        
    }
}
