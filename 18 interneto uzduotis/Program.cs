using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_interneto_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program in C# Sharp to calculate and print the Electricity bill of a given customer. 
            //The customer id., name and unit consumed by the user should be taken from the keyboard and display 
            //the total amount to pay to the customer. The charge are as follow : Go to the editor
            Console.WriteLine("Iveskite kliento numeri: ");
            var id = Console.ReadLine();
            Console.WriteLine("Iveskite varda: ");
            var vardas = Console.ReadLine();
            Console.WriteLine("Iveskite adresa: ");
            var adresas = Console.ReadLine();
            Console.WriteLine("Iveskite suvartotus KW: ");
            var kw = Convert.ToInt32(Console.ReadLine());
            double moketi = 0;

            if (kw<199)
            {
                moketi = kw * 1.2;
                
            }
            else if (kw<400)
            {
                moketi = kw * 1.5;

            }
            else if (kw<600)
            {
                moketi = kw * 1.8;

            }
            else
            {
                moketi = kw *2;

            }
            //Unit / Charge / unit
            // upto 199  @1.20
            // 200 and above but less than 400  @1.50
            // 400 and above but less than 600 @1.80
            // 600 and above  @2.00

            if (moketi>400)
            {
                moketi = moketi * 1.15;
            }
            else if (moketi<100)
            {
                moketi = 100;
            }
            // If bill exceeds Rs. 400 then a surcharge of 15 % will be charged and the minimum bill should be of Rs. 100 / -
            Console.WriteLine("viso uz elektra: " + moketi);
            Console.ReadLine();
        }
    }
}
