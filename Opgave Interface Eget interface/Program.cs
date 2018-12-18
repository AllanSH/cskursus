using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Interface_Eget_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund();
            h.Gem();
            Ubåd u = new Ubåd(Nummer : 1,Tubine : 12345);
            u.Gem();

            IDbFunktioner[] array = new IDbFunktioner[4];
            array[0] = new Hund();
            array[1] = new Ubåd(Nummer: 2, Tubine: 22345);
            array[2] = new Hund();
            array[3] = new Ubåd(Nummer: 3,Tubine : 32345);
            foreach (var item in array)
            {
                item.Gem();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        interface IDbFunktioner
        {
            void Gem();
        }

        class Hund : IDbFunktioner
        {
            public string Navn { get; set; }
            public void Gem()
            {
                Console.WriteLine($"Gemmer Hund");
            }
        }

        class Ubåd : IDbFunktioner
        {
            public Ubåd(int Nummer, int Tubine)
            {
                this.Nummer = Nummer;
                this.Tubine = Tubine;
            }

            public int Nummer { get; private set; }
            public double Tubine { get; private set; }
            public void Gem()
            {
                Console.WriteLine($"Gemmer Ubåd {Nummer} Tubine {Tubine}");
            }
        }
    }
}
