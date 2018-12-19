using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_Events_FileWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.Changed += W_changed;
            w.Created += (s, e) => { Console.WriteLine("Oprettet " + e.FullPath); };
            w.Deleted += (s, e) => { Console.WriteLine("Slettet " + e.FullPath); };
            w.Changed += (s, e) => { Console.WriteLine("Rettet " + e.FullPath); };
            w.Renamed += (s, e) => { Console.WriteLine("Renavngivet fra " + e.OldFullPath + " " + "Renavngivet til " + e.FullPath); };
            
            do { } while (true);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        private static void W_changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name);
        }
    }
}
