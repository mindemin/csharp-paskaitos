﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti tris skaičius, parašyti šią patikrinimo sąlygą, naudojant else if dalis:
            //    ar pirmas skaičius didesnis už antrą;
            //    ar antras skaičius didesnis už trečią;
            //   ar trečias skaičius skaičius didesnis už pirmą;
            //   ar skaičiai lygūs;

            Console.WriteLine("Iveskite tris skaicus: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine("a>b");
            }
            else if (b>c)
            {
                Console.WriteLine("b>c");
            }
            else if (c>a)
            {
                Console.WriteLine("c>a");
            }
            else if (a==b)
            {
                if (b==c)
                {
 
Console.WriteLine("skaiciai lygus");
                }
               
            }
            Console.ReadLine();

        }
    }
}
