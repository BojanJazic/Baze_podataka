using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.MODEL.DTO
{
    internal class EvidencijaOdstrela
    {
        public int EvidencijaOdstrelaId { get; set; }
        public Divljac DivljacId { get; set; }
        public Osoba OsobaId { get; set; }
        public DateTime DatumOdstrela { get; set; }
    }
}
