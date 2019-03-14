// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
// What is the 10 001st prime number?

using System;
namespace Leetcode
{
    class Problem007
    {
        static void Main(string[] args)
        {
            int testNumber = 1;
            int lastPrime = 0;
            int count = 0;

            // count ten thousand and one prime numbers
            while (count != 10001)
            {
                if (IsPrime(testNumber))
                {
                    // only add to the count if the number is prime
                    count++;
                    // keep track of most recent prime number
                    lastPrime = testNumber;
                }
                testNumber++;
            }
            Console.WriteLine("The 10,001st prime number is {0:N1}", lastPrime);
            Console.ReadLine();
        }

        
        public static bool IsPrime(int n)
        {
            if (n == 1)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;

            // if any number bewteen n and 2 evenly divides into n, n isn't prime
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
