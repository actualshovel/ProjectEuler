// A Pythagorean triplet is a set of three natural numbers, a < b< c, for which,
// a2 + b2 = c2
// For example, 32 + 42 = 9 + 16 = 25 = 52.

// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
// Find the product abc.

using System;

namespace ProjectEuler
{
    class Problem009
    {
        public static void Main(string[] args)
        {
            int[] angles = FindSides(1000);
            int product = 1;

            foreach (var item in angles)
            {
                Console.WriteLine(item);
                product *= item;
            }

            Console.WriteLine("Product of abc = {0:N}", product);

            
            Console.ReadLine();
        }


        // find value of a pythagorean special triplet given the sum of all 3 sides
        public static int[] FindSides(int sum)
        {
            int a, b, c;
            int[] answer = {0, 0, 0 };

            // using principles we know from pythagoras, 'a' can be
            // no larger than a third of 'sum'
            // because a < b < c
            // AND a + b + c = 1000
            for (a = 1; a <= sum/3; a++)
            {
                // 'b' can be no larger than half of 'sum'
                for (b = a+1; b <= sum/2; b++)
                {
                    // knowing the sum of all 3 variables, we can figure out 'c'
                    c = sum - a - b;
                    // once c is calculated, we check if it's a right triangle
                    if (a*a + b*b == c*c)
                    {
                        answer[0] = a;
                        answer[1] = b;
                        answer[2] = c;
                        return answer;
                    }
                }
            }
            return answer;
        }
    }
}
