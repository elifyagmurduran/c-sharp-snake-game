using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            // simple input example
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Nice to meet you, {name}!");

            // keep console open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}