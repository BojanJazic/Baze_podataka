using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.MODEL.DTO
{
    internal class Osoba
    {
        public int OsobaId { get; set; }
        public string JMB { get; set; }
        public string BrojLicneKarte { get; set; }
        public string Prezime { get; set; }
        public string Ime { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }


        public override bool Equals(object obj)
        {
            return obj is Osoba dTO &&
                   OsobaId == dTO.OsobaId;
        }

        public override int GetHashCode()
        {
            return 586644312 + OsobaId.GetHashCode();
        }

        public override string ToString()
        {
            return "Osoba: " + Prezime + " " + Ime + ", JMB: " + JMB + ", Broj licne karte: " + BrojLicneKarte;
        }
    }
}
