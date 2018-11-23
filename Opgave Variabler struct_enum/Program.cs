using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Variabler_struct_enum
{
    class Program
    {
        static void Main(string[] args)
        {

            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            Person p = new Person(0, "Mikkel", Køn.Mand);
            
            Console.WriteLine(p.Navn);
            Console.WriteLine(p.Id);
            Console.WriteLine(p.Køn);
        }

    }
    
}
