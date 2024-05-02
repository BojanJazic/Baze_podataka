using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.MODEL.DTO
{
    internal class LovniKalendarDivljaci
    {
        public Divljac DivljacId { get; set; }
        public LovniKalendar KalendarLovaId { get; set; }
        public int Brojnost { get; set; }
    }
}
