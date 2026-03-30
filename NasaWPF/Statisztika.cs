using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaWPF
{
    internal class Statisztika
    {

        public string Kategoria { get; set; }

        public int Darab { get; set; }

        public string AtlagTeher { get; set; }

        public string AtlagKoltseg { get; set; }

        public Statisztika(string kategoria, int darab, string atlagTeher, string atlagKoltseg)
        {
            Kategoria = kategoria;
            Darab = darab;
            AtlagTeher = atlagTeher;
            AtlagKoltseg = atlagKoltseg;
        }
    }
}
