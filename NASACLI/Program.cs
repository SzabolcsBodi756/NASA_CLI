namespace NASACLI
{
    public class Program
    {

        public static List<Kuldetes> Kuldetesek = new List<Kuldetes>();

        static void Main(string[] args)
        {

            Beolvas("NASAmissions.txt");

            KuldetesSzam();

            KuldetesMegkeres();

            Console.WriteLine();

            MagasKockazatuKuldetesek();

            Console.WriteLine();

            LegkisebbHasznosTeher();

        }

        public static void Beolvas(string file)
        {

            StreamReader sr = new StreamReader(file);

            sr.ReadLine();

            while (!sr.EndOfStream)
            {

                Kuldetesek.Add( new Kuldetes(sr.ReadLine()));

            }

            sr.Close();
        }

        static void KuldetesSzam()
        {

            Console.WriteLine($"3. feladat: {Kuldetesek.Count()} küldetés található az állományban.");

        }

        static void KuldetesMegkeres()
        {

            bool megtalalta = false;

            int index = -1;

            do
            {

                Console.Write("4. Feladat: Adja meg egy küldetés nevének egy részletét: ");

                string nev = Console.ReadLine();

                for (int i = 0; i < Kuldetesek.Count(); i++)
                {

                    if (Kuldetesek[i].Nev.ToLower().Contains(nev.ToLower()))
                    {

                        index = i;
                        
                        megtalalta = true;

                    }

                }

            } while (!megtalalta);

            string sikeresseg = (Kuldetesek[index].Sikeres) ? "Sikeres" : "Sikertelen";

            Console.WriteLine($"Talált küldetés: {Kuldetesek[index].Nev}, {Kuldetesek[index].Ev}, {Kuldetesek[index].Celpont}, {sikeresseg}");
        }

        static void MagasKockazatuKuldetesek()
        {

            Console.WriteLine("5. feladat: Küldetések kockázati szintjei:");

            foreach (var item in Kuldetesek)
            {

                if (item.KockazatiSzint() == "Magas")
                {

                    Console.WriteLine($"{item.Nev}: Magas");

                }
            }
        }
        
        static void LegkisebbHasznosTeher()
        {

            double min = Kuldetesek[0].HasznosTeher;

            int index = 0;

            for (int i = 1; i < Kuldetesek.Count(); i++)
            {

                if (Kuldetesek[i].HasznosTeher < min)
                {

                    min = Kuldetesek[i].HasznosTeher;

                    index = i;

                }
            }

            Console.WriteLine($"6. feladat: A legkisebb hasznos teher: {Kuldetesek[index].HasznosTeher} kg ({Kuldetesek[index].Nev})");
        }
    }
}
