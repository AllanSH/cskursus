using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{

    public delegate void Delegate1();
    public delegate void Delegate2(int a);
    public delegate int Delegate3(int a, int b);
    public delegate void Delegate4(string t);
    public delegate void DelegateVoidString(string t);
    public delegate void DelegateVoidStringString(string t, string t2);


    class Program
    {



        static void Main(string[] args)
        {
            Test1();

            Delegate1 f1 = new Delegate1(Test1);
            f1.Invoke();
            MinMetode(1, 1, f1);
            Console.WriteLine();
            Test2("a");
            Test3("b");

            Console.WriteLine();

            Delegate4 f2 = new Delegate4(Test2);
            f2 += Test3;
            f2 += Console.WriteLine;
            f2.Invoke("c-+-c");
            f2 -= Console.WriteLine;
            Console.WriteLine();
            f2.Invoke("c-+-c");

            Console.WriteLine();

            Maskine m = new Maskine();
            m.LogFunktion = new Delegate4(LogTilFil);
            m.LogFunktion += Console.WriteLine;
            m.Start();

            Console.WriteLine("------");

            Delegate4 f1a = new Delegate4(Test2);
            f1a("");

            Delegate4 f2a = Test2;
            f2a += Console.WriteLine;
            f2a += Console.WriteLine;
            f2a += Console.WriteLine;
            f2a += Console.WriteLine;
            f2a += Console.WriteLine;
            f2a += Console.WriteLine;
            f2a("*****");
            //foreach (var item in f2a.GetInvocationList())
            //{
            //    item.DynamicInvoke();
            //}

        }

        static void LogTilFil(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt);
        }

        static void Test2(string txt)
        {
            Console.WriteLine("I test2 " + txt);
        }

        static void Test3(string txt)
        {
            Console.WriteLine("I test3 ***** " + txt);
        }

        static void MinMetode(int a, int b, Delegate1 done)
        {
            // gør noget med a og b
            //done.Invoke();
            if (done != null)
                done.Invoke();

        }

        static void Test1()
        {
            Console.WriteLine("I Test1");
        }
    }

    class Maskine
    {
        public Delegate4 LogFunktion;
        public void Start()
        {
            if (LogFunktion != null)
                LogFunktion.Invoke("Starter maskine");
            // starter...
            if (LogFunktion != null)
                LogFunktion.Invoke("Maskine startet");
        }
    }

    class A
    {
        public void Test() { }
    }
}
