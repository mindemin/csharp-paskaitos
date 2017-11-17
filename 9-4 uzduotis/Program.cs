using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Į ekraną išveskite kelis sunumeruotus pasirinkimus (pvz.: 1 - stacionarus kompiuteris, 
            //2 - nešiojamas kompiuteris, 3 - planšetė...). Liepkite vartotojui įvesti pasirinkimo numerį. 
            //Pagal įvestą numerį išveskite atitinkamą tekstą (pvz.: nešiojamuoju kompiuteriu galite naudotis visur). 
            //Neradus tinkamo varianto išvesti, kad tokio pasirinkimo nėra.

            Console.WriteLine("Galimi pasirinkimai:");
            Console.WriteLine("1 - stacionarus kompiuteris");
            Console.WriteLine("2 - nesiojamas kmpiuteris");
            Console.WriteLine("3 - plansete");
            Console.WriteLine("pasirinkite skaiciu:");
            var a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("naudotis tik namie");
                    break;
                case 2:
                    Console.WriteLine("galite naudotis visur");
                    break;
                case 3:
                    Console.WriteLine("zaisliukas");
                    break;
                default:
                    Console.WriteLine("tokio pasirinkimo nera");
                    break;


            }
            Console.ReadLine();
        }
    }
}
