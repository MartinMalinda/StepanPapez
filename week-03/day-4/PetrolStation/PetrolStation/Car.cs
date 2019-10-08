using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    // GasAmount
    // Capacity
    // create constructor for Car where:
    // initialize gasAmount -> 0
    // initialize capacity -> 100
    class Car
    {
        public int GasAmount { get; set; }
        public int Capacity { get; set; }

        public Car()
        {
            GasAmount = 0;
            Capacity = 100;
        }
    }
}
