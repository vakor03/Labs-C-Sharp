using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = Int32.Parse(Console.ReadLine());
            
            double PiVal = 1;
            double PiGr = 0;
            int k = 0;
            double deltaVal;
            double deltaGr;

            for (int i = 0; i < n; i++)
            {
                PiGr += Math.Pow(-1, k) / (2 * k + 1);
                k++;
                Console.WriteLine($"PiGr = {PiGr:f5}, k = {k}");
            }

            PiGr *= 4;
            k = 1;
            
            
            
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    PiVal *= (k + 1d) / k;
                    k += 2;
                }
                else
                {
                    PiVal *= (k - 1d) / k;
                }
                Console.WriteLine($"PiVal = {PiVal:f5}, k = {k}");
            }
            
            PiVal *= 2;
            deltaVal = Math.PI - PiVal ;
            deltaGr =  Math.PI - PiGr;
            
            Console.WriteLine($"Delta Pi Valisa = {deltaVal,8:F5}");
            Console.WriteLine($"Delta Pi Gregori = {deltaGr,8:F5}");
        }
    }
}