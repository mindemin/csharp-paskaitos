using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pvz
{
    class Program
    {
        static void Main(string[] args)
        {

            //   1.Parašyti for, kuris išvestų kiekvieną skaičių pradedant nuo 0 ir baigiant 10.Kiekvieną skaičių išvesti skirtingoje eilutėje.



            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            //Parašyti for, kuris išvestų kas antrą skaičių pradedant 0 ir baigiant 15. Kiekvieną skaičių išvesti 
            //toje pačioje eilutėje, po kiekvieno skaičiaus dedant tarpą.

            for (int i = 0; i < 15; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 1.Parašyti for, kuris išvestų kas trečią skaičių, pradedant 1 ir baigiant 20.
            //Kiekvieną skaičių išvesti toje pačioje eilutėje tačiau apskliaudžiant laužtiniais skliaustais.Pvz.: [1][3][5]...

            for (int i = 1; i < 20; i += 3)
            {
                Console.Write("[" + i + "]");
            }
            Console.WriteLine();

            //4 Parašyti for, kuris eitų pro kiekvieną skaičių nuo 1 iki 10.Jame apsirašyti if sąlygą,
            //kuri patikrintų ar dabartinis skaičius yra lyginis, jei taip tai šį skaičių išvesti.

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //5 Liepkite vartotojui įvesti rėžių pradžią ir pabaigą. Patikrinkite, kad tai būtų validu 
            //(pradžia turi būti mažesnė nei pabaiga). Jei rėžiai tinkami, tuomet vykdyti for, kuris atskirose 
            //eilutėse išvestų kiekvieną skaičių iš tų rėžių, bei atskiriant tarpu - tų skaičių kvadratus.
            Console.WriteLine("Iveskite rezio pradzia: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite rezio pabaiga: ");
            var b = Convert.ToInt32(Console.ReadLine());
            if (b <= a)
            {
                Console.WriteLine("neteisingas rezis:");
            }
            else
            {
                var sk = b - a + 1;
                for (int i = 0; i < sk; i++)
                {
                    Console.Write(a);
                    Console.WriteLine(" " + a * a++);
                }
            }


            //6 Liepkite vartotojui įvesti rėžių pradžią ir pabaigą. Patikrinkite, kad tai būtų validu
            // (pradžia turi būti mažesnė nei pabaiga). Jei rėžiai tinkami, tuomet vykdyti for, kuris
            //iš duotų skaičių išvestų visus nelyginius skaičius arba tuos, kurie dalinasi iš 8.
            Console.WriteLine("Iveskite rezio pradzia: ");
            var ea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite rezio pabaiga: ");
            var eb = Convert.ToInt32(Console.ReadLine());
            if (eb <= ea)
            {
                Console.WriteLine("neteisingas rezis:");
            }
            else
            {
                var esk = eb - ea + 1;
                for (int i = 0; i < esk; i++)
                {
                    if (ea % 2 != 0 || ea % 8 == 0)
                    {
                        Console.WriteLine(ea);
                    }
                    ea++;
                }
                Console.ReadLine();

            }
        }
    }
}
