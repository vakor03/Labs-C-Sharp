using System;
using System.Linq;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your x: ");
            double x = double.Parse(Console.ReadLine());
            
            Console.Write("Input your eps: ");
            float eps = float.Parse(Console.ReadLine());

            int n = 1;
            double lastEl = x;
            double Sh = x;
            while (eps < lastEl)
            {
                
                lastEl *= Math.Pow(x, 2) / (2 * n * (2 * n + 1));
                Sh = Sh + lastEl;
                n += 1;
                Console.WriteLine($"Sh = {Sh,10:F7}, n = {n}, lastEl = {lastEl:F7}");

            }
            Console.WriteLine($"Final Sh = {Sh:F7}");
        }
    }
}