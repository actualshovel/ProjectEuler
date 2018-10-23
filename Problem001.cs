using System;

namespace ProjectEuler
{
    class Problem001
    {
        static void Main(string[] args)
        {
            int sum = 0;

            //count from 1 to 1000 using a 'for' loop
            for (int i = 1; i < 1000; i++)
            {
                //if 'x' modulo 'y' == 0, then 'x' is a multiple of 'y'
                if (i % 3 == 0 || i % 5 == 0)
                {
                    //display every number to be added
                    Console.Write(i + "-");
                    
                    //add and store the new value in the 'sum' variable
                    sum += i;
                }
            }

            //display final sum
            Console.WriteLine("\nThe sum of all multiples of 3 or 5 below 1000 is: {0}", sum);
            Console.ReadLine();
        }
    }
}
