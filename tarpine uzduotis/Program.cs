using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarpine_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            //             2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            //            What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20 ?
            // Answer : 232792560

            int geras = 20;

            while (geras%20!=0 || geras % 19 != 0 || geras % 18 != 0 || geras % 17 != 0 || geras % 16 != 0 ||
                geras % 15 != 0 || geras % 14 != 0 || geras % 13 != 0 || geras % 12 != 0 || geras % 11 != 0)
            {
                // 20 - 1,2,4,5,10
                // 19
                // 18 - 3,6,9
                // 17
                // 16 - 8
                // 15 
                // 14 - 7
                // 13
                // 12 
                // 11
                geras+=20;
            }
            Console.WriteLine(geras);

            // ANTRA tarpine uzduotis
            // The sum of the squares of the first ten natural numbers is, 12 + 22 + ... + 102 = 385
            // The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)2 = 552 = 3025
            // Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
            // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
            // Answer: 25164150


            int rezultatas = 0;
            int sum_of_squares = 0;
            int square_of_sum = 0;


            for (int i = 0; i <= 100; i++)
            {
                square_of_sum += i;
                sum_of_squares += (i * i);
            }
            square_of_sum = square_of_sum * square_of_sum;
            rezultatas = square_of_sum - sum_of_squares;
            Console.WriteLine(rezultatas);

            Console.ReadLine();

        }
    }
}
