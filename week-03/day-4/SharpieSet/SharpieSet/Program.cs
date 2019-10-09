using System;

namespace SharpieSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var sharpieOne = new Sharpie("blue", 1);
            var sharpieTwo = new Sharpie("red", 0.5);
            var sharpieThree = new Sharpie("purple", 1);
            var setOne = new SharpieSet();

            setOne.Add(sharpieOne);
            setOne.Add(sharpieTwo);
            setOne.Add(sharpieThree);

            for (int i = 0; i < 100; i++)
            {
                sharpieOne.Use();
            }

            Console.WriteLine($"Number of usable sharpies: {setOne.CountUsable()}");
            setOne.RemoveTrash();
        }
    }
}
