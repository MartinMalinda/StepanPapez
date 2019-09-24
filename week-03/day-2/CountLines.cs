using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            CountLines();
        }
    public static void CountLines()
        {
            string path = @"../../../";
            Console.WriteLine("Enter a file name:");
            string fileName = Console.ReadLine();

            try
            {
                string[] content = File.ReadAllLines(path + fileName);
                Console.WriteLine($"Number of lines: {content.Length}");
            }
            catch (Exception)
            {
                Console.WriteLine("0");
            }
        }
    }
}
