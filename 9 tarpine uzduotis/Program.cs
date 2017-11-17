using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_tarpine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tikslas: Suskaičiuoti kiek duonos kepalų kepykla sugebės iškepti per dieną, ar spės įgyvendinti visus dienos užsakymus, 
            //suskaičiuoti kiek iš jų uždirbs pelno.
            // •Iš anksto žinoma informacija:
            //•Darbo valandų per dieną 8 val.

            int h = 8;

            //•Vartotojo įvedama informacija:
            //•Kiek darbuotojas gali iškepti kepalų per valandą.
            Console.WriteLine("iveskite duomenis:");
            Console.WriteLine("Kiek darbuotojas gali iškepti kepalų per valandą?");
            var kep_per_h = Convert.ToInt32(Console.ReadLine());

            //•Kiek darbuotojų turi kepykla.
            Console.WriteLine("Kiek darbuotojų turi kepykla.?");
            var darbuotojai = Convert.ToInt32(Console.ReadLine());

            //•Vieno kepalo savikaina.
            Console.WriteLine("Kokia vieno kepalo savikaina?");
            var savikaina = Convert.ToInt32(Console.ReadLine());

            //•Vieno kepalo pardavimo kaina.
            Console.WriteLine("Kokia vieno kepalo pardavimo kaina?");
            var kaina = Convert.ToInt32(Console.ReadLine());

            //•Kiek kepykla turi tą dieną užsakymų.
            Console.WriteLine("Kiek turime uzsakymu ta diena?");
            var uzsakymai = Convert.ToInt32(Console.ReadLine());

            //•Suskaičiuoti kiek kepykla per vieną darbo dieną spės iškepti duonos kepalų.
            var viso_kepalu_per_diena = h * kep_per_h * darbuotojai;
            Console.WriteLine("bus iskepta kepalu per diena: " + viso_kepalu_per_diena);

            //•Apskaičiuoti visų kepalų savikainą, gautas pajamas pardavus ir iš to gauto pelno dalį.
            var savikaina_visu = savikaina * viso_kepalu_per_diena;
            Console.WriteLine("visu kepalu savikaina: " + savikaina_visu);
            var pajamos = viso_kepalu_per_diena * kaina;
            Console.WriteLine("pagamintu kepalu pardavimo pajamos: " + pajamos);
            var pelnas = pajamos - savikaina_visu;
            Console.WriteLine("pardavus visus kepalus bus pelnas: " + pelnas);
            //•Patikrinti ar kepykla spės iškepti visus tos dienos užsakymus.Jei ne, suskaičiuoti kiek kepalų nespės iškepti.
            if (uzsakymai >= viso_kepalu_per_diena)
            {
                Console.WriteLine("Visu uzsakymu nepadarysime, truks " + (viso_kepalu_per_diena-uzsakymai) + " kepalu");
                
                         
            }
            else
            {
                Console.WriteLine("spesime viska pagaminti");
            }

            Console.ReadLine();

        }
    }
}
