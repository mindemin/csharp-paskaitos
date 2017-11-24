using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var darbuotojas = new Darbuotojas("Jis", "Jii", 33, 200, 1);
            darbuotojas.Isvedimas();
            Console.WriteLine();

            var policininkas = new Policininkas("Poli", "Moli", 45, 300, 0.5, 100, 1);
            policininkas.Isvedimas();
            Console.WriteLine();

            var medikas = new Medikas("Medas", "Dumedas", 54, 550, 1.4, "Loras", "Profesorius", 25);            
            medikas.Isvedimas();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
