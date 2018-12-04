using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Indkapsling_simpel_egenskab
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "Vare #1";
            v.Pris = 100;
            //Console.WriteLine(V.PrisMedMoms());
            v.PrisMedMoms();
            Vare v2 = new Vare("Vare #2", 200);
            //Console.WriteLine(V2.PrisMedMoms());
            v2.PrisMedMoms();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
    public class Vare
        {
        public Vare()
        {
        }

        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }


        private string navn;
        public string Navn
        {
            get
            {
                Console.WriteLine("Nu aflæses Navn ");
                return this.navn;
            }
            set
            {
                this.navn = value;
                Console.WriteLine("Nu tildeles Navn " + this.navn);
            }

        }

        private double pris;

        public double Pris
        {
            get
            {
                Console.WriteLine("Nu aflæses pris ");
                return this.pris;
            }
            set
            {
                this.pris = value;
                Console.WriteLine("Nu tildeles pris " + this.pris);
            }
        }
        public double PrisMedMoms()
        {
            double prisMoms = this.pris * 1.25;
            Console.WriteLine("Dette er prisen med Moms " + prisMoms);
            return prisMoms;
            //return this.pris * 1.25;
        }
    }
}
