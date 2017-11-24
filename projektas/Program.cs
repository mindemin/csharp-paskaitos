using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektas
{
    class Program
    {
        static void Main(string[] args)
        {

            var pirmas = new List<PirmasSaltinis>
            {
                new PirmasSaltinis(1, "geras zmogus"),
                new PirmasSaltinis(2, "geria plaukia"),
                new PirmasSaltinis(3, "medziotojas"),
                new PirmasSaltinis(4, "visai blogai..."),
                new PirmasSaltinis(5, "tai apsispresk")
            };

            Console.WriteLine("Iveskite savo zenkla: ");
            Console.WriteLine(" 1 - Avinas, 2 - Zuvis, 3 - Liutas, 4 - Vezys, 5 - Nezinau");
            var Zenklas = Convert.ToInt32(Console.ReadLine());

            pirmas[Zenklas - 1].Isvedimas();

            Console.ReadLine();
                
        }
    }
}
