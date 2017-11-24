using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektas
{
    class PirmasSaltinis
    {
        public int Zenklas { get; private set; }
        public string Horskopas { get; private set; }

        public PirmasSaltinis(int zenklas, string horoskopas)
        {
            Zenklas = zenklas;
            Horskopas = horoskopas;
        
        }

        public void Isvedimas()
        {
            
            Console.WriteLine("Jusu horoskopas: " + Horskopas);
            
        }

    }

    
}
