using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas1_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // trys skirtingi masyvu sintakses budai:

            int[] pazymiai = { 7, 8, 6, 5, 8, 9 };

            string[] markes = new string[5];
            markes[0] = "audi";
            markes[1] = "bmw";
            markes[2] = "mb";
            markes[3] = "mazda";
            markes[4] = "opel";

            var kazkas = new double[4];
            kazkas[0] = 3.43;
            kazkas[1] = 4.22;
            kazkas[2] = 55;
            kazkas[3] = 33.545;

            // duomenu isvedimas

            Console.WriteLine("masyvu dydziai:");
            Console.WriteLine("pazymiai: " + pazymiai.Length);
            Console.WriteLine("markes: " + markes.Length);
            Console.WriteLine("kazkas: " + kazkas.Length);

            Console.WriteLine("pazymiu masyvo reiksmes: ");
            Console.WriteLine("Pirma: " + pazymiai.First());
            Console.WriteLine("Paskutine: " + pazymiai.Last());
            Console.WriteLine("Paskutine(kitu): " + pazymiai[pazymiai.Length-1]);
            Console.WriteLine("Trecia: " + pazymiai[2]);

            // duomenu ivedimas

            var skaiciai = new int[5];
            Console.WriteLine("Iveskite 5 skaicius:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1+": ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.ReadLine();
        }
    }
}
