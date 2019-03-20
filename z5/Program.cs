using System;
using System.Text.RegularExpressions;

namespace z5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite tekst: ");
            string palindrom = Console.ReadLine();
            string izlaz = daLiJePalindrom(palindrom) ? "je" : "nije";
            Console.WriteLine("Uneseni tekst {0} palindrom", daLiJePalindrom(palindrom) ? "je" : "nije");
            /* Char.ToLower() ne mijenja string
            string nadija = "Nadija";
            Console.WriteLine(Char.ToLower(nadija[0]));
            Console.WriteLine(nadija);*/
        }
        static bool daLiJePalindrom(string tekst)
        {
            string pom = Reverse(tekst);
            int j = 0;
            for(int i = 0; i < tekst.Length; i++)
            {
                Regex rgx = new Regex("[A-Za-z]");
                if (!rgx.IsMatch(tekst[i].ToString())) i++;
                if (!rgx.IsMatch(pom[j].ToString())) j++;
                if (Char.ToLower(tekst[i]) != Char.ToLower(pom[j])) return false;
                j++;
            }
            return true;
        }
        //sa interneta
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
