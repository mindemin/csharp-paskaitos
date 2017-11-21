using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodai_pvz
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Pasisveikinti();
            programa.pasisveikinti("Ieva");
            programa.pasisveikinti("Ieva", "Neieva");
            Console.WriteLine("********************");
            programa.atsisveikinti();
            programa.atsisveikinti("Ieva");
            programa.atsisveikinti("ieva", "neieva");

            Program.StatinisMetodas();
            StatinisMetodas();

            var sumosats = programa.suma(4, 5); // duodam metoda ir duomenis. gb kintamieji is kitur. gauname reiksme return.
            Console.WriteLine(sumosats);
            Console.WriteLine(programa.suma(4,5));  // alternatyvus
            Console.WriteLine(programa.skirtumas(4,5));
            Console.WriteLine(programa.daugyba(4,5));
            Console.WriteLine(programa.dalyba(4,5));
            
            // kintamuju panaudojimas
            Console.WriteLine("iveskite du skaicius:");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(programa.suma(pirmas,antras));  // alternatyvus, tik rezultatas.

            var suma = programa.suma(pirmas, antras);
            Console.WriteLine("{0} + {1} = {2}", pirmas, antras, suma);

            var skirtumas = programa.skirtumas(pirmas, antras);
            Console.WriteLine("{0} - {1} = {2}", pirmas, antras, skirtumas);

            var sandauga = programa.daugyba(pirmas, antras);
            Console.WriteLine("{0} * {1} = {2}", pirmas, antras, sandauga);

            var dalnuo = programa.dalyba(pirmas, antras);
            Console.WriteLine("{0} / {1} = {2}", pirmas, antras, dalnuo);

            Console.WriteLine("**************************************");

            Console.WriteLine("Iveskite dvieju krastiniu ilgius:");
            var krastine1 = Convert.ToInt32(Console.ReadLine());
            var krastine2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("staciakampio plotas yra: " + programa.plotas(krastine1, krastine2));
            Console.WriteLine("staciakampio perimetras yra: " + programa.perimetras(krastine1, krastine2));

            Console.WriteLine("**************************************");

            Console.WriteLine("Iveskite vienos trikampio krastines ilgi:");
            var TrikKras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite aukstines i ta krastine ilgi:");
            var TrikH = Convert.ToInt32(Console.ReadLine());
            var TrikPlotas = programa.TrikampioPlotas(TrikKras, TrikH);
            Console.WriteLine("trikampio plotas yra: " + TrikPlotas);
           

            Console.ReadLine();
        }
        // metodai rasomi cia, po main. 
        // pasiekiamumas, tipas pavadinimas (parametrai)


        public double TrikampioPlotas(int a, int h) // trikampio plotas ah/2, kur a krastine, h aukstine i ta krastine. 
        {
            return (double) a * h / 2;

        }

        public void Pasisveikinti()
        {
            Console.WriteLine("Labas krabas");
        }

        public void pasisveikinti (string vardas)
        {
            Console.WriteLine("Labas " + vardas);
        }
        public void pasisveikinti (string vardas, string pavarde)
        {
            Console.WriteLine("Labas " + vardas + "  " + pavarde);
        }
        public void atsisveikinti()
        {
            Console.WriteLine("Viso gero");
        }
        public void atsisveikinti (string vardas)
        {
            Console.WriteLine(" Viso " + vardas);
        }
        public void atsisveikinti (string vardas, string pavarde)
        {
            Console.WriteLine(" Viso " + vardas + " gero " + pavarde);
        }

        // statinis metodas

        public static void StatinisMetodas()
        {
            Console.WriteLine("statinis metodas");
        }
        // static- gali kviesti per klases pavadinima
        // int - grazina int reiksme is metodo. return visada turi likti int atsakymas. 
        
        public int suma(int a, int b)
        {
            return a + b;
        }

        public int skirtumas(int a, int b)
        {
            return a - b;
        }
        public int daugyba(int a, int b)
        {
            return a * b;
        }
        public double dalyba(int a, int b) 
        {
            return (double) a / b;// dalyba po kablelio bus double, ne int.
        }
        public int plotas(int a, int b)
        {
            return a * b;
        }
        public int perimetras (int a, int b)
        {
            return (a + b) * 2;
        }

    }
}
