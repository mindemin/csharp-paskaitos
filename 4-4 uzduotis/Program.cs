using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti tris skaičius. Išveskite visų šių skaičių sumą, skirtumą, sandaugą ir dalmenį, 
            //nurodant atliekamus veiksmus ir šių skaičių reikšmes ekrane. Pvz.:5 + 3 + 8 = 165 - 3 - 8 = -6

            Console.WriteLine("Iveskite tris skaicius: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} + {2} = {3}", a,b,c,a+b+c);
            Console.WriteLine("{0} - {1} - {2} = {3}", a, b, c, a - b - c);
            Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, a * b * c);
            Console.WriteLine("{0} / {1} / {2} = {3}", a, b, c, a / b / c);
            Console.ReadLine();

            
        }
    }
}
