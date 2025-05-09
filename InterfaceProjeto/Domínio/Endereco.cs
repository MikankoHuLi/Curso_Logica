using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProjeto.Domínio
{
    class Endereco
    {
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string? complemento { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }


        public bool ValorBranco(string valor)
        {
            return string.IsNullOrWhiteSpace(valor);
        }

        public bool ValidarLogradouro()
        {
            if (ValorBranco(logradouro))
            {
                return false;
            }
            if (logradouro.Any(char.IsPunctuation) || logradouro.All(char.IsNumber))
            {
                return false;
            }

            return true;
        }
        public bool ValidarNumeroCasa()
        {
            if (ValorBranco(numero))
            {
                return false;
            }
            if (numero.Any(char.IsPunctuation) || numero.All(char.IsLetter) || !numero.Any(char.IsNumber))
            {
                return false;
            }

            return true;
        }
        public bool ValidarComplemento()
        {
            if (ValorBranco(complemento))
            {
                return true;

            }
            if (complemento.All(char.IsNumber) || complemento.All(char.IsPunctuation))
            {
                return false;
            }
            return true;
        }
        public bool ValidarBairro()
        {
            if (ValorBranco(bairro))
            {
                return false;
            }
            if (bairro.Any(char.IsPunctuation) || bairro.All(char.IsNumber) || !bairro.Any(char.IsLetter))
            {
                return false;
            }

            return true;
        }
        
        
        public bool ValidarCEP()
        {
            if (ValorBranco(cep))
            {
                return false;
            }
            if (cep.Any(char.IsWhiteSpace) || cep.Length != 8 || cep.Any(char.IsLetter))
            {
                return false;
            }
            if (cep.Length != 8)
            {
                return false;
            }

            return true;
        }

        public bool ValidarCidade()
        {
            if (ValorBranco(cidade))
            {
                return true;

            }
            if (cidade.Any(char.IsNumber) || cidade.Any(char.IsPunctuation))
            {
                return false;
            }
            return true;
        }

    }


}
