using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti bet kokį skaičių. Išvesite į ekraną šio skaičiaus kvadratą.

            Console.WriteLine("Iveskite skaiciu: ");
            var skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ivesto skaiciaus kvadratas yra " + skaicius*skaicius);
            Console.ReadLine();

        }
    }
}
