using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_dato_tid
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt;
            DateTime d2;
            DateTime d3;

            dt = new DateTime(2018, 11, 23, 09, 47, 00);
            Console.WriteLine(dt);

            dt = dt.AddDays(10);
            Console.WriteLine(dt);

            dt = dt + new TimeSpan(0, 20, 0);
            Console.WriteLine(dt);

            dt = dt.AddMonths(-1);
            Console.WriteLine(dt);

            d2 = new DateTime(1975, 07, 23, 09, 47, 00);
            d3 = new DateTime(2018, 11, 23, 09, 47, 00);

            TimeSpan c = d3.Subtract(d2);
            Console.WriteLine($"Forskel mellem D2 og D3= {c.TotalDays}");

            TimeSpan t2 = new TimeSpan(16, 00, 00);
            Console.WriteLine(t2);

            TimeSpan t3 = new TimeSpan(00, 30, 00);
            Console.WriteLine(t3);

            TimeSpan t4 = t2.Subtract(t3);
            Console.WriteLine(t4);

            TimeSpan t5 = t2.Add(t3);
            Console.WriteLine(t5);

            String txtmdr = Convert.ToString(d2);
            Console.WriteLine(txtmdr);
            Console.WriteLine(txtmdr.Substring(6,4));



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
