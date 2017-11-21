using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1_uzduotis_masyvas
{
    class Program
    {
        static void Main(string[] args)
        {

            //  1.Susikurkite savaitės temperatūrų rodmenų masyvą. Raskite:

 //            1.žemiausią temperatūrą;
            double[] temperaturos = { 14.5, 18.5, 20.4, -30 };

            var zemiausia = temperaturos[0];
            foreach (var temperatura in temperaturos)
            {
                if (temperatura<zemiausia)
                {
                    zemiausia = temperatura;
                }
            }
            Console.WriteLine(zemiausia + "  -  tai zemiausia temperatura");

 //            2.didžiausią temperatūrą;
            var auksciausia = temperaturos[0];
            foreach (var temperatura in temperaturos)
            {
                if (temperatura > auksciausia)
                {
                    auksciausia = temperatura;
                }
            }
            Console.WriteLine(auksciausia + "  -  tai auksciausia temperatura");

 //            3.vidurkį;
            double suma = 0;
            foreach (var temperatura in temperaturos)
            {
                suma += temperatura;
            }
            double vidurkis = suma / temperaturos.Length;
            Console.WriteLine(vidurkis + "  -  tai vidurkis");

            //            4.temperatūrų esančių žemiau už vidurkį kiekį;
           
            double skaicius_mazesniu = 0;
            foreach (var temperatura in temperaturos)
            {
                if (temperatura<vidurkis)
                {
                    skaicius_mazesniu++;
                }
            }
            Console.WriteLine(skaicius_mazesniu + "  -  tai mazesniu uz vidurki temperaturu skaicius");

            //           5.temperatūrų esančių aukščiau už vidurkį kiekį;
            double skaicius_didesniu = 0;
            foreach (var temperatura in temperaturos)
            {
                if (temperatura > vidurkis)
                {
                    skaicius_didesniu++;
                }
            }
            Console.WriteLine(skaicius_didesniu + "  -  tai didesniu uz vidurki temperaturu skaicius");


            Console.ReadLine();

        }
    }
}
