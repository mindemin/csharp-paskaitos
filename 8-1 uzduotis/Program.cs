using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            //Liepkite įvesti tris skaičius. Suraskite kuris iš šių skaičių yra didžiausias.
            Console.WriteLine("Iveskite tirs skaicius: ");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a>b && a>c)
            {
                Console.WriteLine("pirmas didziausias");
            }
            else if (b>c&&b>a)
            {
                Console.WriteLine("antras didziausias");
            }
           
            else if (c>a&&c>b)
            {
                Console.WriteLine("trecias didziausias");
            }
            else
            {
                Console.WriteLine("skaiciai lygus");
            }
            Console.ReadLine();
        }
    }
}
