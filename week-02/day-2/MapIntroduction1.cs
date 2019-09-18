using System;
using System.Collections.Generic;

namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {
            // Create an empty map where the keys are integers and the values are characters
            Dictionary<int, char> map = new Dictionary<int, char>();

            // Print out whether the map is empty or not
            if (map.Count == 0)
            {
                Console.WriteLine("EMPTY");
            }
            else
            {
                Console.WriteLine("NOT EMPTY");
            }

            // Add the following key-value pairs to the map
            map.Add(97, 'a');
            map.Add(98, 'b');
            map.Add(99, 'c');
            map.Add(65, 'A');
            map.Add(66, 'B');
            map.Add(67, 'C');

            // Print all the keys
            foreach (int key in map.Keys)
            {
                Console.WriteLine(key);
            }

            // Print all the values
            foreach (char value in map.Values)
            {
                Console.WriteLine(value);
            }

            // Add value D with the key 68
            map.Add(68, 'D');

            // Print how many key-value pairs are in the map
            Console.WriteLine(map.Count);

            // Print the value that is associated with key 99
            char letter;
            map.TryGetValue(99, out letter);
            Console.WriteLine(letter);

            // Remove the key - value pair with key 97
            map.Remove(97);

            // Print whether there is an associated value with key 100 or not

            char test100;
            if (map.TryGetValue(100, out test100))
            {
                Console.WriteLine("Value is " + test100);
            }
            else
            {
                Console.WriteLine("Couldn't find the value.");
            }

            // Remove all the key-value pairs
            map.Clear();

            /*
            foreach (var item in map)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}