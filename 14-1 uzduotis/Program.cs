using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //             1.Sugeneruokite atsitiktinio dydžio sąrašą, kurį užpildykite atsitiktiniais skaičiais nuo 1 iki 100.Raskite:
            //1.mažiausią skaičių;
            //            2.didžiausią skaičių;
            //            3.vidurkį;
            //            4.kiek skaičių yra žemesni už vidurkį;
            //           5.lyginių skaičių sumą;

            List<int> skaiciai = new List<int>(); // naujas listas

            var rnd = new Random(); // random generavimas
            var kiekSugeneruotti = rnd.Next(1, 101); // 1-100

            for (int i = 0; i < kiekSugeneruotti; i++)
            {
                skaiciai.Add(rnd.Next(1, 101)); // prideti sugeneruotus random skaicius.
                Console.WriteLine(i+1 + " skaicius " + skaiciai[i]);
            }

            // maziausias skaicius
            Console.WriteLine("maziausias skaicius: " + skaiciai.Min());
            // didziausias skaicius
            Console.WriteLine("maziausias skaicius: " + skaiciai.Max());
            // vidurkis
            Console.WriteLine("vidurkis: " + skaiciai.Average());
            // 4.kiek skaičių yra žemesni už vidurkį;
            var vidurkis = skaiciai.Average();
            var sk_maz = 0;
            foreach (var sk in skaiciai)
            {
                if (sk<vidurkis)
                {
                    sk_maz++;
                }
            }
            Console.WriteLine("mazesniu uz vidurki skaiciu yra: " + sk_maz);

            //           5.lyginių skaičių sumą; 

            var lyginiai = 0;
            foreach (var sk in skaiciai)
            {
                if (sk%2 ==0)
                {
                    lyginiai++;
                }
            }
            Console.WriteLine("lyginiu skaiciu yra: " + lyginiai);

            Console.ReadLine();

        }
    }
}
