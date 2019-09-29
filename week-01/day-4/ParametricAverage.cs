using System;
using System.Collections.Generic;

namespace ParametricAverage
{
    public class ParametricAverage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many numbers you want to calculate with:");
            int numberOfInputs = Convert.ToInt32(Console.ReadLine());
            double sumOfInputs = 0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                Console.WriteLine("Enter a number:");
                sumOfInputs += Convert.ToInt32(Console.ReadLine());
            }

            double averageOfInputs = sumOfInputs / numberOfInputs;

            Console.WriteLine($"Sum: {sumOfInputs}, Average: {averageOfInputs}");
        }
    }
}