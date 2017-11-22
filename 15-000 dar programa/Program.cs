using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_000_dar_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            // vidutinis kvadratinis primilziu nuokrypis, litrais. 
            // Sukuriam sarasa
            List<double> primilziai = new List<double>();
            // Kvieciam metodus
            var programa = new Program();
            programa.ivedimas(primilziai);
            programa.isvedimas(primilziai);
            Console.WriteLine(" Didziausias primilzis: "+ programa.didziausias(primilziai));
            Console.WriteLine(" Maziausias primilzis: " + programa.maziausias(primilziai));
            Console.WriteLine(" Vidutinis primilzis: " + programa.vidurkis(primilziai));
            programa.DuDidziausi(primilziai);

            Console.ReadLine();
        }
            // Ivedimo metodas
        public void ivedimas(List<double> primilziai)
        {
            Console.WriteLine("Iveskite primiziu duomenu kieki: ");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.Write("Iveskite primilzi " + (i+1) + ":");
                primilziai.Add(Convert.ToDouble(Console.ReadLine()));

            }
        }
            // Isvedimo metodas
        public void isvedimas(List<double> primilziai)
        {
            Console.WriteLine("Ivesti primilziai: ");
            foreach (var prim in primilziai)
            {
                Console.Write(prim + "l ");
            }
            Console.WriteLine(" ");
        }
 // min max average metodai
        public double maziausias (List<double> primilziai)
        {
            return primilziai.Min();
        }    
        public double didziausias (List<double> primilziai)
        {
            return primilziai.Max();
        }   
        public double vidurkis(List<double> primilziai)
        {
            return primilziai.Average();
        }
            // du didziausi
        public void DuDidziausi(List<double> primilziai)
        {
            var pirmas = didziausias(primilziai);
            double antras = 0;
            foreach (var prim in primilziai)
            {
                if (prim>antras)
                {
                    antras = prim;
                }
                
            }
            Console.WriteLine("Primas didziausias: " + pirmas);
            Console.WriteLine("Antras didziausias: " + antras);
        }
    }
}
