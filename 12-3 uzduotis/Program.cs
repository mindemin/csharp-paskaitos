using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Padarykite skaičiuotuvą.Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius.
            // Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai išvedant kartu ir atliekamus veiksmus. 
            // Pvz.: 5 + 4 = 9
            // 5 - 4 = 1
            // Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.

           
            var ats = "t";

            while (ats == "t")
            {
                Console.WriteLine("Iveskite du skaicius:");
                var a = Convert.ToInt32(Console.ReadLine());
                var b = Convert.ToInt32(Console.ReadLine());
                var c = a + b;
                Console.WriteLine(a + " + " + b + " = " + c);
                Console.WriteLine("Ar norite dar skaiciuoti?: ");
                Console.WriteLine("t/n");
                ats = Console.ReadLine();
            }
            
        }
    }
}
