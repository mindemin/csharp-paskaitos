using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Liepkite vartotojui pasirinkti kiek studentų pažymių nori suvesti į sąrašą.Tegul jis užpildo šį sąrašą duomenimis, 
            // įvedant juos per konsolę.Raskite:
            //            1.didžiausią pažymį;
            //             2.mažiausią pažymį;
            //             3.vidurkį;
            //             4.išveskite atsitiktinį skaičių iš šio sąrašo.

            Console.WriteLine("Kiek pazymiu noresite suvesti? ");
            int kiek_pazymiu = Convert.ToInt32(Console.ReadLine());
            List<int> pazymiai = new List<int>();
            Console.WriteLine("Iveskite pazymius: ");
            
            for (int i = 0; i < kiek_pazymiu; i++)
            {
                pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
                //Console.WriteLine("Ivestas pazymys: " + pazymiai[i]);
            }
            Console.WriteLine(" ********************* ");
            Console.WriteLine(pazymiai.Max() + " didziausias pazymys");
            Console.WriteLine(pazymiai.Min() + " maziausias pazymys");
            Console.WriteLine(pazymiai.Average() + " pazymiu vidurkis");
            Console.WriteLine(" ********************* ");

            var rnd = new Random(); // random generavimas
            var kuri_rodyti = rnd.Next(1, pazymiai.Count()+1); // 1-saraso ilgis

            Console.Write("Parodyti " + kuri_rodyti + " skaiciu sarase, kuris yra ");
            Console.WriteLine(pazymiai[kuri_rodyti-1]);

              

            Console.ReadLine();

        }
    }
}
