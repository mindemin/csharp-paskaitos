using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti bet kokį teigiamą skaičių. Parašykite šias atskiras if sąlygas:

            Console.WriteLine("Iveskite bet koki teigiama skaiciu: ");
            var a = Convert.ToInt32(Console.ReadLine());


            // patikrinti ar skaičius neigiamas, jei taip - aprėkti vartotoją:)
            if (a<=0)
            {
                Console.WriteLine("Juk prasiau ivesti TEIGIAMA skaiciu!!!!!");
            }
            // patikrinti ar skaičius teigiamas, jei taip - pasveikinti vartotoją;
            if (a>0)
            {
                Console.WriteLine("Sveikinu, pataikei!");
            }
            //patikrinti ar skaičius lyginis;
            if (a%2==0)
            {
                Console.WriteLine("Skaicius lyginis");
            }
            //  patikrinti ar skaičius dalinasi iš 4;
            if (a%4==0)
            {
                Console.WriteLine("Skaicius dalinasi is 4");
            }
            //  patikrinti ar skaičius yra didesnis nei 10.
            if (a>10)
            {
                Console.WriteLine("Skaicius didesnis uz 10");
            }
            Console.ReadLine();


        }
    }
}
