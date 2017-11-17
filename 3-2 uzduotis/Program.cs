using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 3;
            var b = a * a;
            var c = b * a;
            Console.WriteLine("Skaicius = {0}", a);
            Console.WriteLine("Kvadratas = {0}", b);
            Console.WriteLine("Kubas = {0}", c);

            Console.WriteLine("Kubas2 = " + a*a*a);
           
            

            Console.ReadLine();
        }
    }
}
