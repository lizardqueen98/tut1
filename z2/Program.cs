using System;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj:");
            int broj;
            Int32.TryParse(Console.ReadLine(), out broj);
            Console.WriteLine(broj);
            int brojZvjezdica = 1;
            for(int i=0; i<broj; i++)
            {
                string izlaz = "";
                for(int j=1; j<=brojZvjezdica; j++)
                {
                    izlaz += "*";
                
                }
                brojZvjezdica += 2;
                Console.WriteLine(izlaz);
            }
        }
    }
}
