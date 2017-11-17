using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parašykite programą, kuri laipsnius paverstų į kelvinus ir fahrenheitus

            Console.WriteLine("Iveskite laipsnius C: ");
            var c = Convert.ToDouble(Console.ReadLine());

            var k = c+273.16; //kelvinu koeficientas
            var f = (c*9/5)+32; // farenheito koeficientas °C = 5/9 · (°F – 32). c*1,8+32


            Console.WriteLine("temperatura Kelvinais: " + k);
            Console.WriteLine("temperatura Farenheitais: " + f);
            Console.ReadLine();

            
        }
    }
}
