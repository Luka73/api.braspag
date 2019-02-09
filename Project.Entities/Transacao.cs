using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entities.Enum;

namespace Project.Entities
{
    public class Transacao
    {
        public decimal Valor { get; set; }
        public Adquirente Adquirente { get; set; }
        public TipoTransacao Tipo { get; set; }
        public Bandeira Bandeira { get; set; }   
    }
}
