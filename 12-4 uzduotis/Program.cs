using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //             4.Sukurkite string tipo kintamąjį.Prie jo vis pridėkite vartotojo įrašomus skirtingus žodžius.
            // Tačiau jei vartotojas įrašytų “exit” -baigti ciklą.Baigus vykdyti ciklą turi būti išvestas string kintamasis prie kurio 
            //vis buvo pridedami skirtingi žodžiai.

            string zodis = "sss";
            string galutinis = "";

            while (zodis!="exit")
            {
                Console.Write("Iveskite zodi arba exit: ");
                zodis = Console.ReadLine();
                if (zodis!="exit")
                {
galutinis += zodis + " ";
                }
          
            }
            Console.WriteLine(galutinis + " ");
            Console.ReadLine();
        }
    }
}
