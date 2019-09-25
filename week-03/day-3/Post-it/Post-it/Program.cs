using System;

namespace Post_it
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a PostIt a struct that has
            // a BackgroundColor
            // a Text on it
            // a TextColor
            // Create a few example post-it objects:
            // an orange with blue text: "Idea 1"
            // a pink with black text: "Awesome"
            // a yellow with green text: "Superb!"

            PostIt postItOne = new PostIt("orange", "Idea 1", "blue");
            PostIt postItTwo = new PostIt("pink", "Awesome", "black");
            PostIt postItThree = new PostIt("yellow", "Superb!", "green");
        }
    }
}
