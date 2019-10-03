﻿using System;

namespace Anagram
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Write a function, that takes two strings and returns a boolean value based
            // on if the two strings are Anagramms or not.
            // Create a test for that.
            IsAnagram("listen", "silent");
        }
        public static bool IsAnagram(string inputString1, string inputString2)
        {
            char[] array1 = inputString1.ToCharArray();
            Array.Sort(array1);
            string sortedString1 = new string(array1);

            char[] array2 = inputString2.ToCharArray();
            Array.Sort(array2);
            string sortedString2 = new string(array2);

            if (sortedString1 == sortedString2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}