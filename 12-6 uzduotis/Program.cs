using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //            6.(Pažengusiems) Sukurkite skaičių spėliojimo žaidimą.

Console.WriteLine("Atspekite skaiciu nuo 1 iki 10!");
            var atsitiktinis = new Random();
            var slaptas = atsitiktinis.Next(1,11); // 1-10
              
            int spejimas = 1;

            while (spejimas != slaptas)
            {
                Console.Write("Iveskite spejima: ");
                spejimas = Convert.ToInt32(Console.ReadLine());
                if (spejimas == slaptas)
                {
                    Console.WriteLine("Sveikinimai! skaicius atspetas.");
                }
                else if (spejimas < slaptas)
                {
                    Console.WriteLine("Slaptas skaicius yra didesnis nei " + spejimas);
                }
                else
                {
                    Console.WriteLine("Slaptas skaicius yra mazesnis nei " + spejimas);

                }
            }
            Console.ReadLine();

        }
    }
}
