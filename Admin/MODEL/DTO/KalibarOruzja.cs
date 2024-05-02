using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.MODEL.DTO
{
    internal class KalibarOruzja
    {
        public string Kalibar { get; set; }

        public override bool Equals(object obj)
        {
            return obj is KalibarOruzja kalibar && Kalibar == kalibar.Kalibar;
        }

        public override string ToString()
        {
            return "Kalibar oruzja: " + Kalibar;
        }
    }
}
