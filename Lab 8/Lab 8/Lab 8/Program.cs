using System;

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

        private static double FindDist(double x1, double y1, double x2, double y2) =>
            Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

        private static void InitDots(int n, out double[,] dots)
        {
            Random rand = new Random();
            dots = new double[n,2];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    dots[i, j] = rand.Next(-10, 10);
                }
            }
        } 
        private static void DotsPrint(double[,] dots, int n)
        {
            for (int i = 0; i < n; i++) Console.WriteLine($"Dot {i+1,2}:({dots[i,0],2},{dots[i,1], 2})");
        }

        private static void DotsWMaxDist(int n, double[,] dots, out int firDot, out int secDot, out double dist)
        {
            dist = 0;
            firDot = -1;
            secDot = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    double tempDist = FindDist(dots[i, 0], dots[i, 1], dots[j, 0], dots[j, 1]);
                    Console.WriteLine($"Distance between dots {i+1} and {j+1} is {tempDist:F2}");
                    if (tempDist>dist)
                    {
                        dist = tempDist;
                        firDot = i;
                        secDot = j;
                    }
                }
            }
        }



    }
}