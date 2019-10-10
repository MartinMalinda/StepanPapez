using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    class Animal
    {
        public int Hunger { get; private set; }
        public int Thirst { get; private set; }


        public Animal()
        {
            Hunger = 50;
            Thirst = 50;
        }
        public Animal(int hunger, int thirst)
        {
            Hunger = hunger;
            Thirst = thirst;
        }

        public void Eat()
        {
            Hunger--;
        }
        public void Drink()
        {
            Thirst--;
        }
        public void Play()
        {
            Hunger++;
            Thirst++;
        }
    }
}