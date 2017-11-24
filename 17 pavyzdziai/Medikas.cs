using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_pavyzdziai
{
    class Medikas:Darbuotojas
    {
        public string Specialybe { get; private set; }
        public string Laipsnis { get; private set; }
        public int Stazas { get; private set; }

        public Medikas (string vardas, string pavarde, int amzius, double alga, double etatas, string specialybe, string laipsnis, int stazas)
            : base(vardas,pavarde,amzius,alga,etatas)
        {
            Specialybe = specialybe;
            Laipsnis = laipsnis;
            Stazas = stazas;
        }

        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Jo specializacija - {0}, laipsnis - {1}, darbo stazas - {2}.",Specialybe,Laipsnis,Stazas);
            Console.WriteLine();

        }
    }
}
