using System;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of elements: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] array = CreateRandomArray(n);
            Console.WriteLine($"Fir array: {String.Join(", ", array)}");
            
            int[] secondArray = CreateSecondArray(array);
            Console.WriteLine($"Sec array: {String.Join(", ", secondArray)}");
            
            int d = FindD(array, secondArray);
            ChangeFirstArray(ref array, d);
            
            Console.WriteLine($"d = {d}");
            Console.WriteLine($"Changed array: {String.Join(", ", array)}");
           
        }

        private static int[] CreateRandomArray(int n)
        { 
            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 50);
            }
            return array;
        }

        private static int FindMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i]) max = array[i];
            }
            return max;
        }

        private static int[] CreateSecondArray(int[] array)
        {
            int max = FindMax(array);
            Console.WriteLine($"Max el = {max}");
            int[] secondArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                secondArray[i] = max - array[i];
            }
            return secondArray;
        }

        private static int FindD(int[] array1, int[] array2)
        {
            double d = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                d += Math.Pow(array1[i] - array2[i], 2);
            }
            return (int) d;
        }

        private static void ChangeFirstArray(ref int[] array, int d)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%7==0) array[i] += d;
            }
        }
            
    }
}