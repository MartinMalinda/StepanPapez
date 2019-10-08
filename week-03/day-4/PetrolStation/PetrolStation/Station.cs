using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    // GasAmount
    // Refill(car) -> decreases the gasAmount by the capacity of the car and increases the cars gasAmount
    class Station
    {
        public int GasAmount { get; set; }
        
        public Station(int gasAmount)
        {
            this.GasAmount = gasAmount;
        }

        public void Refill(Car car)
        {
            this.GasAmount -= car.Capacity;
            car.GasAmount += car.Capacity;
        }
    }
}
