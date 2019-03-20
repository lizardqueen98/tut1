using System;

namespace prviprogram
{
    class Program
    {
        const int MILJA = 1852;
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite brzinu broda u cvorovima:");
            string ulaz = Console.ReadLine();
            int brzina;
            Int32.TryParse(ulaz, out brzina);
            double speed = (brzina * MILJA) / 1000.0;
            Console.WriteLine("Brzina broda u km/h je {0}", speed);
            //Console.ReadLine();
        }
    }
}
