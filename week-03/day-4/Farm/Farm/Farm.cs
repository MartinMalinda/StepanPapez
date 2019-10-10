using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    // Create a Farm class
    // it has list of Animals
    // it has slots which defines the number of free places for animals
    // Breed() -> creates a new animal if there's place for it
    // Slaughter() -> removes the least hungry animal

    class Farm
    {
        public List<Animal> ListOfAnimals { get; private set; }
        public int Slots { get; private set; }

        public Farm(int slots)
        {
            ListOfAnimals = new List<Animal>();
            Slots = slots;
        }

        public void Breed()
        {
            if(Slots > 0)
            {
                var animal = new Animal();
                ListOfAnimals.Add(animal);
                Slots--;
            }
            else
            {
                Console.WriteLine("The Farm is full");
            }
        }

        public void Slaughter()
        {
            int lowestHunger = 50;
            int index = 0;

            for (int i = 0; i < ListOfAnimals.Count; i++)
            {
                if (ListOfAnimals[i].Hunger <= lowestHunger)
                {
                    lowestHunger = ListOfAnimals[i].Hunger;
                    index = i;
                }
            }
            ListOfAnimals.Remove(ListOfAnimals[index]);
        }

        public void SlaughterAnimal()
        {
            Animal target = null;

            foreach (var animal in ListOfAnimals)
            {
                if(target == null || animal.Hunger < target.Hunger)
                {
                    target = animal;
                }
            }
            ListOfAnimals.Remove(target);
        }
        public void Add(Animal animal)
        {
            ListOfAnimals.Add(animal);
            Slots--;
        }
    }
}
