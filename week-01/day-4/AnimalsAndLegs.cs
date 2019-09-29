using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            int numberOfChickenLegs = 2;
            int numberOfPigLegs = 4;

            Console.WriteLine("Enter a number of chickens:");
            int numberOfChickens = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number of pigs:");
            int numberOfPigs = Convert.ToInt32(Console.ReadLine());

            int totalChickenLegs = numberOfChickens * numberOfChickenLegs;
            int totalPigLegs = numberOfPigs * numberOfPigLegs;
            int sumOfLegs = totalChickenLegs + totalPigLegs;

            Console.WriteLine($"Sum of all legs is: {sumOfLegs}");
        }
    }
}
