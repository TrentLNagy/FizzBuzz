using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare three integers.
            //both factors correspond with x and y,
            //while the desired remainder corresponds with z.
            int x = 3;
            int y = 5;
            int z = 0;
            //declare two string values to replace when x and y are divisible with
            //a remainder of z.
            string one = "Fizz";
            string two = "Buzz";

            //Start a loop that counts from 1 to 100 by 1s
            for (int i = 1; i <= 100; i++)
            {
                //if both x and y can be divided with a remainder of int z,
                //write strings one and two
                if (i % x == z && i % y == z)
                {
                    Console.WriteLine(i + ": " + one + two);
                }
                //if only x can be divided with a remainder of int z,
                //write string one
                else if (i % x == z)
                {
                    Console.WriteLine(i + ": " + one);
                }
                //if only y can be divided with a remainder of int z,
                //write string two
                else if (i % y == z)
                {
                    Console.WriteLine(i + ": " + two);
                }
                //if neither can be divided with a remainder of int z,
                //just write the number
                else
                {
                    Console.WriteLine(i);
                }
            }
            System.Threading.Thread.Sleep(5000*10);
        }
    }
}