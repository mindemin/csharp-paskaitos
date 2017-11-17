using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 5;
            var daugiklis = 0;

            Console.WriteLine("{0}*{1}={2}",skaicius, daugiklis, skaicius*daugiklis++);
            Console.WriteLine("{0}*{1}={2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0}*{1}={2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0}*{1}={2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0}*{1}={2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0}*{1}={2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("5 * 6 = " + 5 * 6);
            Console.WriteLine("5 * 7 = " + 5 * 7);
            Console.WriteLine("5 * 8 = " + 5 * 8);
            Console.WriteLine("5 * 9 = " + 5 * 9);
            Console.WriteLine("5 * 10 = " + 5 * 10);
            
            Console.ReadLine();

        }
    }
}
