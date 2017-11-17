
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //             1.Liepkite vartotojui įvesti teigiamą skaičių. Ciklo pagalba šį skaičių išvesti mažėjimo tvarka 
            // iki kol jis pasieks 0.Pvz.: 5 4 3 2 1.Kiekvieną kartą išvesti skirtingose eilutėse.

            Console.WriteLine("Iveskite teigiama skaiciu: ");
            var sk = Convert.ToInt32(Console.ReadLine());

            while (sk > 0)
            {
                Console.WriteLine(sk--);
           
            }
            Console.ReadLine();

        }
    }
}
