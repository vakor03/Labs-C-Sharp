using System;
using static lib.LB;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input amount of dots: ");
            int n = Int32.Parse(Console.ReadLine());
            InitDots(n, out double[,] dots);
            DotsPrint(dots, n);
            DotsWMaxDist(n, dots, out int d1, out int d2, out double dist);
            Console.WriteLine($"The max distance is {dist:F2} between dots {d1+1} and {d2+1}");
        }
    }
}