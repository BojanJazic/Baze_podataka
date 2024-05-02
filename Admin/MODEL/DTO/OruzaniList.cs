using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.MODEL.DTO
{
    internal class OruzaniList
    {
        public string SerijskiBroj { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public string RokVazenja { get; set; }
        public Oruzje FabrickiBroj { get; set; }
        public Clan OsobaId { get; set; }

        public override bool Equals(object obj)
        {
            return obj is OruzaniList ol && SerijskiBroj == ol.SerijskiBroj;
        }

        public override string ToString()
        {
            return "Serijski broj: " + SerijskiBroj + ", datum izdavanja: " + DatumIzdavanja + ", rok vazenja: " + RokVazenja + 
                    ", fabricki broj oruzja: " + FabrickiBroj + ", izdato osobi: " + OsobaId;
        }
    }
}
