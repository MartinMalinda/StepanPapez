using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int storedNumber = 42;
            Console.WriteLine("Guess a number. It's something between 1 and 100:");

            try
            {
                int guessedNumber = Convert.ToInt32(Console.ReadLine());

                while(guessedNumber != storedNumber)
                {
                    if (guessedNumber <= 0 || guessedNumber > 100)
                    {
                        Console.WriteLine("The number you're looking for is between 1 and 100!");
                    }
                    else if(guessedNumber < storedNumber)
                    {
                        Console.WriteLine("The number you're looking for is higher.");
                    }
                    else
                    {
                        Console.WriteLine("The number you're looking for is lower.");
                    }
                    Console.WriteLine("Guess again:");
                    guessedNumber = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine($"Congratulations! The number is {guessedNumber}.");
            }
            catch (Exception)
            {
                Console.WriteLine("I'm afraid I can't let you do that.");
            }
        }
    }
}
