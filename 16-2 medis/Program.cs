using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_2_medis
{
    class Program
    {
        static void Main(string[] args)
        {
            var medis = new medis("egle", 200, 32);
            medis.isvedimas();

            medis.AmziusDienomis();
            medis.RaidesZodyjeMedis();

            Console.ReadLine();
        }
        // metus isversti i dienas
        
    }

}
