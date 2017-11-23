using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_3_paduotuve
{
    class Parduotuve
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Preke> Prekes { get; private set; }

        // overloading. 
        // Konstruktorius tik prekei
        public Parduotuve(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Prekes = new List<Preke>();
            Console.WriteLine(" 1 - Generuoti prekes?");
            Console.WriteLine(" 2- suvesti prekes?");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:SugeneruotiPrekes();break;
                case 2:SuvestiPrekes(); break;
                default:SugeneruotiPrekes(); break;
            }
        }

        // Konstruktorius visam setui
        public Parduotuve(string pavadinimas, string adresas, List<Preke> prekes)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Prekes = prekes;
        }

        // Random generuojam prekes
        public void SugeneruotiPrekes()
        {
            var rnd = new Random();
            var kiekPrekiu = rnd.Next(1, 20);

            var sakinys = // isskaido sakini i zodziu masyva
                "Lorem ipsum dolor sit amet consectetur adipiscing elit Proin tempor massa vel sagittis auctor eros risus mattis ipsum luctus suscipit augue nulla ut erat Sed in arcu vehicula tincidunt nisi et rhoncus neque Aenean rutrum arcu vel lobortis pulvinar arcu metus venenatis lectus vitae sollicitudin mi felis convallis est";
            var zodziai = sakinys.Split(' ');

            for (int i = 0; i < kiekPrekiu; i++) // pildom prekiu sarasa
            {
                var pavadinimas = zodziai[rnd.Next(zodziai.Length)];
                var kodas = rnd.Next(10000, 100000).ToString();
                var kaina = rnd.Next(50, 100);
                var savikaina = rnd.Next(1, 50);
                var kiekis = rnd.Next(1, 100);
                var preke = new Preke(pavadinimas, kodas, kaina, savikaina, kiekis);
                Prekes.Add(preke);
            }
        }
        public void VisuPrekiuIsvedimas ()
        {
            Console.WriteLine("Parduotuves pavadinimas: " + Pavadinimas);
            Console.WriteLine("Adresas: " + Adresas);
            Console.WriteLine("Prekiu kiekis: " + Prekes.Count);
            Console.WriteLine("**********************************************");

            foreach (var preke in Prekes)
            {
                preke.Isvedimas();  // kintamasis.metodas
            }
            Console.WriteLine("SKAICIAVIMAI: ");
            Console.WriteLine("Visu prekiu kainu suma: " + KainuSuma());
            Console.WriteLine("Visu prekiu savikainu suma: " + SavikainuSuma());
            Console.WriteLine("Visu prekiu pardavimo pajamos: " + Pajamos());
            Console.WriteLine("Visu prekiu pardavimo pelnas: " + VisasPelnas());
            Console.WriteLine("***");
            Console.WriteLine("Maziausias kiekis yra: ");
            KuriosMaziausia().Isvedimas();
            Console.WriteLine("Didziausias kiekis yra: ");
            KuriosDaugiausia().Isvedimas();
            Console.WriteLine("Brangiausia preke yra: ");
            KuriBrangiausia().Isvedimas();
            Console.WriteLine("Pigiausia preke yra: ");
            KuriPigiausia().Isvedimas();
        


        }

        public void SuvestiPrekes()
        {
            Console.WriteLine("Kiek prekiu norite suvesti? ");
            var kiekSuvesti = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiekSuvesti; i++)
            {
                Console.WriteLine("{0}-OJI PREKE:", kiekSuvesti);
                Console.WriteLine("Iveskite pavadinima:");
                var pavadinimas = Console.ReadLine();
                Console.WriteLine("Iveskite koda:");
                var kodas = Console.ReadLine();
                Console.WriteLine("Iveskite kaina:");
                var kaina = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Iveskite savikaina:");
                var savikaina = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Iveskite kieki:");
                var kiekis = Convert.ToInt32(Console.ReadLine());

                var preke = new Preke(pavadinimas,kodas,kaina,savikaina, kiekis);
                Prekes.Add(preke);
            }
        }
        // visu prekiu kainu suma
        public double KainuSuma()
        {
            double suma = 0;
            foreach (var preke in Prekes)
            {
                suma += preke.Kaina;
            }
            return suma;
        }

        // prekiu savikainu suma
        public double SavikainuSuma()
        {
            double suma = 0;
            foreach (var preke in Prekes)
            {
                suma += preke.Savikaina;
            }
            return suma;
        }

        // visu prekiu pajamos
        public Double Pajamos()
        {
            double pajamos = 0;
            foreach (var preke in Prekes)
            {
                pajamos += preke.Kaina * preke.Kiekis;
            }
            return pajamos;
        }      

        // visu prekiu pelnas
        public double VisasPelnas()
        {
            double pelnas = 0;
            foreach (var preke in Prekes)
            {
                pelnas =  preke.PelnasPardavusVisaKieki();
            }
            return pelnas;
        }

        // kurios prekes maziausia
        public Preke KuriosMaziausia()
        {
            var maziausias = Prekes[0];
            foreach (var preke in Prekes)
            {
                if (preke.Kiekis<maziausias.Kiekis)
                {
                    maziausias = preke;
                }
            }
            return maziausias;
        }

        // kurios prekes daugiausia
        public Preke KuriosDaugiausia()
        {
            var daugiausia = Prekes[0];
            foreach (var preke in Prekes)
            {
                if (preke.Kiekis>daugiausia.Kiekis)
                {
                    daugiausia = preke;
                }
            }
            return daugiausia;
        }


        // brangiausia preke

        public Preke KuriBrangiausia()
        {
            var brangiausia = Prekes[0];
            foreach (var preke in Prekes)
            {
                if (preke.Kaina>brangiausia.Kaina)
                {
                    brangiausia = preke;
                }
            }
            return brangiausia;
        }

        // pigiausia preke
        public Preke KuriPigiausia()
        {
            var pigiausia = Prekes[0];
            foreach (var preke in Prekes)
            {
                if (preke.Kaina<pigiausia.Kaina)
                {
                    pigiausia = preke;
                }
            }
            return pigiausia;
        }
       


    }
}
