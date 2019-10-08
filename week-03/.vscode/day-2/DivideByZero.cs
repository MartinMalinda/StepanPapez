using System;
using System.Collections.Generic;

namespace Example
{
    public class Example
    {
        public static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0
            Divide10();
        }
        public static void Divide10()
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int divisor = int.Parse(Console.ReadLine());
                int result = 10 / divisor;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("fail");
            }
            catch (Exception e)
            {
                Console.WriteLine("uuups, some serious thing happened!");
            }
        }
    }
}
