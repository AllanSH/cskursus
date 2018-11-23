using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Variabler_text
{
    class Program
    {
        private const string Path = "C:\\temp\\test.txt";

        static void Main(string[] args)
        {
            string forNavn = "Mikkel";
            string efterNavn = "Cronberg";

            string samletNavn = forNavn + " " + efterNavn;
            Console.WriteLine(samletNavn);

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);

            string subNavn = samletNavn.Substring(7, 4);
            Console.WriteLine(subNavn);

            Console.WriteLine("Tab"+"\t"+forNavn+"\t"+efterNavn);
            Console.WriteLine("Tab" + "\r\n" + forNavn + "\r\n" + efterNavn);

            System.IO.File.WriteAllText(Path, samletNavn);
            System.IO.File.AppendAllText(Path, "\r\n");
            System.IO.File.AppendAllText(Path, forNavn);
            System.IO.File.AppendAllText(Path, "\r\n");
            System.IO.File.AppendAllText(Path, efterNavn);
            string[] indhold = System.IO.File.ReadAllLines(Path);

            Console.WriteLine(indhold);
            
           
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }
}
