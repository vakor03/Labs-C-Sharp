using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            
            Console.Write("Enter angle between a and b: ");
            double angle = double.Parse(Console.ReadLine());
            
            double angleInRad = Math.PI * angle/180;
            double sinAngle = Math.Sin(angleInRad);
            double S = a * b * sinAngle * 0.5;
            
            Console.WriteLine("S = "+ S);
        }
    }
}