using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _10._5_Product_list_with_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string,string>();
            
            string input = " ";
            string ord = " ";
            string nummer = " ";

            while (true)
            {
                Console.WriteLine("Enter product ID (digit) and name (string).");

                Console.ForegroundColor = ConsoleColor.Green;

                    input = Console.ReadLine();


                if (String.IsNullOrWhiteSpace(input))
                {
                    foreach (var item in dict)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        Console.WriteLine($"Product id {item.Key} and name {item.Value}.");
                    }

                    break;
                }

                string[] stringArray = input.Split(',');

                nummer = stringArray[0];
                ord = stringArray[1];

                try
                {
                    dict.Add(nummer, ord);
                }
                catch(ArgumentException argExc)
                {
                    Console.WriteLine(argExc);
                }


                Console.ForegroundColor = ConsoleColor.White;
                
            }
        }
    }
}
