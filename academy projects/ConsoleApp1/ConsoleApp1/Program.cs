using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a command");

            string userInput = Console.ReadLine();

            Console.WriteLine("Enter your preferred character");

            string pref = Console.ReadLine(); ;

            string[] userInputArray = userInput.Split();

            foreach (var item in userInputArray)
            {
                int temp = int.Parse(item);

                for (int i = 0; i < temp; i++)
                {
                    Console.Write(pref);

                    for (int j = 0; j < temp; j++)
                    {
                        Console.Write(pref);
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
