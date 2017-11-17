using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius:");
            //Liepkite vartotojui įvesti du skaičius. Raskite kuris skaičius yra didesnis. Su viena if sąlyga (bei visomis jos dalimis) atlikite šiuos patikrinimus:
            //  ar pirmas skaičius didesnis už antrą skaičių;
            //ar antras skaičius didesnis už pirmą;
            // jei niekas neatitinka - tuomet skaičiai lygūs.
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            

            if (a>b)
            {
                Console.WriteLine("a>b");
            }
            else if (b>a)
            {
                Console.WriteLine("b>a");
            }
            else
            {
                Console.WriteLine("skaiciai lygus");
            }
            Console.ReadLine();
        }
    }
}
