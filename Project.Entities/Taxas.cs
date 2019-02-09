using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entities.Enum;

namespace Project.Entities
{
    public class Taxas
    {
        public Bandeira Bandeira { get; set; }
        public decimal Credito { get; set; }
        public decimal Debito { get; set; }
    }
}
