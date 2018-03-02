using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Counter class
            //which has an integer property
            //when creating it should have a default value 0 or we can specify it when creating
            //we can Add(number) to this counter another whole number
            //or we can Add() without parameters just increasing the counter's value by one
            //and we can Get() the current value as string
            //also we can Reset() the value to the initial value

            Counter count = new Counter();

            Console.WriteLine(count.Value);
            Console.WriteLine(count.Add(10));
            Console.WriteLine(count.Add());
            Console.WriteLine(count.Get());
            Console.WriteLine(count.Reset());
            Console.WriteLine(count.Add());
            Console.WriteLine(count.Add());

            Console.ReadLine();
        }
    }
}
