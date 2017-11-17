using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti tris skaičius. Į ekraną išveskite šiuos skaičius ir jų vidurkį. 
            // Pvz.:Įvestų skaičių 4, 5, 8 vidurkis: 5,6.

            Console.WriteLine("Iveskite tris skaicius: ");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            var d = (a + b + c) / 3;
            Console.WriteLine("Skaiciu vidurkis: " + Math.Round(d,2));
            Console.ReadLine();

        }
    }
}
