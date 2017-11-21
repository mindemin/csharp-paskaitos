using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {

            //  3.Susikurkite kintamąjį, kuris pasakytų kiek kuro sąnaudų sunaudoja automobilis 100 km.Susikurkite masyvą, kuriame saugotumėte 
            //  skirtingose kelionėse nuvažiuotų kilometrų rodmenis. Raskite:
            //            1.trumpiausią kelionę;
            //            2.ilgiausią kelionę;
            //            3.kiek vidutiniškai kuro sąnaudų sunaudojo automobilis(skaičiavimui reikės rasti visus nuvažiuotus km);

            double litrai_100km = 10;
            int[] keliones = { 443, 554, 551, 5343, 7455, 8786 };
            var ilgiausia = 0;
            var trumpiausia = 0;
            foreach (var km in keliones)
            {
                if (km>ilgiausia)
                {
                    ilgiausia = km;
                }               
            }
            trumpiausia = keliones[0];
            foreach (var km in keliones)
            {
                if (km<trumpiausia)
                {
                    trumpiausia = km;
                }
            }
            Console.WriteLine("Trumpiausia kelione: " + trumpiausia);
            Console.WriteLine("Ilgiausia kelione: " + ilgiausia);

            var nuvaziuota = 0;
            foreach (var km in keliones)
            {
                nuvaziuota += km;
            }
            double sanaudos = nuvaziuota / litrai_100km;
            Console.WriteLine("viso nuvaziuota km: " + nuvaziuota);
            Console.WriteLine("viso sunaudota kuro: " + sanaudos);

            double[] kuras = new double[keliones.Length];
            for (int i = 0; i < keliones.Length; i++)
            {
                kuras[i] = keliones[i] / litrai_100km;
                Console.WriteLine(i+1 + " kelionei sunaudota " + kuras[i] + " kuro ir nuvaziuota " + keliones[i] + " km");
            }

 Console.ReadLine();
        }
    }
}
