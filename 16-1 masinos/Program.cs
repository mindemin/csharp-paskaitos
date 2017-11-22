using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_1_masinos
{
    class Program
    {
        static void Main(string[] args)
        {
            var automobilis = new automobilis("audi", "a3", 2000, "2,2", 666, 2000);
            automobilis.isvedimas();

            var automobiliai = new List<automobilis>
            {
                new automobilis("bmw", "315",2000,"3,0",250,100000),
                new automobilis("bmw", "330",1998,"3,5",300,103000),
                new automobilis("lada", "samara",2011,"1,0",25,100000),
                new automobilis("bmw", "850",2000,"5,0",500,10009),
                new automobilis("mb", "E320",1980,"3,3",140,100000),
                new automobilis("bmw", "330i",1994,"3,0",250,50000),
                new automobilis("mazda", "6",2016,"2,0",230,1001),
            };

            var prog = new Program();
            prog.isvedimas(automobiliai); // iskvieciame metoda sioje klaseje program.

            var naujausias = prog.NaujausiasAuto(automobiliai);
            Console.WriteLine("Naujausias auto: ");
            naujausias.isvedimas();

            var seniausias = prog.SeniausiasAuto(automobiliai);
            Console.WriteLine("Seniausias auto: ");
            seniausias.isvedimas();

            var galingiausias = prog.GalingiausiasAuto(automobiliai);
            Console.WriteLine("Galingiausias auto: ");
            galingiausias.isvedimas();

            var MinRida = prog.MaziausiaRida(automobiliai);
            Console.WriteLine("Maziausiai nuvaziaves automobilis: ");
            MinRida.isvedimas();

            Console.ReadLine();
        } // main metodo pabaiga

        // kiti Metodai
        public void isvedimas(List<automobilis> automobiliai)  // listo automobiliai isvedimas
        {
            foreach (var auto in automobiliai)
            {
                auto.isvedimas();
            }
        }
        // naujausias automobilis
        public automobilis NaujausiasAuto(List<automobilis> automobiliai) // metodas, klase automobilis vietoj void.
        {

            var laikinas = automobiliai.First();
            foreach (var auto in automobiliai)
            {
                if (auto.Metai > laikinas.Metai)
                {
                    laikinas = auto;
                }
            }
            return laikinas;
        }
       // seniausias automobilis
       public automobilis SeniausiasAuto(List<automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();
            foreach (var auto in automobiliai)
            {
                if (auto.Metai<laikinas.Metai)
                {
                    laikinas = auto;
                }
            }
            return laikinas;
        }
        // galingiausias
        public automobilis GalingiausiasAuto(List<automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();
            foreach (var auto in automobiliai)
            {
                if (auto.Galia>laikinas.Galia)
                {
                    laikinas = auto;
                }
            }
            return laikinas;
        }    
            
        // maziausia rida      
        public automobilis MaziausiaRida(List<automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();
            foreach (var auto in automobiliai)
            {
                if (auto.Rida<laikinas.Rida)
                {
                    laikinas = auto;
                }
            }
            return laikinas;
        }

    }
}
