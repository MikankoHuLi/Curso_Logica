using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPi.Domínio
{
    internal class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string cep { get; set; }

     // criar metodo texto branco
        public bool ValidarNome()
        {
        
            if (!nome.Any(char.IsWhiteSpace) || nome.Any(char.IsNumber) || nome.Any(char.IsPunctuation))
            {
                return false;
            }
            return true;
        }
        public bool ValidarTelefone()
        {
         

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
            //} trocar trocar pelo metodo banco de dados
            return true;
        }
        public bool ValidarEmail()
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
            return true;
        }
        public bool ValidarCPF()
        {
         
            if (cpf.Any(char.IsWhiteSpace))
            {
                return false;
            }
            if (cpf.Length < 9)
            {
                return false;
            }

            return true;
        }
        public bool ValidarCEP()
        {
         
            if (cep.Any(char.IsWhiteSpace))
            {
                return false;
            }
            if (cep.Length < 9)
            {
                return false;
            }

            return true;
        }

        public bool ValidarCadastro()
        {
            // mudar pra tenario
            if (!ValidarNome())
            { return false;}
            if (!ValidarTelefone())
            { return false; }
            if (!ValidarEmail())
            { return false; }
            if (!ValidarCEP())
            { return false; }
            if (!ValidarCPF())
            { return false; }


            return true;
        }
    }
}

  
