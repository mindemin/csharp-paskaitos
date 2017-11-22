using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_1_masinos
{
    class automobilis
    {
        // get - galima naudoti visoje programoje
        // set - galima keisti visoje programoje
        // private set - galima keisti tik klaseje
        // tuscia - galima keisti tik konstruktoriuje.
        
        //propg

        public string Marke { get; private set; }
        public string Modelis { get; private set; }
        public int Metai { get; private set; }
        public string DarbinisTuris { get; private set; }
        public int Galia { get; private set; }
        public int Rida { get; private set; }
        
        public automobilis(string marke, string modelis, int metai, string darbinisturis, int galia, int rida)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            DarbinisTuris = darbinisturis;
            Galia = galia;
            Rida = rida;
        }

        // isvedimo metodas
        public void isvedimas()
        {
            Console.WriteLine("Automobilis {0} {1} pagamintas {2} metais. Jo darbinis turis {3} l, galia {4} kw, rida {5} km.", Marke, Modelis, Metai, DarbinisTuris, Galia
                , Rida);
            Console.WriteLine();
        }


    }
}
