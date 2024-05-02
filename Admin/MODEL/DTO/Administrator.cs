using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.MODEL.DTO
{
    internal class Administrator
    {
        public Osoba Id { get; set; }
        public String KorisnickoIme { get; set; }
        public String Lozinka { get; set; }
    }
}
