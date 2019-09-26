using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Fleet
    {

        private List<Thing> things;

        public Fleet()
        {
            things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            things.Add(thing);
        }

        public void PrintFleet()
        {
            for (int i = 0; i < things.Count ; i++)
            {
                Console.Write($"{i}. [");
                if(things[i + 1].IsCompleted() == true)
                {
                    Console.Write("x");
                }
                else
                {
                    Console.Write(" ");
                }
                Console.WriteLine($"] {things[i].GetName()}");
            }
        }
    }
}