using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            
            // First solution:

            int numberOfRows = 8;
            string row = "% % % %";

            for (int i = 0; i < numberOfRows; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(" " + row);
                }
                else
                {
                    Console.WriteLine(row);
                }
            }

            Console.WriteLine();
            // Second solution:


            int size = 8;
            string fields = "% ";

            for (int i = 0; i < size; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < size / 2; j++)
                {
                    Console.Write(fields);
                }
                Console.WriteLine();
            }
        }
    }
}
