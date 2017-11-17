using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //        Liepkite įvesti trijų egzaminų rezultatus.Suraskite pažymių vidurkį.Atlikite šiuos patikrinimus:
            //      ar gautas vidurkis yra[8 - 10];
            //    ar gautas vidurkis yra[5 - 7];
            //  ar gautas vidurkis yra < 5.
            Console.WriteLine("Iveskite tirs rezultatus: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var vid = (double)(a + b + c) / 3;
            Console.WriteLine(vid);
            if (vid>=8&&vid<=10)

            {
                Console.WriteLine("vidurkis yra tarp 8-10");
            }
            else if (vid>=5&&vid<8)
            {
                Console.WriteLine("vidurkis tarp 5-8");
            }
            else if (vid<5)
            {
                Console.WriteLine("vidurkis maziau uz 5");
            }
            Console.ReadLine();
        }
    }
}
