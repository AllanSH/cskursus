using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Fejlhåndtering
{
    class Program
    {
        static void Main(string[] args)
        {
            int antal = 0;
            do
            {
                antal++;
                try
                {
                    Run();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Der må kun indtastes tal. Antal forsøg " + antal);
                } 
            } while (antal < 3);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("Resultatet er " + res);
        }
    }
}
