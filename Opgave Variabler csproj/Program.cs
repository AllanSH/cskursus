using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int heltal = 10;
            double kommatal = 12.5;
            double res = 0;
            double res2 = 0;

            heltal++;
            Console.WriteLine(heltal);
            heltal--;
            Console.WriteLine(heltal);
            heltal += 20;
            Console.WriteLine(heltal);

            kommatal++;
            Console.WriteLine(kommatal);
            kommatal--;
            Console.WriteLine(kommatal);
            kommatal *= 2;
            Console.WriteLine(kommatal);

            res = kommatal * heltal;
            Console.WriteLine(res);

            Console.WriteLine($"Dette er resultatet {res} i res");

            for (int i = 0; i < 10; i++)
            {
                res *= 2;
                Console.WriteLine($"Dette er resultatet {res} i res");
            }

            res2 = res / 30;
            Console.WriteLine($"Dette er resultatet {res2} i res2");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }   

        }
    }
}
