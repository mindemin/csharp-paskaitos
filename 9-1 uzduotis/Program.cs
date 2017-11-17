using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius:");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            //Vartotojas įrašo tris skaičius ir programa patikrina ar pirmas skaičius:
   //      -yra 1, jei taip išveda visų trijų skaičių sumą;
    //        -yra 2, jei taip išveda pirmo ir trečio skaičių skirtumą;
       //     -yra 3, jei taip išveda antro ir trečio skaičių sandaugą;
            switch (a)
            {
                case 1:
                    Console.WriteLine(a+b+c);
                    break;
                case 2:
                    Console.WriteLine(a-c);
                    break;
                case 3:
                    Console.WriteLine(b*c);
                    break;

                   


                            
                     
            }
            Console.ReadLine();
        }
    }
}
