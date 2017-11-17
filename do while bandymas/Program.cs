using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_bandymas
{
    class Program
    {
        static void Main(string[] args)
        {
            int pasirinkimas;

            do
            {
                Console.WriteLine("Pasirinkite gyvuna: 1 - kate, 2 - suo, 3 - papuga");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());
                if (pasirinkimas<1||pasirinkimas>3)
                {
                    Console.WriteLine("blogas pasirinkimas!");
                }

            } while (pasirinkimas<1 || pasirinkimas>3);
            Console.WriteLine("Pasirinkimas: " + pasirinkimas);
            Console.ReadLine();

        }

    }
}
