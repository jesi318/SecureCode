// See https://aka.ms/new-console-template for more information

using System;

class Program
{

    static void Main(string[] args)
    {
        Thread t1 = new Thread(RaceConditionFixed.Increment);
        Thread t2 = new Thread(RaceConditionFixed.Increment);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Counter: " + RaceConditionFixed.counter);
    }

}
