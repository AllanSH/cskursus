using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Delegates_helt_grundlæggende
{
    //public delegate void MinDelegate1(string t); //Skal ikke bruges til action
    class Program
    {
        static void Main(string[] args)
        {
            //MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);   //Delegate
            Action<string> f1 = MinSkrivTilConsole;                     //Action frem for Delegate
            f1.Invoke("test");

            //MinDelegate1 f2 = MinSkrivTilConsole;
            Action<string> f2 = MinSkrivTilConsole;
            f2("test");

            //MinDelegate1 f3 = MinSkrivTilConsole;
            Action<string> f3 = MinSkrivTilConsole;
            f3 += Console.WriteLine;
            f3("test");

            f3?.Invoke("Test f3 med ?");

            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= Console.WriteLine;

            f3?.Invoke("Test f3 med ? efter null");

            //if (f1 != null)
            //    f1.Invoke(" "); // Fejler da der ingen reference er længere
            //else
            //    Console.WriteLine("F2 is null");
            try
            {
                f1.Invoke(" "); // Fejler da der ingen reference er længere
            }
            catch (NullReferenceException)
            {

                Console.WriteLine("F2 is null i try");
            }
           
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }
    }
}
