using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tura5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region prvi

            Osoba o1 = new Osoba
            {
                Sifra = 1,
                Ime = "Toni",
                Adresa = "Zagrebacka 1",
                Godine = 32
            };
            Osoba o2 = new Osoba
            {
                Sifra = 1,
                Ime = "Toni",
                Adresa = "Zagrebacka 1",
                Godine = 32
            };
            var provjera = o1.Equals(o2); //prvi

            #endregion

    
            drugi(o1, o2);
            treci();
            Cetvrti(o1);

            Console.ReadLine();
        }

        private static void drugi(Osoba o1, Osoba o2)
        {

            Console.WriteLine("Drugi");
            o2.Ime = "Zarko";
            Osoba o3 = new Osoba
            {
                Sifra = 1,
                Ime = "Matej",
                Adresa = "Zagrebacka 12",
                Godine = 33
            };
            Osoba o6 = new Osoba
            {
                Sifra = 1,
                Ime = "Ranko",
                Adresa = "Koprivnica 1",
                Godine = 34
            }; Osoba o4 = new Osoba
            {
                Sifra = 1,
                Ime = "Ivana",
                Adresa = "Zagrebacka 112",
                Godine = 21
            };
            Osoba o5 = new Osoba
            {
                Sifra = 1,
                Ime = "Karla",
                Adresa = "Istra 1",
                Godine = 41
            };

            List<Osoba> osobe = new List<Osoba> { o1, o2, o3, o4, o5, o6 };
            osobe.Sort();
            foreach (Osoba o in osobe)
            {
                Console.WriteLine(o.Ime + " " + o.Godine);
            }
            Console.WriteLine();
            osobe.Sort((os, os2) => os.Ime.CompareTo(os2.Ime) + os.Godine.CompareTo(os2.Godine));
            foreach (Osoba o in osobe)
            {
                Console.WriteLine(o.Ime + " " + o.Godine);
            }
        }

        private static void treci()
        {
            Console.WriteLine("\nTreci");

            Queue<int> red = new Queue<int>();
            Stack<int> stog = new Stack<int>();

            red.Enqueue(1);
            red.Enqueue(2);
            red.Enqueue(3);
            red.Enqueue(4);

            foreach (var o in red.ToList())
            {
                Console.WriteLine(o);
                stog.Push(red.Dequeue());
            }

            while (stog.Count > 0)
            {
                Console.WriteLine(stog.Pop());
            }
        }

        private static void Cetvrti(Osoba o1)
        {
            Console.WriteLine("\nCetvrti");
            StringBuilder sb = new StringBuilder();

            sb.Append("Osoba1 je Toni,");
            sb.AppendLine("Toni zivi u zagrebackoj 1.");
            sb.AppendFormat("Star je {0} godina.", o1.Godine);

            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
