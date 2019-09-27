using System;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
            // 1 + 2 + 3 + 4 + 5 + 6  + 7 + 8 + 9...
            // 1, 3, 6, 10, 15, 21, 28, 36, 45...
            // (n * n + 1) / 2 

            Console.WriteLine(AddNumbersWithRecursion(6));
        }
        public static int AddNumbersWithRecursion(int n)
        {
            if (n < 1)
            {
                return -1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + AddNumbersWithRecursion(n - 1);
            }
        }
    }
}
