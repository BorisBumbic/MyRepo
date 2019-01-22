using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int input = int.Parse(Console.ReadLine());

            int[] fibonacciArray = new int[input];
            fibonacciArray[0] = 0;
            fibonacciArray[1] = 1;

            for (int i = 0; i < fibonacciArray.Length - 2; i++)
            {
                fibonacciArray[i + 2] = fibonacciArray[i] + fibonacciArray[i + 1];

            }

            foreach (var item in fibonacciArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
