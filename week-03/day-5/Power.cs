using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively(no loops) the value of base to the n power, so powerN(3, 2) is 9(3 squared).

            Console.WriteLine(Power(6, 6));
        }
        public static int Power(int x, int n)
        {
            
            if(n == 1)
            {
                return x;
            }
            else
            {
                return x * Power(x, n - 1);
            }
        }
    }
}
