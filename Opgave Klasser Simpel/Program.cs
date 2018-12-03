using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Klasser_Simpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.EfterNavn = "Cronberg";
            p1.ForNavn = "Mathias";
            p1.FødselsÅr = 2006;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());

            Person p2 = new Person("Mikkel","Cronberg", -2006);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.EstimeretAlder());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }

    class Person
    {
        public string ForNavn;
        public string EfterNavn;
        public int FødselsÅr;

        public string FuldtNavn()
        {
            return $"{this.ForNavn} {this.EfterNavn}";
        }
        public int EstimeretAlder()
        {
            int År = DateTime.Now.Year;
            return År - this.FødselsÅr;
        }

        public Person() :this("","",0)
        {
            //this.ForNavn = "";
            //this.EfterNavn = "";
        }
        public Person(string ForNavn,string EfterNavn,int FødselsÅr)
        {
            this.ForNavn = ForNavn;
            this.EfterNavn = EfterNavn;
            //this.FødselsÅr = FødselsÅr;
            CheckFørdselsÅr(FødselsÅr);
        }

        private void CheckFørdselsÅr(int FødselsÅr)
        {
            if (this.FødselsÅr <= 0) { Console.WriteLine("You have a wrong input"); }
            else
            {
                this.FødselsÅr = FødselsÅr;
            }
        }
    }
}
