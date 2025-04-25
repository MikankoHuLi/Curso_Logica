using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPi.Domínio
{
    internal class Aluguel
    {
        int id { get; set; }
        int cliente_id { get; set; }
        DateTime data_inicio { get; set; }
        DateTime data_devolucao { get; set; }
        int pagamento { get; set; }
        decimal valor { get; set; }
        bool multa { get; set; }
        bool entregue { get; set; }
    }
}
