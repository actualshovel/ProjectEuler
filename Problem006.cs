/*The sum of the squares of the first ten natural numbers is,

1^2 + 2^2 + ... + 10^2 = 385
The square of the sum of the first ten natural numbers is,

(1 + 2 + ... + 10)^2 = 552 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/
using System;

namespace Classwork
{
    class Problem006
    {
        static void Main(string[] args)
        {
            //calculate difference and store in a variable
            int sumSquareDifference = SquareOfSum(100) - SumOfSquares(100);

            Console.WriteLine(sumSquareDifference);

            Console.ReadLine();
        }
        
        //square every number up to [naturalNumber], then find the sum
        static int SumOfSquares(int naturalNumber)
        {
            int sumOfSquares = 0;
            for (int i = 1; i <= naturalNumber; i++)
            {
                sumOfSquares += (i * i);
            }
            return sumOfSquares;
        }
        
        //find sum of every number up to [naturalNumber], then square it
        static int SquareOfSum(int naturalNumber)
        {
            int squareOfSum = 0;
            for (int i = 1; i <= naturalNumber; i++)
            {
                squareOfSum += i;
            }
            return squareOfSum * squareOfSum;
        }
    }
}
