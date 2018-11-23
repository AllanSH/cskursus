using System;

namespace Testkode
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Test");
            string tekst = Console.ReadLine();
            //Console.WriteLine(ToUpper(tekst));
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }



        }
    }
}
