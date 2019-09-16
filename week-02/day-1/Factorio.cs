using System;

namespace Factorio
{
    class Program
    {
        public static int Factorio(int input)
        {
            int factorial = 1;
            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static void Main(string[] args)
        {
            // - Create a function called `Factorio`
            //   that returns it's input's factorial

            Console.WriteLine("Enter a number you want to factorialize:");
            int inputOfUser = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorio(inputOfUser));
        }
    }
}