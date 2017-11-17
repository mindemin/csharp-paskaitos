using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite įvesti tris skaičius. Suraskite kuris iš šių skaičių yra maziausias.
            Console.WriteLine("Iveskite tirs skaicius: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("pirmas maziausias");
            }
            else if (b < c && b < a)
            {
                Console.WriteLine("antras maziausias");
            }

            else if (c < a && c < b)
            {
                Console.WriteLine("trecias maziausias");
            }
            else
            {
                Console.WriteLine("skaiciai lygus");
            }
            Console.ReadLine();
        }
    }
}
