using System;

namespace Lab_5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input your n: ");
            int n = Int32.Parse(Console.ReadLine());
            
            int maxSumOfDivs = 1;
            int numWithMaxDivs = 1;
            
            for (int i = 1; i <= n; i++)
            {
                int sumOfDivs = 0;
                for (int j = 1; j <= i; j++)
                {
                    if(i % j == 0) sumOfDivs += j;
                }
                Console.WriteLine($"Number {i} has the sum of divs: {sumOfDivs}");
                
                if (sumOfDivs > maxSumOfDivs)
                {
                    maxSumOfDivs = sumOfDivs;
                    numWithMaxDivs = i;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine($"Number {numWithMaxDivs} has the max sum: {maxSumOfDivs}");
            
            
            
        }
    }
}