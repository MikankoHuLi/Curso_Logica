using ProjetoPi.Repositório;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPi.Domínio
{
    internal class Aluguel
    {
        public int id { get; set; }
        public int cliente_id { get; set; }
        public DateTime data_inicio { get; set; }
        public DateTime data_devolucao { get; set; }
        public int pagamento { get; set; }
        public decimal valor { get; set; }
        public bool multa { get; set; }
        public bool entregue { get; set; }

        
    }
}
