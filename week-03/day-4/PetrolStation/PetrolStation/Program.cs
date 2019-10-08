using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var station = new Station(100);
            var car = new Car();

            station.Refill(car);

            Console.WriteLine(station.GasAmount);
            Console.WriteLine(car.GasAmount);
        }
    }
}
