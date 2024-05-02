using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.MODEL.DTO
{
    internal class ClanskaKarta
    {
        public int ClanskaKartaId { get; set; }
        public DateTime DatumUclanjivanja { get; set; }
        public String DatumIsclanjivanja { get; set; }
        public Clan OsobaId { get; set; }
    }
}
