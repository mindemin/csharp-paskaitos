using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liepkite vartotojui įvesti bet kokį sveikąjį skaičių. Išveskite šio skaičiaus daugybos lentelę
            // nuo 1 iki 5. 
            // Pvz.:2 * 1 = 2
            // …2 * 5 = 10

            Console.WriteLine("Iveskite skaiciu: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = 1;
            Console.WriteLine("{0} * {1} = {2}", a,b,a*b++);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b++);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b++);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b++);
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b++);
            Console.ReadLine();

        }
    }
}
