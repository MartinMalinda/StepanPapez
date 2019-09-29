using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it
            double mi2Km = 1.609344;
            Console.WriteLine("Enter a number of miles (decimal) you want to convert:");
            double inputMiles = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(inputMiles * mi2Km);
        }
    }
}