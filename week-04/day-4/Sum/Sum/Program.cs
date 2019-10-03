using System;
using System.Collections.Generic;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class SumList
    {
        public int SumIt(List<int> list)
        {
            int currentSum = 0;
            if (list == null)
            {
                return currentSum;
            }
            foreach (var item in list)
            {
                currentSum += item;
            }
            return currentSum;
        }
    }

}
