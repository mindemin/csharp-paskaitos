using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite  skaiciu:");
            //Liepkite vartotojui įvesti vieną norimą skaičių. Su viena if sąlyga (ir visomis jos dalimis), patikrinkite šiuos dalykus:
           // ar skaičius neigiamas;
            //ar skaičius teigiamas;
            //ar skaičius lygus 0
            var a = Convert.ToInt32(Console.ReadLine());
            
            if (a <0)
            {
                Console.WriteLine("skaicius neigiamas");
            }
            else if (a>0)
            {
                Console.WriteLine("skaicius teigiamas");
            }
            else
            {
                Console.WriteLine("skaicius lygus 0");
            }
            Console.ReadLine();
        }
    }
}
