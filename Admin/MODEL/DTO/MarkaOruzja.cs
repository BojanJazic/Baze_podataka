using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.MODEL.DTO
{
    internal class MarkaOruzja
    {
        public string MarkaOruzjaNaziv { get; set; }

        public override bool Equals(object obj)
        {
            return obj is MarkaOruzja marka && MarkaOruzjaNaziv == marka.MarkaOruzjaNaziv;
        }

        public override string ToString()
        {
            return "Marka oruzja: " + MarkaOruzjaNaziv;
        }
    }
}
