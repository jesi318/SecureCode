// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("Enter a number: ");
            int a = Console.Readline();
            Console.WriteLine("Enter another number: ");
            int b = Console.Readline();
                int result = IntegerOverflow.Add(a, b);
                Console.WriteLine("Result: " + result);
    }

}