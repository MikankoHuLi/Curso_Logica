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

            if (telefone.Length < 11 || telefone.Any(char.IsWhiteSpace))
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
        public bool ValidarNascimento(string nascimento)
        {
            if (ValorBranco(nascimento))
            {
                return false;

            }

            if (nascimento.Length < 10 || nascimento.Contains(" "))
            {
                return false;
            }

            int index = 6;
            string ano = nascimento.Substring(index); 
            if (Convert.ToInt32(ano) > 2007 || Convert.ToInt32(ano) < 1900)
            {
                return false;
            }

            DateTime temp;
            if (!DateTime.TryParse(nascimento, out temp))
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
                       
            return true;
        }

        public bool ValidarGenero()
        {
            if (genero.ToString() == null || (genero.ToString() == "-1"))
            {
                return false;
            }


            return true;
        }
        public bool ValidarCpf()
        {
            if (ValorBranco(cpf))
            {
                return false;
            }
            if (cpf.Any(char.IsWhiteSpace) || cpf.Any(char.IsLetter) || cpf.Any(char.IsPunctuation) || cpf.Length != 11)
            {
                return false;
            }

            return true;
        }



    }
}
