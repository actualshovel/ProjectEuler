/*What is the smallest positive number that 
 * is evenly divisible by all of the numbers from 1 to 20
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    class Problem05
    {
        public static void Main(string[] args)
        {
            //just incase the result is some massive number, I'll use long
            long target = 20;
            long answer = 0;
            int counter = 0;
            long[] divisors = new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            bool found = false;
            while(found == false)
            {
                //check numbers in array against the answer I'm looking for
                for (int i = 0; i < divisors.Length; i++)
                {
                    if (target % divisors[i] == 0)
                    {
                        answer = target;
                        //keep track of how many divisors were successful
                        counter++;
                    }
                    else
                        break;
                    //if all 20 numbers divide evenly into target, we are done
                    if (counter == 20) {
                        found = true;
                        break; }
                }
                //I can increment by 20 each time and reset the counter for a new set of tests
                target += 20;
                counter = 0;
            }
            Console.WriteLine("Found it! {0:0,0}", answer);
            Console.ReadLine();
            
        }
    }
}
