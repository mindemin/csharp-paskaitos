using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_0_klases_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var knyga1 = new Knyga(); // Objektas klaseje knyga. Paleidzia default konstruktorius.
            knyga1.Pavadinimas = "Haris Floteris";
            knyga1.Autorius = "Anonimas";
            knyga1.Metai = 1816;
            knyga1.PuslapiuSkaicius = 12;
            knyga1.isvedimas();

            var knyga2 = new Knyga("Voldemorto nuotykiai", "Jis", 12,1817); //Ivedimas su nuosavu konstruktorium
            knyga2.isvedimas();

            var knygos = new List<Knyga>
            {
                new Knyga("Kaip ismokt programuot", "Koderis", 1000000, 1561),
                new Knyga("Anyksciu silelis", "Baranauskas", 11, 2017),
                new Knyga("Haris poteris", "Rowlink. g.f.", 350, 1998)
            };

            foreach (var knyga in knygos)
            {
                knyga.isvedimas();
            }

            Console.ReadLine();
        }
    }
}
