using System;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj n:");
            int n;
            Int32.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Unesi {0} brojeva:", n);
            string broj = null;
            int num;
            int[] brojevi = new int[n];
            for(int i=0; i<n; i++)
            {
                broj = Console.ReadLine();
                Int32.TryParse(broj, out num);
                brojevi[i] = num;
            }
            bubbleSortNiz(brojevi);
            izbaciElementNiza(brojevi, 3);
            foreach (int nesto in brojevi) Console.WriteLine(nesto);
        }
        private static void bubbleSortNiz(int[] arr)
        {
            int i, j;
            for (i = 0; i < arr.Length - 1; i++)               
                for (j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        //isto kao i swap
                        (arr[j], arr[j + 1]) = (arr[j+1], arr[j]);

            foreach (int nesto in arr) Console.WriteLine(nesto);

        }
        //i ovdje je sve referenca, samo sto out saljemo kada nesto nije inicijalizirano
        private static void izbaciElementNiza(int[] arr, int element)
        {
            int brojac = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    brojac++;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        arr[j - 1] = arr[j];
                    }

                }
                    
            }
            for(int i = 0; i < arr.Length - brojac; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
