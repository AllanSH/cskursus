using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_LINQ_to_Objects_person
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(10);

            //foreach (var person in people)
            //    Console.WriteLine(person.Name);

            Console.WriteLine();
            Console.WriteLine($"Order By Name");

            var res1 = people.OrderBy(i => i.Name);
            var res1l = from person in people orderby person.Name select person;
            foreach (var person in res1)
                Console.WriteLine(person.Name);

            Console.WriteLine();
            Console.WriteLine($"Order By Gender + Name");


            var res2 = people.OrderBy(i => i.Gender).ThenBy(i => i.Name);
            var res2l = from person in people orderby person.Gender, person.Name select person;
            foreach (var person in res2)
                Console.WriteLine(person.Gender + " " + person.Name);
            Console.WriteLine();
            Console.WriteLine($"Filtrer under over 170");

            var res3 = people.Where(I => I.Height < 170);
            var res3l = from person in people where person.Height<170 select person;
                        foreach (var person in res3)
                Console.WriteLine(person.Name + " " + person.Height);

            Console.WriteLine();
            Console.WriteLine($"Filtrer under over 170 + healthy er true");

            var res4 = people.Where(I => I.Height < 170 && I.IsHealthy);
            foreach (var person in res4)
                Console.WriteLine(person.Name + " " + person.Height + " " + person.IsHealthy);

            Console.WriteLine();
            Console.WriteLine($"Gruppere efter Gender");

            var res5 = people.GroupBy(I => I.Gender);
            foreach (var group in res5)
            { 
                Console.WriteLine(group.Key);
                foreach (var person in group)
                    Console.WriteLine(" => " + person.Name + " " + person.Gender);
            }

            Console.WriteLine();
            Console.WriteLine($"Sorter og udskriv navn - Anonymt objekt");

            var res6 = people.OrderBy(i => i.Name).Select(i => new { Name = i.Name, Height = i.Height });
            foreach (var person in res6)
            {
                Console.WriteLine(person.Name + " " + person.Height);
            }

            Console.WriteLine();
            Console.WriteLine($"Grupper og sorter efter Height således der skabes grupper");

            int[] range = { 160, 170, 180, 190, 200, 210, 220 };
            var res7 = people.OrderBy(i => i.Height).GroupBy(i => range.FirstOrDefault(x => x > i.Height));
            foreach (var group in res7)
            {
                Console.WriteLine(group.Key);
                foreach (var person in group)
                {
                    Console.WriteLine(" => " + person.Name + " " + person.Height);
                }
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
