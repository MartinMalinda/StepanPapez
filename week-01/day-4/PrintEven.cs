using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints all the even numbers between 0 and 500
            int a = 0;

            while (a + 2 < 500)
            {
                a += 2;
                Console.WriteLine(a);
            }

            //or with for loop, but it doesn't start from 0 and it annoys me.
            //for (i = 2; i < 500; i += 2)
            //  {
            //   Console.WriteLine(i); 
            //  }
        }
    }
}