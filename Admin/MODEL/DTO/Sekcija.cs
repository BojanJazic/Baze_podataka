using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.MODEL.DTO
{
    internal class Sekcija
    {
        public int SekcijaId { get; set; }
        public string Naziv { get; set; }
        public int BrojClanova { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Sekcija sekcija &&
                   SekcijaId == sekcija.SekcijaId;
        }

        public override int GetHashCode()
        {
            return -1833844350 + SekcijaId.GetHashCode();
        }

        public override string ToString()
        {
            return "Sekcija: " + Naziv + " ima: " + BrojClanova + " članova";
        }
    }
}
