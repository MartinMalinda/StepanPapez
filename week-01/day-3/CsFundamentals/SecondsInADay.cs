
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables
            int hoursInADay = 24;
            int minutesInAnHour = 60;
            int secondsInAMinute = 60;
            int totalSecondsInADay = hoursInADay * minutesInAnHour * secondsInAMinute;
            int currentSecondsInADay = (currentHours * minutesInAnHour * secondsInAMinute) + (currentMinutes * secondsInAMinute) + currentSeconds;
            Console.WriteLine(totalSecondsInADay - currentSecondsInADay);
        }
    }
}