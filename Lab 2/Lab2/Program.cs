using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Input x: ");
            float x = float.Parse(Console.ReadLine());
            
            Console.Write("Input y: ");
            float y = float.Parse(Console.ReadLine());
            
            int isInShape;
            string Output;
            
            if (x >= -1)
            {
                isInShape = 1;
            }
            else if ((Math.Pow(x + 2, 2) + Math.Pow(y, 2) >= 1)&&(Math.Pow(x + 2, 2) + Math.Pow(y, 2) <= 4))
            {
                isInShape = 1;
            }
            else
            {
                isInShape = 0;
            }
            
            if (isInShape == 1)
            {
                Output = "Точка належить площинi";
            }
            else
            {
                Output = "Точка не належить площинi";
            }
            Console.WriteLine(Output);


        }
    }
}