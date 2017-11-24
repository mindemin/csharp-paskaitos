using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_pavyzdziai
{
    class Policininkas:Darbuotojas // vaikine klase:bazine klase
    {
        // papildomi klases kintamieji
        public double Kysis { get; private set; }
        public int KiekSuemeNusikalteliu { get; private set; }

        public Policininkas(string vardas, string pavarde, int amzius, double alga, double etatas, double kysis, int kiekSuemeNusikalteliu)
            : base(vardas, pavarde, amzius, alga, etatas) // Duomenys is bazines klases
        {
            Kysis = kysis;
            KiekSuemeNusikalteliu = kiekSuemeNusikalteliu;
        }

        public void Isvedimas()
        {
            base.Isvedimas(); // Tevines klases metodas
            Console.WriteLine("Policininkas gauna {0} EUR kysio, sugavo {1} nusikalteliu. ", Kysis,KiekSuemeNusikalteliu);
            Console.WriteLine();
        }
    }
}
