using System;
//neka biblioteka koja treba za fju distinct
using System.Linq;

namespace z7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj rijeci: ");
            int broj;
            Int32.TryParse(Console.ReadLine(), out broj);
            string[] niz = new string[broj];
            for(int i = 0; i < broj; i++)
            {
                niz[i] = Console.ReadLine();
            }
            Array.Sort(niz);
            Console.WriteLine("Prva rijec je: {0}, a zadnja {1}.", niz[0], niz[broj - 1]);
            //opet kao i ca fju Remove, promijeni, al kopiju
            niz = niz.Distinct().ToArray();
            foreach(var x in niz)
            {
                Console.WriteLine(x);
            }
        }
    }
}
