using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public class Problem002
    {
        public static string Fibonacci()
        {
            int sum = 0;
            int max = 4000000;
            int a = 1, b = 2;
            int c;

            while (sum <= max) //loop until 4mil
            {
                //only work with the even terms
                if (a % 2 == 0)
                    //add term 1 to the total
                    sum += a;
                //a variable to hold current 2 numbers to be added
                c = a + b;
                //move on to the next 2 numbers
                a = b;
                b = c;
            }
            
            string s = "Fibonacci: " + sum.ToString();
            return s;

        }
    }
}
