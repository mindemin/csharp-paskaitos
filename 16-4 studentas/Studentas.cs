using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_4_studentas
{
    class Studentas
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public string Pravarde { get; private set; }
        public int Amzius { get; private set; }
        public List<int> MatematikosPazymiai { get; private set; }
        public List<int> InformatikosPazymiai { get; private set; }
        public List<int> BiologijosPazymiai { get; private set; }

        public Studentas (string vardas, string pavarde, string pravarde, int amzius, List<int> matematikosPazymiai, List<int> informatikosPazymiai, List<int> biologijosPazymiai)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Pravarde = pravarde;
            Amzius = amzius;
            MatematikosPazymiai = matematikosPazymiai;
            InformatikosPazymiai = informatikosPazymiai;
            BiologijosPazymiai = biologijosPazymiai;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Studentas: {0} {1} ({2}), amzius {3} m.",Vardas,Pavarde,Pravarde,Amzius);
            Console.Write("Matematikos pazymiai: ");
            foreach (var i in MatematikosPazymiai)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            Console.Write("Informatikos pazymiai: ");
            foreach (var i in InformatikosPazymiai)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            Console.Write("Biologijos pazymiai: ");
            foreach (var i in BiologijosPazymiai)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
        }

    }
}
