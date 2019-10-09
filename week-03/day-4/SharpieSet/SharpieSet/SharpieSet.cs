using System;
using System.Collections.Generic;
using System.Text;

namespace SharpieSet
{

    // Create SharpieSet class
    // it contains a list of Sharpie
    // Add method CountUsable() -> sharpie is usable if it has ink in it
    // Add method RemoveTrash() -> removes all unusable sharpies

    class SharpieSet
    {
        public List<Sharpie> SetOfSharpies { get; set; }

        public SharpieSet()
        {
            SetOfSharpies = new List<Sharpie>();
        }

        public int CountUsable()
        {
            int counter = 0;
            foreach (var sharpie in SetOfSharpies)
            {
                if (sharpie.InkAmount > 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public void RemoveTrash()
        {
            for (int i = 0; i < SetOfSharpies.Count; i++)
            {
                if (SetOfSharpies[i].InkAmount <= 0)
                {
                    SetOfSharpies.Remove(SetOfSharpies[i]);
                    i--;
                }
            }
        }

        public void Add(Sharpie sharpie)
        {
            SetOfSharpies.Add(sharpie);
        }
    }
}
