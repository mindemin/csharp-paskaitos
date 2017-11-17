using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //             12.(Pažengusiems) Parašyti for ciklą, kuris leistų vartotojui pasirinkti kiek fibonačiaus skaičių išvesti į ekraną.
            // Fibonačiaus sekoje kiekvienas skaičius yra lygus prieš jį ėjusių dviejų skaičių sumai: 1 1 2 3 5 8 13...
            //            1.Susikurkite tris sveikųjų skaičių kintamuosius, kurie jums padės tai pasiekti.
            //            1.Pirmi du kintamieji saugos paskutinius du skaičius.
            //             2.Trečiasis bus šių pirmų dviejų skaičių suma.
            //            2.Pirmus du skaičius išveskite ne cikle, o prieš jį ir ciklą pradėkite vykdyti nuo 2, o ne nuo 0.
            //            3.Kiekvieno ciklo metu turite perskaičiuot trečiąjį skaičių(pirmų dviejų skaičių sudėtis), tuomet pirmasis 
            // skaičius yra lygus antram, o antrasis lygus trečiam, išvesti į ekraną trečią skaičių.
            int a = 1;
            int b = 1;
            int c = 2;

            Console.WriteLine("Iveskite, kiek fibronaciaus skaiciu isvesti i ekrana");
           
            var ski = Convert.ToInt32(Console.ReadLine());

            if (ski<=2)
            {
                Console.WriteLine("Iveskite didesni skaiciu nei 2");
            }
            else
            {

            
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i < ski; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                
            }
            }
            Console.ReadLine();


        }
    }
}
