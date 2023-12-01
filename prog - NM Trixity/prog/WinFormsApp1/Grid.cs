using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Grid
    {
        public int Index { get; set; }
        public string VezetékNév { get; set; }
        public string KeresztNév { get; set; }
        public int Fizetés { get; set; }
        public DateTime SzületésIdő { get; set; }

        public Grid(string sor)
        {
            var adat = sor.Split(";");
            VezetékNév = adat[0];
            KeresztNév = adat[1];
            Fizetés = int.Parse(adat[2]);
            SzületésIdő = DateTime.Parse(adat[3]);
            Index = int.Parse(adat[4]);
        }

        public override string? ToString()
        {
            return $"{Index};{VezetékNév};{KeresztNév};{Fizetés};{SzületésIdő}";
        }
    }
}
