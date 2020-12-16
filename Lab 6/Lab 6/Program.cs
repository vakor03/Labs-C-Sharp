using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your eps: ");
            double eps = double.Parse(Console.ReadLine());
            //double eps = 0.01;
            
            for (double i = 0.5; i <= 3; i+=0.5)
            {
                Console.WriteLine($"x = {i}, Ln = {FindY(i, eps)}");
            }
        }
        
        private static double Ln(double x, double eps)
        {
            if (x == 0) return  Int32.MaxValue;

            double currEl = x - 1;
            int n = 2;
            double sum = currEl;
            do
            {
                currEl = Math.Pow(-1, n-1) * Math.Pow(x - 1, n) / (double) n;
                sum += currEl;
                n++;
            } while (Math.Abs(currEl) > eps);
            return sum; 
        }

        private static double FindY(double x, double eps)
        {
            
            double res = 0;
            if (x < 2){
                res = Ln(x, eps) + Ln(x/2, eps);
            }
            else if (x >= 2)
                res = Ln(x/2 - 1, eps);
            return res;
        }
    }
    
    
}