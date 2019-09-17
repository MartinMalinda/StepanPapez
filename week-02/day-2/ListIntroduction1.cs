using System;
using System.Collections.Generic;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            //We are going to play with lists.Feel free to use the built-in methods where possible.
            //Create an empty list which will contain names(strings)
            List<string> names = new List<string>();

            //Print out the number of elements in the list
            Console.WriteLine("Number of elements in the list is: " + names.Count);
            Console.WriteLine();

            //Add William to the list
            names.Add("William");

            //Print out whether the list is empty or not
            if (names.Count == 0)
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                Console.WriteLine("The list is not empty");
            }
            Console.WriteLine();

            //Add John to the list
            names.Add("James");

            //Add Amanda to the list
            names.Add("Amanda");

            //Print out the number of elements in the list
            Console.WriteLine("Number of elements in the list is: " + names.Count);
            Console.WriteLine();

            //Print out the 3rd element
            Console.WriteLine("3rd element is: " + names[2]);
            Console.WriteLine();

            //Iterate through the list and print out each name
            //William
            //John
            //Amanda
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            //Iterate through the list and print
            //1.William
            //2.John
            //3.Amanda
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(i+1 + ". " + names[i]);
            }
            Console.WriteLine();

            //Remove the 2nd element
            names.RemoveAt(1);

            //Iterate through the list in a reversed order and print out each name
            //Amanda
            //William

            for (int i = names.Count-1; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine();

            //OR
            names.Reverse();

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //Remove all elements
            names.Clear();

            Console.WriteLine("Number of elements in the list is: " + names.Count);
        }
    }
}