using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Arv_Polymorfi_Dyr
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund() { Navn = "Rasmus" };
            h.SigNoget();
            Kat k = new Kat() { Navn = "Kat" };
            k.SigNoget();
            Console.WriteLine();

            // Opbygning af liste
            List<Dyr> forskelligeDyr = new List<Dyr>() { h, k, new Hund() { Navn = "c" }, new Kat() { Navn = "d" } };
            foreach (Dyr item in forskelligeDyr)
            {
                item.SigNoget();
            }
            Console.WriteLine();

            Dyr[] dyr = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }
            foreach (var item in dyr)
            {
                item.SigNoget();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        abstract class Dyr
        {
            private string navn;

            static System.Random rnd = new Random();
            public string Navn { get; set; }
            public virtual void SigNoget()
            {
                Console.WriteLine($"Jeg er et dyr og hedder {Navn}");
            }
            public static Dyr TilfældigtDyr()
            {
                string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
                data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
                data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
                data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";

                string[] navne = data.Split(';');
                int index = rnd.Next(0, navne.Length);
                if (index % 2 == 0)
                {
                    return new Hund() { Navn = navne[index] };
                }
                else
                {
                    return new Kat() { Navn = navne[index] };
                }
            }
        }
        class Hund : Dyr
        {
            public override void SigNoget()
            {
                Console.WriteLine($"Jeg er et hund og hedder {Navn}");
            }

        }
        class Kat : Dyr
        {
            public override void SigNoget()
            {
                Console.WriteLine($"Jeg er et kat og hedder {Navn}");
            }

        }
    }
}
