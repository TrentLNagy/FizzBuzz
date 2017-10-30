/* This is my answer to the Fizz Buzz problem. This program is designed to print 
out numbers 1 - 100 with each number having its own line. Every time the number
is divisible by 3, then it will replace the number with the word "Fizz". If the 
number is divisible by 5, then it will replace the number with "Buzz". If both apply,
then replace the number with "FizzBuzz". Otherwise, if they aren't divisible, then it
will show the normal number.

  I've designed this program to be a little more adaptable than other fizzbuzz solutions,
  allbeit a little more complex than it probably should be. I've declared both fizz and buzz
  as changeable variables, so the user can output whatever they want instead of fizz/buzz.
  I've also declared 3 variables for the factors of the division: The fizz division, the buzz 
  division, and the desired remainder. All of them are set to the defaults.
  
    Now, I understand people will look at this and say that it's more complicated than it needs
    to be, and "I can write it in only one line". But I'm not going for simple and fast, im planning
    more ahead when it comes to changing ideas. Soon, when i become a better programer, i'll put this 
    through Visual Studio and you will be able to add or remove different fizz/buzz variables.
      
                                                                          -Trent Nagy
*/
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

            //Start a loop that counts from 1 to 100 by 1s while
            //also declaring an int, i, to reference the numbers
            for (int i = 1; i <= 100; i++)
            {
                //if the int i is divisible by both X and Y, then replace i with
                //string one and two
                if (i % x == z && i % y == z)
                {
                    Console.WriteLine(i + ": " + one + two);
                }
                //if the previous doesn't apply, then if the int i is divisible
                //by variable x, then replace i with string one
                else if (i % x == z)
                {
                    Console.WriteLine(i + ": " + one);
                }
                //if the previous doesn't apply, then if the int i is divisible
                //by variable y, then replace i with string two
                else if (i % y == z)
                {
                    Console.WriteLine(i + ": " + two);
                }
                //if neither can be divided with a remainder of int z,
                //just write i.
                else
                {
                    Console.WriteLine(i);
                }
            }
          //this makes the program sleep for a long time after it outputs to the console.
          //this is to let the user read the output instead of immediately closing after
          //the program has printed to the console.
          System.Threading.Thread.Sleep(5000*10);
        }
    }
}
