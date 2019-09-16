using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`
            int[] aj = { 3, 4, 5, 6, 7 };

            //(aj[0], aj[1], aj[3], aj[4]) = (aj[4], aj[3], aj[1], aj[0]);
            Array.Reverse(aj);

            foreach (int number in aj)
            {
                Console.WriteLine(number);
            }
        }
    }
}