using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.MODEL.DTO
{
    internal class Oruzje
    {
        public string FabrickiBroj { get; set; }

        public VrstaOruzja VrstaOruzjaId { get; set; }
        public MarkaOruzja MarkaOruzjaId { get; set; }
        public KalibarOruzja KalibarOruzjaId { get; set; }

    }
}
