using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //            7.Raskite visų lyginių skaičių nuo 20 iki 50 sumą.

            var suma = 0;
            for (int i = 20; i <= 50; i++)
            {
                if (i%2==0)
                {
suma += i;
                }
                
            }
            Console.WriteLine(suma);
            Console.ReadLine();

          
        }
    }
}
