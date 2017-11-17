using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti penkis savo pažymius, raskite šių pažymių vidurkį, 
            // patikrinkite ar vidurkis yra lygus arba didesnis už 5.
            Console.WriteLine("Iveskite penkis savo pazymius");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            var d = Convert.ToDouble(Console.ReadLine());
            var e = Convert.ToDouble(Console.ReadLine());
            double vid = (a + b + c + d + e) / 5;
            var vidd = (double)(a + b + c + d + e) / 5;

            Console.WriteLine("Jusu pazymiu vidurkis: " + vidd);
            if (vid>=5)
            {
                Console.WriteLine("Jusu pazymiu vidurkis daugiau arba lygus 5");
            }
            Console.ReadLine();
        }
    }
}
