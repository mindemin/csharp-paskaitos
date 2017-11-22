using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_00_dar_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> atlyginimai = new List<double>();
            var programa = new Program();
            programa.ivedimas(atlyginimai);
            //programa.isvedimas(atlyginimai);
            Console.WriteLine("Maziausia alga: "+ programa.MaziausiaAlga(atlyginimai));
            Console.WriteLine("Didziausia alga: " + programa.DidziausiaAlga(atlyginimai));
            Console.WriteLine("Vidutine alga: " + programa.VidutineAlga(atlyginimai));
            Console.WriteLine("Didesni uz vidutine alga - " + programa.KiekDaugiauUzVid(atlyginimai)+ " atlyginimai");
            Console.WriteLine("Didesni uz pasirinkta alga - " + programa.KiekDaugiauUzX(atlyginimai) + " atlyginimai");

            programa.TrysDidziausiosAlgos(atlyginimai);
            Console.ReadLine();
        }

        // atlyginimo saraso suvedimas - metodas.

        public void ivedimas(List<double> atlyginimai)
        {
            Console.WriteLine("Kiek atlyginimu norite suvesti? ");
            var KiekAlgu = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < KiekAlgu; i++)
            {
                Console.Write("Iveskite {0}-aji atlyginima: ", i+1);
                atlyginimai.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }

        // metodas atlyginimu isvedimui.
        public void isvedimas(List<double> atlyginimai)
        {
            int i = 1;
            foreach (var atl in atlyginimai)
            {
                Console.WriteLine(" {0}-as ivestas atlyginimas: {1} ",i++, atl );
            }           
        }
        
        // maziausia alga
        public double MaziausiaAlga(List<double> atlyginimai)
        {
            return atlyginimai.Min();
        }

        // didziausia alga
        public double DidziausiaAlga(List<double> atlyginimai)
        {
            return atlyginimai.Max();
        }
        // vidutine alga
        public double VidutineAlga(List<double> atlyginimai)
        {
            return atlyginimai.Average();
        }

        // kiek algu daugiau uz vidurki. 

        public double KiekDaugiauUzVid(List<double>atlyginimai)
        {
            var vidurkis = VidutineAlga(atlyginimai);
            var kiek = 0;
            foreach (var atl in atlyginimai)
            {
                if (atl>vidurkis)
                {
                    kiek++;
                }
            }
            return kiek; 
        }
        // kiek algu daugiau uz x suma. 

        public double KiekDaugiauUzX(List<double> atlyginimai)
        {
            Console.WriteLine("Uz kiek turi buti didesnis atlyginimas? ");
            var x = Convert.ToDouble(Console.ReadLine());
            var kiek = 0;
            foreach (var atl in atlyginimai)
            {
                if (atl > x)
                {
                    kiek++;
                }
            }
            return kiek;
        }

        // trys didziausios algos. Neveikia teisingai jei yra lygios algos. 

        public void TrysDidziausiosAlgos (List<double> atlyginimai)
        {
            double PirmaDidziausia = DidziausiaAlga(atlyginimai);
            double AntraDidziausia = 0;
            foreach (var alg in atlyginimai)
            {
                if (alg<PirmaDidziausia && alg>AntraDidziausia)
                {
                    AntraDidziausia = alg;
                }
            }
            double TreciaDidziausia = 0;
            foreach (var alga in atlyginimai)
            {
                if (alga < PirmaDidziausia && alga > TreciaDidziausia && alga < AntraDidziausia)
                {
                    TreciaDidziausia = alga;
                }
            }
            Console.WriteLine("Pirma didziausia alga: " + PirmaDidziausia);
            Console.WriteLine("Antra didziausia alga: " + AntraDidziausia);
            Console.WriteLine("Trecia didziausia alga: " + TreciaDidziausia);

        }
    }
}
