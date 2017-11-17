using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rasti visų skaičių, žemesnių už 1000 ir kurie dalinasi iš 3 arba 5, sumą.
            // Pavyzdys:
            //   Visi skaičiai mažesni už 10 ir kurie dalinasi iš 3 arba 5 yra: 3, 5, 6, 9.
            // Šių skaičių suma yra 23.
            //Turite gauti 233168 atsakymą
            var suma = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i%3==0 || i%5==0)
                {
                    suma += i;
                }

            }
            Console.WriteLine(suma);
            Console.ReadLine();


        }
    }
}
