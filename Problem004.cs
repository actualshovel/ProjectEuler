/* A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
* Find the largest palindrome made from the product of two 3-digit numbers.
*/

using System;
class Problem004
{
static void Main(string[] args)
    {
        int product = 0;
        int max = 0;
        
        for(int i = 999; i > 100; i--)
        {
            for(int j = 999; j > 100; j--)
            {
                product = i*j;
                if (IsPalindrome(product))
                {
                    if (product > max)
                        max = product;
                }
            }

        }
        Console.WriteLine(max); //answer: 906609
        Console.ReadLine();
    }

    //get the remainder, divide number by 10, multiply by 10 & add remainder, repeat until 0
    //number will be flipped. compare with parameter for palindrome
    private static bool IsPalindrome(int x)
    {
        int temp = x;
        int reverse = 0;
        int remainder = 0;

        while (temp > 0)
        {
            remainder = temp % 10;
            temp /= 10;
            reverse = reverse * 10 + remainder;
        }
        if (x == reverse)
            return true;
        else
            return false;
    }
}
