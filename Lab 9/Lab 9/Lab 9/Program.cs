using System;
using static StringLibrary.LaB9;


namespace Lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine($"New string: \"{lab(str, out int counter)}\"\nNumber of repeated symbols = {counter}");
        }
    }
}