using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1: Write a LINQ Expression to get the even numbers from the following array:
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            // query syntax
            var evenNumbers2 = from number in numbers
                               where number % 2 == 0
                               select number;

            // Print all even numbers to the console:
            numbers.Where(n => n % 2 == 0).ToList().ForEach(n => Console.WriteLine(n));

            // Exercise 2: Write a LINQ Expression to get the average value of the odd numbers:
            var averageOfOddNumbers = numbers.Where(n => n % 2 != 0).Average();

            // query syntax
            var averageOfOddNumbers2 = (from number in numbers
                                        where number % 2 != 0
                                        select number)
                                        .Average();

            // Exercise 3: Write a LINQ Expression to get the squared value of the positive numbers:
            var sumOfPositiveNumbers = numbers.Where(n => n > 0).Sum();
            var sumOfPositiveNumbersSquared = sumOfPositiveNumbers * sumOfPositiveNumbers;

            // query syntax
            var sumOfPositiveNumbers2 = (from number in numbers
                                   where number > 0
                                   select number)
                                   .Sum();
            var sumOfPositiveNumbersSquared2 = sumOfPositiveNumbers2 * sumOfPositiveNumbers2;

            // Exercise 4: Write a LINQ Expression to find which number squared value is more then 20 from the following array:
            int[] numbersTwo = { 3, 9, 2, 8, 6, 5 };

            var squaredNumberBiggerThanTwenty = numbersTwo.Where(n => n * n > 20);

            // query syntax
            var squaredNumberBiggerThanTwenty2 = from number in numbersTwo
                                                 where number * number > 20
                                                 select number;

            // Exercise 5: Write a LINQ Expression to find the frequency of numbers in the following array:
            int[] numbersThree = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var grouppedNumbers = numbersThree.GroupBy(n => n).ToList();//.ForEach(n => Console.WriteLine($"Number: {n.Key}, Frequency: {n.Count()}"));

            // dictionary solution
            // var numbersAndFrequency = new Dictionary<int, int>();
            // numbersThree.GroupBy(n => n).ToList().ForEach(n => numbersAndFrequency.Add(n.Key, n.Count()));
            var numbersAndFrequency = numbersThree.GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

            // Exercise 6: Write a LINQ Expression to find the frequency of characters in a given string.
            var stringInput = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.";
            var chars = stringInput.ToCharArray();
            chars.Where(c => c != ' ' && c != ',' && c != '.').GroupBy(c => c).ToList().ForEach(c => Console.WriteLine($"Character: {c.Key}, Frequency: {c.Count()}"));

            // Exercise 7: Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            // Exercise 8: Write a LINQ Expression to find the uppercase characters in a string.

            // Exercise 9: Write a LINQ Expression to convert a char array to a string.

            // Exercise 10: Create a Fox class with 3 properties: name, type and color.
            // Fill a list with at least 5 foxes, it's up to you how you name/create them.
            // Write a LINQ Expression to find the foxes with green color.
            // Write a LINQ Expression to find the foxes with green color and pallida type.
        }
    }
}
