using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Indkapsling_Auto_Egenskab
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.forNavn = "Allan";
            p1.EfterNavn = "Hansen";
            Console.WriteLine(p1.forNavn + p1.EfterNavn);
            p1.FuldtNavn();
            Person p2 = new Person();
            p2.forNavn = "Allan";
            p2.EfterNavn = "H";
            Console.WriteLine(p2.forNavn + p2.EfterNavn);
            p2.FuldtNavn();
        }
    }

    public class Person
    {
        public string forNavn { get; set; }

        private string _efternavn;

        public string EfterNavn
        {
            get { return _efternavn; }
            set
            {
                if (value.Length < 3)
                { 
                    _efternavn = " ";
                }
                else
                { 
                    _efternavn = value;
                }
            }
        }
        public string FuldtNavn()
        {
            string _fuldtNavn = (forNavn + " " + _efternavn);
            Console.WriteLine($"Fuldt navn: {_fuldtNavn}.");
            return _fuldtNavn;
        }
    }
}
