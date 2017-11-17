using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 45;
            Console.WriteLine("skaicius yra " + a);
            var pirmas = a / 10;
            var antras = a % 10;
            Console.WriteLine("pirmas skaitmuo " + pirmas);
            Console.WriteLine("antras skaitmuo " + antras);
            Console.WriteLine("Skaitmenu sandauga " + pirmas * antras);
            

            Console.ReadLine();


        }
    }
}
