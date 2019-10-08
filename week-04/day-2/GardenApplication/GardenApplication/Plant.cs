using System;
using System.Collections.Generic;
using System.Text;

namespace GardenApplication
{
    public class Plant
    {
        public string Color { get; private set; }
        public int CurrentAmountOfWater { get; private set; }

        public Plant()
        {

        }

        public Plant (string color, int currentAmountOfWater)
        {
            this.Color = color;
            this.CurrentAmountOfWater = currentAmountOfWater;
        }

        // public virtual void NeedWater()
        // {
        //     if(CurrentAmountOfWater < 5)
        //     {
        //         Console.WriteLine($"The {Color} needs water");
        //     }
        //     else
        //     {
        //         Console.WriteLine($" The {Color} doesnt need water");
        //     }
        }
    }
}
