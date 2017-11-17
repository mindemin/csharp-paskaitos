using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Į ekraną išveskite kelis sunumeruotus pasirinkimus (pvz.: 1 - vanduo, 2 - kava, 3 - arbata…). 
            //Liepkite vartotojui įvesti pasirinkimo numerį. Pagal įvestą numerį išveskite atitinkamą tekstą
            //(pvz.: jūs pasirinkote vandenį). Neradus tinkamo varianto išvesti, kad tokio pasirinkimo nėra.

            Console.WriteLine("Galimi pasirinkimai:");
            Console.WriteLine("1 - vanduo");
            Console.WriteLine("2 - kava");
            Console.WriteLine("3 - arbata");
            Console.WriteLine("pasirinkite skaiciu:");
            var a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("pasirinkote vandeni");
                    break;
                case 2:
                    Console.WriteLine("pasirinkote kava");
                    break;
                case 3:
                    Console.WriteLine("pasirinkote arbata");
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;


            }
            Console.ReadLine();
        }
    }
}
