using System;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            var farm = new Farm(5);

            var pigMale = new Animal(42, 42);
            farm.Add(pigMale);
            var pigFemale = new Animal(35, 35);
            farm.Add(pigFemale);
            var goatMale = new Animal(32, 32);
            farm.Add(goatMale);
            var goatFemale = new Animal(25, 25);
            farm.Add(goatFemale);

            farm.Breed();
            farm.Breed();

            farm.Slaughter();
        }
    }
}
