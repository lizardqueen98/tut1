using System;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj n:");
            int n;
            Int32.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Unesi {0} brojeva:", n*n);
            int[,] niz = new int[n, n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    int broj;
                    Int32.TryParse(Console.ReadLine(), out broj);
                    niz[i, j] = broj;
                }
            }
            //i za max i za min u sustini postavljamo sume prvog reda/prve kolone
            int max = 0, min = 0, dijagonala = 0, brkolone = 0, brreda = 0;
            for (int i = 0; i < n; i++)
            {
                int summin = 0, summax = 0;
                for (int j=0; j < n; j++)
                {
                    summin += niz[i, j];
                    if (i == j) dijagonala += niz[i, j];
                    summax += niz[j, i];
                }
                if (summin < min || min == 0)
                {
                    min = summin;
                    brreda = i+1;
                }
                if (summax > max)
                {
                    max = summax;
                    brkolone = i + 1;
                }
            }
            Console.WriteLine("max min i dijagonala su: {0}, {1}, {2}.",max, min, dijagonala);
            Console.WriteLine("minred i maxkolona su: {0}, {1}.", brreda, brkolone);
        }
    }
}
