using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite gyvuna:");
            var a = Console.ReadLine();
                      
           switch (a)
            {
                case "suo":
                    Console.WriteLine("suo");
                    break;
                case "kate":
                    Console.WriteLine("kate");
                    break;
                case "ziurkenas":
                    Console.WriteLine("ziurkenas");
                    break;
                case "triusis":
                    Console.WriteLine("triusis");
                    break;
                case "papuga":
                    Console.WriteLine("papuga");
                    break;
                default:
                    Console.WriteLine("neatspejau:");
                    break;


            }
            Console.ReadLine();
        }
    }
}
