using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASACLI
{
    public class Kuldetes
    {

        public string Nev { get; set; }

        public int Ev { get; set; }

        public string Celpont { get; set; }

        public int Legenyseg { get; set; }

        public bool Sikeres { get; set; }

        public string Leiras { get; set; }

        public double Koltseg { get; set; }

        public double HasznosTeher { get; set; }

        public Kuldetes(string nev, int ev, string celpont, int legenyseg, bool sikeres, string leiras, double koltseg, double hasznosTeher)
        {
            Nev = nev;
            Ev = ev;
            Celpont = celpont;
            Legenyseg = legenyseg;
            Sikeres = sikeres;
            Leiras = leiras;
            Koltseg = koltseg;
            HasznosTeher = hasznosTeher;
        }

        public Kuldetes(string adatok)
        {

            string[] sor = adatok.Split(';');

            Nev = sor[0];
            Ev = int.Parse(sor[1]);
            Celpont = sor[2];
            Legenyseg = int.Parse(sor[3]);
            Sikeres = (sor[4] == "Igen") ? true : false;
            Leiras = sor[5];
            Koltseg = double.Parse(sor[6]);
            HasznosTeher = double.Parse(sor[7]);
        }

        public string KockazatiSzint()
        {

            if (this.Koltseg > 1 && this.HasznosTeher > 10000)
            {

                return "Magas";

            }
            else if (this.Koltseg > 1 || this.HasznosTeher > 10000)
            {

                return "Közepes";

            }
            else
            {

                return "Alacsony";

            }
        }
    }
}
