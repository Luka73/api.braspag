using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Entities.Enum;

namespace Project.Entities
{
    public class MDR
    {
        public Adquirente Adquirente { get; set; }
        public List<Taxas> Taxas { get; set; }
    }
}
