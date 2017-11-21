using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //   Susikurkite studentų pažymių masyvą.Raskite:
            //            1.geriausią pažymį;
            //            2.kiek mokinių yra gavę dešimtukus;
            //            3.kiek mokinių yra gavę neigiamą pažymį(žemiau nei 4);
            //            4.pažymių vidurkį;

            int[] pazymiai = {4, 5, 6, 7, 5, 3, 2, 10 , 10, 10};

            int geriausias = 0;
            foreach (var pazymys in pazymiai)
            {
                if (pazymys>geriausias)
                {
                    geriausias = pazymys;
                }
            }
            Console.WriteLine("Geriausias pazymys: " + geriausias);

            int desimtuku_kiekis = 0;
            foreach (var pazymys in pazymiai)
            {
                if (pazymys==10)
                {
                    desimtuku_kiekis++;
                }
            }
            Console.WriteLine("Desimtuku kiekis: " + desimtuku_kiekis);

            int neigiamu_kiekis = 0;
            foreach (var pazymys in pazymiai)
            {
                if (pazymys<=4)
                {
                    neigiamu_kiekis++;
                }
            }
            Console.WriteLine("Neigiamu (<=4) kiekis: " + neigiamu_kiekis);

            
            double suma = 0;
            foreach (var pazymys in pazymiai)
            {
                suma += pazymys;
            }
            double vidurkis = suma / pazymiai.Length;
            Console.WriteLine("Pazymiu vidurkis: " + vidurkis);


            Console.ReadLine();
        }
    }
}
