using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.MODEL.DTO
{
    internal class VrstaOruzja
    {
        public string VrstaOruzjaNaziv { get; set; }

        public override bool Equals(object obj)
        {
            return obj is VrstaOruzja oruzja &&
                   VrstaOruzjaNaziv == oruzja.VrstaOruzjaNaziv;
        }

        public override string ToString()
        {
            return "Vrsta oruzja: " + VrstaOruzjaNaziv;
        }
    }
}
