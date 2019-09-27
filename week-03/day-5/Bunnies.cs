using System;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears. 
            // We want to compute the total number of ears across all the bunnies recursively 
            // (without loops or multiplication).

            Console.WriteLine(GetEars(42));
        }
        public static int GetEars(int numberOfBunnies)
        {
            if(numberOfBunnies == 1)
            {
                return 2;
            }
            else
            {
                return 2 + GetEars(numberOfBunnies - 1);
            }
        }
    }
}
