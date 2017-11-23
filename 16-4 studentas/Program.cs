using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_4_studentas
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentas = new Studentas("Haris", "Poteris", "Ryzas", 113, 
            new List<int>
            {
                5,6,7,8,9,3,3
            }, new List<int>
            {
                4,7,4,2,1,7,6
            }, new List<int>
            {
                9,9,9,6,4,2,6
            }
            );
            studentas.Isvedimas();



            Console.ReadLine();
        }
    }
}
