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

        public bool VALIDARCEP() //validar numeros sequenciais ou repetidos
        {

            if (cep.Any(char.IsWhiteSpace))
            {
                return false;
            }
            if (cep.Length < 9)
            {
                return false;
            }

            return !string.IsNullOrWhiteSpace(cep);
        }
    }


}
