using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Iveskite varda: ");
            var vardas = Console.ReadLine();
            Console.WriteLine("Iveskite amziu metais: ");
            var amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jusu vardas " + vardas + ", o jusu amzius " + amzius);
            Console.ReadLine();
        }
    }
}
