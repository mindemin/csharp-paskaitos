using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti tris sveikuosius skaičius. Parašykite šias atskiras if sąlygas:
            Console.WriteLine("Iveskite tris sveikuosius skaicius: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            //patikrinkite ar pirmas ir antras skaičiai yra lygūs;

            if (a==b)
            {
                Console.WriteLine("Pirmas ir antras skaiciai lygus");
            }

            //patikrinkite ar antras ir trečias skaičiai yra lygūs;

            if (b==c)
            {
                Console.WriteLine("Trecias ir antras skaiciai lygus");
            }
            //patikrinkite ar pirmas skaičius yra didesnis už antrąjį;
            if (a>b)
            {
                Console.WriteLine("Pirmas skaicius yra didesnis uz antraji");
            }
            //patikrinkite ar antras skaičius yra didesnis už dvigubą trečiojo skaičiaus reikšmę
            //(trečias skaičius padaugintas iš dviejų);

            if (b>(c*2))
            {
                Console.WriteLine("antras skaičius yra didesnis už dvigubą trečiojo skaičiaus reikšmę");
            }
            // patikrinkite ar pirmas skaičius yra lyginis (dalinti per % ir žiūrėti ar gautas atsakymas yra lygus nuliui);
            if (a%2==0)
            {
                Console.WriteLine("pirmas skaičius yra lyginis");
            }
            // patikrinkite ar antras skaičius skaičius yra nelyginis(dalinti per % ir žiūrėti ar gautas atsakymas nėra lygus nuliui);
            if (b%2!=0)
            {
                Console.WriteLine("antras skaičius yra nelyginis");
            }
            // patikrinkite ar trečias skaičius yra teigiamas (daugiau už 0);
            if (c>0)
            {
                Console.WriteLine("trečias skaičius yra teigiamas");
            }
            // patikrinkite ar trečias skaičius yra neigiamas (mažiau už 0).
            if (c<0)
            {
                Console.WriteLine("trečias skaičius yra neigiamas");
            }

            Console.ReadLine();
        }
    }
}
