﻿using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Counter class
            // which has an integer property
            // when creating it should have a default value 0 or we can specify it when creating
            // we can Add(number) to this counter another whole number
            // or we can Add() without parameters just increasing the counter's value by one
            // and we can Get() the current value as string
            // also we can Reset() the value to the initial value

            Counter counterOne = new Counter();

            counterOne.Add(42);
            Console.WriteLine(counterOne.Value);

            counterOne.Reset();

            Console.WriteLine(counterOne.Get());

        }
    }
}
