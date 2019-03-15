// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
// Find the sum of all the primes below two million.

using System;

namespace ProjectEuler
{
    class Problem010
    {
        public static void Main(string[] args)
        {
            int limit = 2000000;
            bool[] primes = Sieve(limit);
            long primeSum = 0;

            for (int i = 0; i < limit; i++)
            {
                if (primes[i] == true)
                    primeSum += i;
            }

            Console.WriteLine("The sum of all prime numbers under 2 million: {0:N}", primeSum);
            Console.ReadLine();
        }

        public static bool[] Sieve(int n)
        {
            bool[] chart = new bool[n];

            //set all value in array as true
            //they are not marked off yet
            for (int i = 0; i < n; i++)
            {
                chart[i] = true;
            }
            // zero and one are not prime. mark as false
            chart[0] = false;
            chart[1] = false;

            // start at 2, up to the square root of n
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                // if the next iteration is true, do next for loop
                // if it has been marked as false, skip the loop and iterate
                if (chart[i])
                {
                    for (int j = i*i; j < n; j += i)
                    {
                        chart[j] = false;
                    }
                }
            }
            return chart;
        }
    }
}
