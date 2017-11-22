using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_0_klases_pavyzdziai
{
    class Knyga
    {
        // Duomenys
        public int PuslapiuSkaicius;
        public string Autorius;
        public string Pavadinimas;
        public int Metai;

        // Konstruktoriai, jie vykdomi paleidus klase. Jais sukuriamas objektas.

        public Knyga()
        {
   //       Console.WriteLine("Labas, as konstruktoriuje");
        }

        public Knyga(string pavadinimas, string autorius, int puslapiai, int metai)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            PuslapiuSkaicius = puslapiai;
            Metai = metai;
        }

        // Metodai
        public void isvedimas() // isvedimo metodas
        {
            Console.WriteLine("Autorius {0} parase knyga {1}, kuria isleido {2} metais, jos puslapiu skaicius {3}.", Autorius, Pavadinimas, Metai, PuslapiuSkaicius);
            Console.WriteLine();
        }


    }
}
