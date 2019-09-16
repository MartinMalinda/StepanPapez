using System;

namespace Sum
{
    class Program
    {
        public static int Sum(int input)
        {
            int total = 0;
            for (int i = 0; i <= input; i++)
            {
                total += i; 
            }
            return total;
        }
        static void Main(string[] args)
        {
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter

            Console.WriteLine("Enter a number you want to \"sum\":");
            int inputOfUser = int.Parse(Console.ReadLine());

            Console.WriteLine(Sum(inputOfUser));

        }
    }
}