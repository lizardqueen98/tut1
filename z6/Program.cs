using System;

namespace z6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite tekst: ");
            string rijec = Console.ReadLine();
            Console.WriteLine(IzbrisiPodstring(rijec, "nadija"));
            Console.WriteLine("Trazeni podstring se nalazio na poziciji: {0}", NadjiPodstring(rijec, "nadija"));
        }
        public static string IzbrisiPodstring(string s1, string s2)
        {
            string povratni = s1;
            while (povratni.Contains(s2))
            {
                int ind = povratni.IndexOf(s2);
                //fja Remove ne mijenja konkretan string na koji je primjenjena, vraca novi string
                povratni = povratni.Remove(ind,s2.Length);
            }
            return povratni;
        }
        public static int NadjiPodstring(string s1, string s2)
        {
            if (s1.Contains(s2)) return s1.IndexOf(s2);
            return -1;
        }

    }
    
}
