using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative integer n, return the sum of its digits recursively (without loops).
            // Hint
            // Mod(%) by 10 yields the rightmost digit(e.g. 126 % 10 is 6)
            // Divide (/) by 10 removes the rightmost digit (e.g. 126 / 10 is 12).

            Console.WriteLine(SumDigits(123456789));
        }
        public static int SumDigits(int n)
        {
            int nLength = Convert.ToString(n).Length;
            if(nLength == 1)
            {
                return n;
            }
            else
            {
                return (n % 10) + SumDigits(n / 10);
            }
        }
    }
}
