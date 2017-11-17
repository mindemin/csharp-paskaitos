using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvesti savo amžių. Jei amžius yra 18 arba daugiau, tuomet į ekraną išveskite, kad “jūs galite balsuoti”.
            Console.WriteLine("Iveskite savo amziu: ");
            var a = Convert.ToDouble(Console.ReadLine());
            if (a>=18)
            {
                Console.WriteLine("Jus galite balsuoti");
            }
            Console.ReadLine();
            
        }

    }
}
