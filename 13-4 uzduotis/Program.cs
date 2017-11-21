using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // (pažengusiems) Sukurkite programą, kuri į masyvą sudėtų 10 fibonačiaus sekos skaičių.

            Console.WriteLine("Iveskite, kiek Fibronaciaus sekos skaiciu norite isvesti i ekrana: ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            int[] masyvas = new int[kiek];
            masyvas[0] = 1;
            masyvas[1] = 1;
            for (int i = 2; i < masyvas.Length; i++)
            {
                masyvas[i] = masyvas[i - 1] + masyvas[i - 2];
            }
            foreach (var skaicius in masyvas)
            {
                Console.Write(skaicius + " ");
            }
            Console.ReadLine();
       
        }
    }
}
