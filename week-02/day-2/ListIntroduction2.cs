using System;
using System.Collections.Generic;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            // Create a list('List A') which contains the following values
            // Apple, Avocado, Blueberries, Durian, Lychee
            List<string> ListA = new List<string>() { "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };

            // Create a new list('List B') with the values of List A
            List<string> ListB = new List<string>(ListA);
            foreach (var item in ListB)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Print out whether List A contains Durian or not
            Console.WriteLine("Does ListA contain \"Durian\"?: " + ListA.Contains("Durian"));

            // Remove Durian from List 
            ListB.Remove("Durian");
            Console.WriteLine("Does ListB contain \"Durian\"?: " + ListB.Contains("Durian"));

            // Add Kiwifruit to List A after the 4th element
            ListA.Insert(4, "Kiwifruit");
            Console.WriteLine("Does ListA contain \"Kiwifruit\"?: " + ListA.Contains("Kiwifruit"));

            // Compare the size of List A and List B
            bool isABigger = ListA.Count > ListB.Count ? true : false;
            Console.WriteLine($"Is List A bigger than List B?: {isABigger}");

            // Get the index of Avocado from List A
            Console.WriteLine($"Index of \"Avocado\" in List A is: {ListA.IndexOf("Avocado")}");

            // Get the index of Durian from List B
            Console.WriteLine($"Index of \"Durian\" in List B is: {ListB.IndexOf("Durian")}. If the value is -1, it is not in the list.");

            // Add Passion Fruit and Pomelo to List B in a single statement
            string[] fruitsToAdd = { "Passion Fruit", "Pomelo" };
            ListB.AddRange(fruitsToAdd);

            foreach (var item in ListB)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Print out the 3rd element from List A
            Console.WriteLine(ListA[2]);
        }
    }
}
