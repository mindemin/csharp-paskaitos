using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //             7.Raskite visų skaičių nuo 1 iki 100 sumą.
            var suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);
            Console.ReadLine();


        }
    }
}
