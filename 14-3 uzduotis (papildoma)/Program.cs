using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_3_uzduotis__papildoma_
{
    class Program
    {
        static void Main(string[] args)
        {
            //sukurti zodziu sarasa
            //rasti ilgiausia zodi (string yra char masyvas, tai ant to zodzio galite naudoti zodis.lenght)
            // rasti trumpiausia zodi
            // trumpiausia ir ilgiausia zodzius isvest nurodant kiek raidziu juos sudaro. 

            List<string> zodziai = new List<String>();
            Console.WriteLine("Iveskite keturis zodzius: ");
            for (int i = 0; i < 4; i++)
            {
                zodziai.Add(Console.ReadLine());
            }
            var ilgiausias = zodziai[0].Length;
            var ilgas_zodis = zodziai[0];
           

            for (int i = 0; i < 4; i++)
            {   
                if (zodziai[i].Length>ilgiausias)
                {
                    ilgas_zodis = zodziai[i];
                    ilgiausias = zodziai[i].Length;                   
                }
            }
            Console.WriteLine("Ilgiausias zodis yra " + ilgas_zodis + " o ji sudaro " + ilgiausias + " raides");

            var trumpiausias = zodziai[0].Length;
            var trumpas_zodis = zodziai[0];
            for (int i = 0; i < 4; i++)
            {
                if (zodziai[i].Length < trumpiausias)
                {
                    trumpas_zodis = zodziai[i];
                    trumpiausias = zodziai[i].Length;
                }
            }
            Console.WriteLine("Trumpiausias zodis yra " + trumpas_zodis + " o ji sudaro " + trumpiausias + " raides");


            Console.ReadLine();
        }
    }
}
