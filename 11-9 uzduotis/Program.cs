using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //             7.Raskite visų nelyginių skaičių nuo 30 iki 60 sumą.



            var suma = 0;
            for (int i = 30; i <= 60; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
