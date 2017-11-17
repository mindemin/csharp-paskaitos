using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liepkite vartotojui įvedinėti atsitiktinius skaičius. Šį ciklą vykdyti tol, kol įvestas skaičius nesidalins iš 9.
            int sk = 1;
            while (sk%9 != 0)
            {
                Console.Write("Iveskite skaiciu: ");
                sk = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Ivestas skaicius dalinasi is 9!");
            Console.ReadLine();
        }
    }
}
