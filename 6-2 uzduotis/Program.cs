using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti egzamino rezultatą (0-100), su viena sąlyga, per atskiras else if dalis, patikrinti šias ribas:
            Console.WriteLine("Iveskite egzamino rezultata (0-100)");
            var rez = Convert.ToInt32(Console.ReadLine());

            //ar gautas rezultatas yra lygus 100;
            if (rez==100)
            {
                Console.WriteLine("Jusu rezultatas 100");
            }
            //ar gautas rezultatas yra lygus arba didesnis nei 80;
            else if (rez>=80)
            {
                Console.WriteLine("Jusu rezultatas daugiau nei 80");
            }
            //ar gautas rezultatas yra lygus arba didesnis nei 50;
            else if (rez>=50)
            {
                Console.WriteLine("Jusu rezultatas tarp 50 ir 80");
            }
            //ar gautas rezultatas yra lygus arba didesnis nei 20;
            else if (rez>=20)
            {
                Console.WriteLine("Jusu rezultatas tarp 20 ir 50");
            }
            //ar gautas rezultatas yra mažesnis nei 20;
            else if (rez<20)
            {
                Console.WriteLine("Jusu rezultatas maziau uz 20");
            }
           

            Console.ReadLine();

        }
    }
}
