using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_pavyzdziai
{
    class Darbuotojas
    {
        // Kintamieji
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public int Amzius { get; private set; }
        public double Alga { get; private set; }
        public double Etatas { get; private set; }

        // Konstruktorius
        public Darbuotojas(string vardas, string pavarde, int amzius, double alga, double etatas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Alga = alga;
            Etatas = etatas;
        }

        // Isvedimo metodas
        public void Isvedimas()
        {
            Console.Write("Darbuotojas {0} {1} ({2} m.).", Vardas, Pavarde, Amzius);
            Console.WriteLine("Jo atlyginimas {0} EUR, dirba {1} etato. ", Alga, Etatas);
            

        }

        // 
    }
}
