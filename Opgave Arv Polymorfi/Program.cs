using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Arv_Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktura f = new Faktura() { Nr = 1, Kunde = "abc", Dato = DateTime.Now.Date };
            Console.WriteLine(f);
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        class Faktura
        {
            public int Nr{ get; set; }
            public DateTime Dato { get; set; }
            public string Kunde { get; set; }

            public override string ToString()
            {
                return $"Faktura til {Kunde} nr {Nr} fra {Dato:D}.";
            }

        }
    }
}
