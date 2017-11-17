using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti bet kokį simbolį. Atspausdinkite 3x3 kvadratą iš to simbolio.

            Console.WriteLine("Iveskite simboli: ");
            var simb = Console.ReadLine();
            Console.WriteLine(simb+simb+simb);
            Console.WriteLine(simb + simb + simb);
            Console.WriteLine(simb + simb + simb);
            Console.ReadLine();

        }
    }
}
