using System;
using System.Collections.Generic;
using System.Text;

namespace Comparable
{
    public class Domino : IComparable 
    {
        private readonly int[] values;

        public Domino(int valueA, int valueB)
        {
            this.values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return values;
        }
        
        // TO DO
        public 
    }
}