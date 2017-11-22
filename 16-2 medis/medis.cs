using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_2_medis
{
    class medis
    {
        // kintamieji
        public string Rusis { get; private set; }
        public int Amzius { get; private set; }
        public int Aukstis { get; private set; }


        // konstruktorius
        public medis (string rusis, int amzius, int aukstis)
        {
            Rusis = rusis;
            Amzius = amzius;
            Aukstis = aukstis;
        }

        // metodai
        // isvedimas
        public void isvedimas()
        {
            Console.WriteLine("Medis {0}, kurio amzius {1} m., yra {2} m. aukscio", Rusis,Amzius,Aukstis);
            Console.WriteLine();
        }

        public void AmziusDienomis()
        {
            Console.WriteLine("Medzio amzius dienomis: " + Amzius * 365);
        }
        public void RaidesZodyjeMedis()
        {
            int ilgis = Rusis.Length;
            Console.WriteLine("Medzio pavadinimo ilgis - {0} raides", ilgis);
        }
    }
}
